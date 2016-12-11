using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt_Snake
{
    public partial class formSnakeGame : Form
    {
        private List<Panel> listPanel = new List<Panel>();  //tworzy listę paneli pomiędzy, którymi będzie można się przełączać
        private List<Circle> snake = new List<Circle>(); //tworzy listę obiektów, z której powstanie nasz snake
        Circle feed = new Circle(); //pozywienie to obiekty klasy Circle, tej samej wielkości co snake
        
        public formSnakeGame()
        {
            InitializeComponent();
            new Settings();
            //Timer, który co dany okres czasu wywoluje metode ScreenState
            timer.Interval = 1000/Settings.speed;
            timer.Tick += ScreenState;
            timer.Start();
        }

        private void formSnakeGame_Load(object sender, EventArgs e)
        {
            //W programie będą dwa panele - menu gry i plansza gry, na początek menu jest z przodu
            listPanel.Add(panelMenu);
            listPanel.Add(panelGame);
            listPanel[0].BringToFront();
            listPanel[1].SendToBack();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku start zmienia panel z menu na pole gry i chowa panel menu
            listPanel[1].BringToFront();
            listPanel[0].Visible = false; //panel menu w czasie gry jest niewidoczny
            new Settings(); //ustawia domyślne ustawienia gry na rozpoczęciu
            BeginGame();
        }

        private void BeginGame()
        {
            //metoda wywołana przy rozpoczęciu gry i przy restarcie

            new Settings(); //ustawia domyślne ustawienia gry na rozpoczęciu
             
            labelGameOverText.Visible = false; //zapewnia, że komunikat o końcu gry nie będzie widoczny
            snake.Clear(); //zapewnia, że nie pozostaną żadne "resztki" węża z poprzedniej rozgrywki
            Circle snakeHead = new Circle(5,5); //głowa naszego węża
            snake.Add(snakeHead);
            FeedSpawn(); //metoda umożliwiająca pojawienie się pożywienie w losowych punktach planszy na rozpoczęciu gry
            labelScore.Text = Settings.score.ToString(); //ustawia punktację na domyślną, czyli zero
        }

        private void FeedSpawn()
        {
            //metoda określa pole w którym może pojawić sie jedzenie i generuje losowe w którym ono sie pojawi
            //jeśli metoda zostanie wywołana
            int maxPositionX = pictureBoxGameField.Size.Width/Settings.width;
            int maxPositionY = pictureBoxGameField.Size.Height/Settings.height;
            feed = new Circle();
            Random rand = new Random();
            feed.x = rand.Next(0, maxPositionX);
            feed.y = rand.Next(0, maxPositionY);
        }

        //ta metoda będzie posłuży do odświeżania ekranu co dany okres czasu
        private void ScreenState(object sender, EventArgs e)
        {
            Movement();
            pictureBoxGameField.Invalidate();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wystawia panel menu do przodu
            listPanel[0].BringToFront();
            listPanel[1].SendToBack();
            listPanel[0].Visible = true;
        }

        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wyskakuje komunikat
            MessageBox.Show("Do poruszania się używaj strzałek, zjadaj jedzenie aby rosnąć, zderzenie z własnym ogonem lub ścianą spowoduje koniec gry", "Instrukcja gry");
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wyskakuje komunikat
            MessageBox.Show("P. K., D. M." + "\n" + "2016");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //kliknięcie przycisku zamyka program
            this.Close();
        }

        private void pictureBoxGameField_Paint(object sender, PaintEventArgs e)
        {
            Graphics pole = e.Graphics;

            if (Settings.gameOver != true)
            {
                
                Brush feedColor;

                for (int i = 0; i < snake.Count; i++)
                {
                    Brush snakeColor;
                    if (i == 0) snakeColor = Brushes.Aqua; //ustawia kolor głowy węża
                    else snakeColor = Brushes.White; //ustawia kolor reszty węża

                    feedColor = Brushes.Green; //ustawia kolor jedzenia
                    pole.FillEllipse(snakeColor, new Rectangle(snake[i].x * Settings.width, snake[i].y * Settings.height, Settings.width,Settings.height)); //wypełnia danym kolorem obiekty Circle z listy snake
                    pole.FillEllipse(feedColor, new Rectangle(feed.x * Settings.width, feed.y * Settings.height, Settings.width, Settings.height)); //wypełnia danym kolorem obiekty Circle, które posłuża za pożywienie
                }

            }
            else
            {
                //jeśli nastąpi koniec gry pojawi się ten komunikat
                string gameOverText = "Przegrałeś! Zdobyłeś " + Settings.score + " punktów. \nWciśnij ENTER aby zagrać od nowa."; //komunikat wyświetlany po przegranej
                labelGameOverText.Text = gameOverText;
                labelGameOverText.Visible = true;
            }
        }

        private void Movement()
        {
            //metoda ustala kierunek zmiany polożenia węża, zapewnia poruszanie się w tym kierunku, dba też o wykrywanie kolizji w grze

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.snakeDirection)
                    {
                        case Direction.right:
                            snake[i].x++;
                            break;
                        case Direction.down:
                            snake[i].y++;
                            break;
                        case Direction.up:
                            snake[i].y--;
                            break;
                        case Direction.left:
                            snake[i].x--;
                            break;
                    }
                    //zmienne określające maksymalne współrzędne w polu gry
                    int MaxPositionX = pictureBoxGameField.Size.Width / Settings.width;
                    int MaxPositionY = pictureBoxGameField.Size.Height / Settings.height;

                    //jeśli wąż "zderzy" się z granicami pola gry, nastąpi koniec gry
                    if (snake[i].x < 0 || snake[i].y < 0 || snake[i].x >= MaxPositionX || snake[i].y >= MaxPositionY)
                    {
                        Death();
                    }
                    //jeśli wąż "uderzy" głową w swój ogon nastąpi koniec gry
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].x == snake[j].x && snake[i].y == snake[j].y) 
                            Death(); 
                    }
                    //jeśli głowa stanie w miejscu gdzie jest pożywienie, zostanie wywołana metoda EatFeed
                    if (snake[0].x == feed.x && snake[0].y == feed.y)
                    {
                        EatFeed();
                    }

                }

                else
                {
                    //te dwie instrukcje zapewniają, że reszta węża będzie podążac za głową
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
            }
        }

        private void EatFeed()
        {
            //jeśli jedzenie znajduje się na tych samych koordynatach co głowa węża następuje dodanie nowego obiektu na koniec węża
            Circle feed = new Circle();
            feed.x = snake[snake.Count - 1].x;
            feed.y = snake[snake.Count - 1].y;
            snake.Add(feed);

            //zjedzenie pożywienia dodaje daną ilość punktów
            Settings.score += Settings.points;
            labelScore.Text = Settings.score.ToString();

            //zapewnia, że na planszy pojawi się nowy obiekt do "zjedzenia"
            FeedSpawn();
        }

        private void Death()
        {
            //metoda powodująca koniec gry w odpowiednich momentach
            Settings.gameOver = true;
        }

        //następne dwie metody ustalają odpowiednio czy dany przycisk nie jest wciśniety czy tak
        private void formSnakeGame_KeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.StateOfKey(e.KeyCode, false);
        }

        private void formSnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.StateOfKey(e.KeyCode, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Wykrywa czy podany przycisk jest wciśnięty i odpowiednio reaguje np. jeśli mamy skręcić w lewo to zmienia direction jeśli nie poruszamy się w prawo
            if (keyData == Keys.Up && Settings.snakeDirection != Direction.down)
            {
                Settings.snakeDirection = Direction.up;
                return true;
            }

            if (keyData == Keys.Down && Settings.snakeDirection != Direction.up)
            {
                Settings.snakeDirection = Direction.down;
                return true;
            }

            if (keyData == Keys.Left && Settings.snakeDirection != Direction.right)
            {
                Settings.snakeDirection = Direction.left;
                return true;
            }

            if (keyData == Keys.Right && Settings.snakeDirection != Direction.left)
            {
                Settings.snakeDirection = Direction.right;
                return true;
            }
            if (Settings.gameOver == true)
            {
                if (keyData == Keys.Enter) BeginGame();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

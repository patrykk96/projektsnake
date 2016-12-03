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
        List<Panel> listPanel = new List<Panel>();  //tworzy listę paneli pomiędzy, którymi będzie można się przełączać
        List<Circle> snake = new List<Circle>();
        Circle feed = new Circle();
        
        public formSnakeGame()
        {
            InitializeComponent();
        }

        

        private void formSnakeGame_Load(object sender, EventArgs e)
        {
            //W programie będą dwa panele - menu gry i plansza gry
            listPanel.Add(panelMenu);
            listPanel.Add(panelGame);
            listPanel[0].BringToFront();
            listPanel[1].SendToBack();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku start zmienia panel z menu na pole gry i chowa panel menu
            listPanel[1].BringToFront();
            listPanel[0].Visible = false;
            

            new Settings(); //ustawia domyślne ustawienia gry na rozpoczęciu
            timer.Interval = 10000 / Settings.speed;
            timer.Tick += ScreenState;
            timer.Start();

            BeginGame();
        }

        private void BeginGame()
        {
            new Settings(); //ustawia domyślne ustawienia gry na rozpoczęciu
            labelGameOverText.Visible = false;
            snake.Clear();
            Circle snakeHead = new Circle(10,5); //głowa naszego węża, wartosci do przetestowania
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

        //ta metoda będzie dokonywać sprawdzenia co się dzieje obecnie na ekranie i odpowiednio dostosowywać
        private void ScreenState(object sender, EventArgs e)
        {

            if (Settings.gameOver == true)
            {
                if (KeyInput.isKeyPressed(Keys.Space)) BeginGame();
            }
            else
            {
                //ponizsze instrukcje sprawdzaja czy klawisze slużące do sterowania wężem sa wciśnięte i czy możliwe jest wykonanie skrętu
                //(nie chcemy aby wąż zaczął poruszać się nagle w przeciwnym kierunku np. idzie w lewo a po na ciśnieciu klawisza porusza sie w prawo)
                if (KeyInput.isKeyPressed(Keys.Up) && Settings.snakeDirection != Direction.down)
                    Settings.snakeDirection = Direction.up;
                else if (KeyInput.isKeyPressed(Keys.Left) && Settings.snakeDirection != Direction.right)
                    Settings.snakeDirection = Direction.left;
                else if (KeyInput.isKeyPressed(Keys.Down) && Settings.snakeDirection != Direction.up)
                    Settings.snakeDirection = Direction.down;
                else if (KeyInput.isKeyPressed(Keys.Right) && Settings.snakeDirection != Direction.left)
                    Settings.snakeDirection = Direction.right;

                Movement();
            }
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
                Brush snakeColor;
                Brush feedColor;

                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0) snakeColor = Brushes.Aqua; // inny kolor głowy posłuży do sprawdzenia czy wszystko działa, do zmienienia pozniej
                    else snakeColor = Brushes.White;

                    feedColor = Brushes.Green;
                    pole.FillEllipse(snakeColor, new Rectangle(snake[i].x * Settings.width, snake[i].y * Settings.height, Settings.width,Settings.height));
                    pole.FillEllipse(feedColor, new Rectangle(feed.x * Settings.width, feed.y * Settings.height, Settings.width, Settings.height));

                }

                
            }
            else
            {
                string gameOverText = "Przegrałeś"; //komunikat do rozwiniecia pozniej
                labelGameOverText.Text = gameOverText;
                labelGameOverText.Visible = true;

            }
        }

        private void Movement()
        {

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
                }
                else
                {
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
                
            }


        }
    }
}

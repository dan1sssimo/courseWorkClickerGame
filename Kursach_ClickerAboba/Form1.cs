using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LibOFclasses;

namespace Kursach_ClickerAboba
{
    public partial class Form1 : Form
    {
        protected Graphics g;
        protected Graphics g2;
        protected Graphics g3;
        protected Graphics g4;
        protected Graphics g5;
        private Random r = new Random();
        int Allclicks = 0,n = 1;
        int hppodzemka = 10, hpboss1 = 36, hpboss2 = 66, hpboss3 = 88, hpboss4 = 150;
        int balance = 0,casemenu=0;
        int weapon1=0, weapon2 = 0, weapon3 = 0, weapon4 = 0, weapon5 = 0;
        int start = 300, end = 175;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            hpenemy.Visible = false;
            allclik.Visible = false;
            money.Visible = false;
            Enemy.Visible = false;
            menugame.Visible = false;
            infokill.Visible = false;
            Serdze.Visible = false;
            Serdze2.Visible = false;
            Serdze3.Visible = false;
            monetka.Visible = false;
            prodavetz.Visible = false;
            position1.Visible = false;
            position2.Visible = false;
            position3.Visible = false;
            position4.Visible = false;
            position5.Visible = false;
            gun1.Visible = false;
            gun2.Visible = false;
            gun3.Visible = false;
            gun4.Visible = false;
            gun5.Visible = false;
            sword1.Visible = false;
            sword2.Visible = false;
            sword3.Visible = false;
            sword4.Visible = false;
            sword5.Visible = false;
            helpshop.Visible = false;
        }
        private void VisibleBox()
        {
            hpenemy.Visible = true;
            allclik.Visible = true;
            money.Visible = true;
            label2.Visible = false;
            Podzemka.Visible = false;
            Boss1.Visible = false;
            Boss2.Visible = false;
            Boss3.Visible = false;
            Boss4.Visible = false;
            Tutorial.Visible = false;
            Enemy.Visible = true;
            menugame.Visible = true;
            Serdze.Visible = true;
            Serdze2.Visible = true;
            Serdze3.Visible = true;
            monetka.Visible = true;
        }
        private void EnemyBloodCreate()
        {
            g = Enemy.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[30];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(3))
                {
                    case 1:
                        arr[0] = new LibOFclasses.Blood();
                        arr[0].Draw(g);
                        break;
                }
            }
        }
        private void EnemyGreenBloodCreate()
        {
            g2 = Enemy.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[80];
            for (int i = 0; i < arr.Length; i++)
            {
                        arr[0] = new LibOFclasses.BuildBlood();
                        arr[0].Draw(g2);
            }
        }
        private void EnemyBloodFor2Boss()
        {
            g3 = Enemy.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[20];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(3))
                {
                    case 1:
                        arr[0] = new LibOFclasses.BuildBlood();
                        arr[0].Draw(g3);
                        break;
                    case 2:
                        arr[0] = new LibOFclasses.Blood();
                        arr[0].Draw(g);
                        break;
                }
            }
        }
        private void EnemyBloodFor3Boss()
        {
            g4 = Enemy.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[30];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(2))
                {
                    case 1:
                        arr[0] = new LibOFclasses.KnifeDamage();
                        arr[0].Draw(g4);
                        break;
                }
            }
        }
        private void EnemyBloodFor4Boss()
        {
            g5 = Enemy.CreateGraphics();
            ColorOfBlood[] arr = new ColorOfBlood[120];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (r.Next(4))
                {
                    case 1:
                        arr[0] = new LibOFclasses.BuildBlood();
                        arr[0].Draw(g5);
                        break;
                    case 2:
                        arr[0] = new LibOFclasses.Blood();
                        arr[0].Draw(g5);
                        break;
                    case 3:
                        arr[0] = new LibOFclasses.KnifeDamage();
                        arr[0].Draw(g5);
                        break;
                }
            }
        }

        private void RandPossBoss1()
        {
            for (int i = 0; i < 1; i++)
            {
                switch (r.Next(4))
                {
                    case 1:
                        Enemy.Location = new Point(80, 80);
                        break;
                    case 2:
                        Enemy.Location = new Point(360, 60);
                        break;
                    case 3:
                        Enemy.Location = new Point(300, 260);
                        break;
                }
            }
        }

        private void RandPossBoss2()
        {
            for(int i=0;i<1;i++)
            {
                switch(r.Next(4))
                {
                    case 1: 
                        Enemy.Location = new Point(81,66);
                        break;
                    case 2:
                        Enemy.Location = new Point(535,79);
                        break;
                    case 3:
                        Enemy.Location = new Point(237, 185);
                        break;
                }
            }
        }

        private void RandPossBossLast()
        {
            for (int i = 0; i < 1; i++)
            {
                switch (r.Next(6))
                {
                    case 1:
                        Enemy.Location = new Point(360, 60);
                        break;
                    case 2:
                        Enemy.Location = new Point(81, 66);
                        break;
                    case 3:
                        Enemy.Location = new Point(535, 79);
                        break;
                    case 4:
                        Enemy.Location = new Point(237, 185);
                        break;
                    case 5:
                        Enemy.Location = new Point(300, 260);
                        break;
                }
            }
        }

        private void RandPictureBoss2()
        {
            for (int i = 0; i < 1; i++)
            {
                switch (r.Next(3))
                {
                    case 1:
                        Enemy.Image = Properties.Resources.zall;
                        break;
                    case 2:
                        Enemy.Image = Properties.Resources.zall2;
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr circleEnemy = CreateEllipticRgn(0, 0, Enemy.Width - 15, Enemy.Height - 15);
            SetWindowRgn(Enemy.Handle, circleEnemy, true);

            this.BackgroundImage = Properties.Resources.fontmenu1;
            Enemy.Location = new Point(start, end);
        }
        private void menugame_Click(object sender, EventArgs e)
        {
            hpenemy.Visible = false;
            allclik.Visible = false;
            money.Visible = false;
            label2.Visible = true;
            Podzemka.Visible = true;
            Boss1.Visible = true;
            Boss2.Visible = true;
            Boss3.Visible = true;
            Boss4.Visible = true;
            Tutorial.Visible = true;
            Enemy.Visible = false;
            menugame.Visible = false;
            infokill.Visible = false;
            Serdze.Visible = false;
            Serdze2.Visible = false;
            Serdze3.Visible = false;
            monetka.Visible = false;
            prodavetz.Visible = false;
            shop.Visible = true;
            position1.Visible = false;
            position2.Visible = false;
            position3.Visible = false;
            position4.Visible = false;
            position5.Visible = false;
            gun1.Visible = false;
            gun2.Visible = false;
            gun3.Visible = false;
            gun4.Visible = false;
            gun5.Visible = false;
            sword1.Visible = false;
            sword2.Visible = false;
            sword3.Visible = false;
            sword4.Visible = false;
            sword5.Visible = false;
            helpshop.Visible = false;
            this.BackgroundImage = Properties.Resources.fontmenu1;
            Enemy.Location = new Point(start, end);
        }

        private void Podzemka_Click(object sender, EventArgs e)
        {
            VisibleBox();
            casemenu = 1;
            this.BackgroundImage = Properties.Resources.pecheru;
            Enemy.Image = Properties.Resources.glad;
            hpenemy.Text = ("Очки життя ворогу:").ToString() + (hppodzemka).ToString();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            hpenemy.Visible = false;
            allclik.Visible = false;
            money.Visible = true;
            label2.Visible = false;
            Podzemka.Visible = false;
            Boss1.Visible = false;
            Boss2.Visible = false;
            Boss3.Visible = false;
            Boss4.Visible = false;
            menugame.Visible = true;
            Tutorial.Visible =false;
            Enemy.Visible = false;
            infokill.Visible = false;
            Serdze.Visible = false;
            Serdze2.Visible = false;
            Serdze3.Visible = false;
            monetka.Visible = true;
            shop.Visible = false;
            prodavetz.Visible = true;
            position1.Visible = true;
            position2.Visible = true;
            position3.Visible = true;
            position4.Visible = true;
            position5.Visible = true;
            gun1.Visible = true;
            gun2.Visible = true;
            gun3.Visible = true;
            gun4.Visible = true;
            gun5.Visible = true;
            sword1.Visible = true;
            sword2.Visible = true;
            sword3.Visible = true;
            sword4.Visible = true;
            sword5.Visible = true;
            helpshop.Visible = true;
            this.BackgroundImage = Properties.Resources.shopback;
        }

        private void gun1_Click(object sender, EventArgs e)
        {
            if(balance<50)
            MessageBox.Show("Кількість ваших монет менша за 50.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (balance >= 50 && weapon1==0)
            {
                balance = balance - 50;
                weapon1 = 1;
                n = n + 1;
                money.Text = ("Coins:").ToString() + (balance).ToString();
                MessageBox.Show("Ви успішно придбали предмет.", "Успіх!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ви вже купили цей предмет.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Суть гри полягає у тому, що Ви повинні натискати на ворогів і вбивати їх. За кожного вбитого ворога Ви будете отримувати Coins, які Ви зможете витратити у магазині.                                          Вдалої гри!!!", "Пояснення.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gun2_Click(object sender, EventArgs e)
        {
            if (balance < 150)
                MessageBox.Show("Кількість ваших монет менша за 150.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (balance >= 150 && weapon2 == 0)
            {
                balance = balance - 150;
                weapon2 = 1;
                n = 2;
                money.Text = ("Coins:").ToString() + (balance).ToString();
                MessageBox.Show("Ви успішно придбали предмет.", "Успіх!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ви вже купили цей предмет.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gun3_Click(object sender, EventArgs e)
        {
            if (balance < 200)
                MessageBox.Show("Кількість ваших монет менша за 200.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               if (balance >= 200 && weapon3 == 0)
            {
                balance = balance - 200;
                weapon3 = 1;
                n = 3;
                money.Text = ("Coins:").ToString() + (balance).ToString();
                MessageBox.Show("Ви успішно придбали предмет.", "Успіх!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ви вже купили цей предмет.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gun4_Click(object sender, EventArgs e)
        {
            if (balance < 500)
                MessageBox.Show("Кількість ваших монет менша за 500.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               if (balance >= 500 && weapon4 == 0)
            {
                balance = balance - 500;
                weapon4 = 1;
                n = 4;
                money.Text = ("Coins:").ToString() + (balance).ToString();
                MessageBox.Show("Ви успішно придбали предмет.", "Успіх!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ви вже купили цей предмет.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gun5_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
                MessageBox.Show("Кількість ваших монет менша за 1000.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
              if (balance >= 1000 && weapon5 == 0)
            {
                balance = balance - 1000;
                weapon5 = 1;
                n = 5;
                money.Text = ("Coins:").ToString() + (balance).ToString();
                MessageBox.Show("Ви успішно придбали предмет.", "Успіх!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ви вже купили цей предмет.", "Заборона!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Boss1_Click(object sender, EventArgs e)
        {
            if (Allclicks < 40)
                MessageBox.Show("Кількість ваших кліків менша за 40, повертайся пізніше.", "Попередження!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               if (Allclicks >= 40)
            {
                VisibleBox();
                casemenu = 2;
                Enemy.Image = Properties.Resources.boss1;
                this.BackgroundImage = Properties.Resources.bossFOn;
                hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss1).ToString();
                if (hpboss1 < 12)
                {
                    Serdze3.Visible = false;
                    Serdze2.Visible = false;
                }
                else if (hpboss1 < 24)
                {
                    Serdze3.Visible = false;
                }
            }
        }

        private void Boss2_Click(object sender, EventArgs e)
        {
            if (Allclicks < 76)
                MessageBox.Show("Кількість ваших кліків менша за 76, повертайся пізніше.", "Попередження!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               if (Allclicks >=76)
            {
                VisibleBox();
                this.BackgroundImage = Properties.Resources.fullhd2;
                Enemy.Image = Properties.Resources.zall;
                hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss2).ToString();
                casemenu = 3;
                if (hpboss2 < 20)
                {
                    Serdze3.Visible = false;
                    Serdze2.Visible = false;
                }
                else if (hpboss2 < 45)
                {
                    Serdze3.Visible = false;
                }
            }
        }
        private void Boss3_Click(object sender, EventArgs e)
        {
            if (Allclicks < 126)
                MessageBox.Show("Кількість ваших кліків менша за 126, повертайся пізніше.", "Попередження!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               if (Allclicks >= 126)
            {
                VisibleBox();
                this.BackgroundImage = Properties.Resources.les;
                Enemy.Image = Properties.Resources.zall;
                hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss3).ToString();
                casemenu = 4;
                if (hpboss3 < 25)
                {
                    Serdze3.Visible = false;
                    Serdze2.Visible = false;
                }
                else if (hpboss3 < 50)
                {
                    Serdze3.Visible = false;
                }
            }
        }

        private void Boss4_Click(object sender, EventArgs e)
        {
            if (Allclicks < 200)
                MessageBox.Show("Кількість ваших кліків менша за 200, повертайся пізніше.", "Попередження!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (Allclicks >= 200)
            {
                VisibleBox();
                this.BackgroundImage = Properties.Resources.lastfont;
                Enemy.Image = Properties.Resources.gifglad;
                hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss4).ToString();
                casemenu = 5;
                if (hpboss4 < 50)
                {
                    Serdze3.Visible = false;
                    Serdze2.Visible = false;
                }
                else if (hpboss4 < 100)
                {
                    Serdze3.Visible = false;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (casemenu == 1)
            {
                infokill.Visible = false;
                EnemyBloodCreate();
                int Xposs = r.Next(500);
                int Yposs = 175;
                Enemy.Location = new Point(Xposs, Yposs);
                if (hppodzemka <=0)
                {
                    hppodzemka = 10;
                    Enemy.Location = new Point(start, end);
                    balance = balance + 50;
                    Enemy.Image = null;
                    infokill.Visible = true;
                    if (Allclicks % 30 == 0 || Allclicks%3==0) 
                        Enemy.Image = Properties.Resources.mob3; 
                    else
                        if(Allclicks%20 ==0 ||  Allclicks % 2 == 0)
                                 Enemy.Image = Properties.Resources.man1;
                    else
                        Enemy.Image = Properties.Resources.glad;
                }
                hppodzemka = hppodzemka - n;
                if (hppodzemka >= 0)
                    hpenemy.Text = ("Очки життя ворогу:").ToString() + (hppodzemka).ToString();                    
                Allclicks = Allclicks + n;
                allclik.Text = ("Загальна кількість кліків:").ToString() + (Allclicks).ToString();
                money.Text = ("Coins:").ToString() + (balance).ToString(); 
            }
                    else if(casemenu==2)
                    {
                        EnemyGreenBloodCreate();
                        RandPossBoss1();
                        if (hpboss1 <= 0)
                        {
                           Serdze.Visible = false;
                           Enemy.Location = new Point(start, end);
                           hpboss1 = 36;
                           MessageBox.Show("Ви перемогли Холлу та отримали в нагороду 150 coins, які Ви можете витратити у магазині.", "Ви вбили ворога!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           balance = balance + 150;
                           menugame_Click(sender, e);
                           Enemy.Image = null;
                           Enemy.Image = Properties.Resources.boss1;
                        }
                        else if(hpboss1<12)
                        {
                            Serdze3.Visible = false;
                            Serdze2.Visible = false;
                        }
                        else if(hpboss1<24)
                        {
                            Serdze3.Visible = false;
                        }
                        hpboss1 = hpboss1 - n;
                        if (hpboss1 >= 0)
                        hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss1).ToString();
                        Allclicks = Allclicks + n;
                        allclik.Text = ("Загальна кількість кліків:").ToString() + (Allclicks).ToString();
                        money.Text = ("Coins:").ToString() + (balance).ToString();
                    }
                        else if(casemenu==3)
                        {
                            EnemyBloodFor2Boss();
                            RandPossBoss2();
                            if (hpboss2 <= 0)
                            {
                                Serdze.Visible = false;
                                Enemy.Location = new Point(start, end);
                                hpboss2 = 67;
                                MessageBox.Show("Ви перемогли Цаля та отримали в нагороду 200 coins, які Ви можете витратити у магазині.", "Ви вбили ворога!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                balance = balance + 200;
                                menugame_Click(sender, e);
                                Enemy.Image = null;
                                Enemy.Image = Properties.Resources.zall;
                            }
                            else if (hpboss2 < 20)
                            {
                                Serdze3.Visible = false;
                                Serdze2.Visible = false;
                            }
                            else if (hpboss2 < 45)
                            {
                                Serdze3.Visible = false;
                            }
                            hpboss2 = hpboss2 - n;
                            if (hpboss2 >= 0)
                            hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss2).ToString();
                            Allclicks = Allclicks + n;
                            allclik.Text = ("Загальна кількість кліків:").ToString() + (Allclicks).ToString();
                            money.Text = ("Coins:").ToString() + (balance).ToString();
                        }
                            else if(casemenu==4)
                            {
                                RandPictureBoss2();
                                EnemyBloodFor3Boss();
                                RandPossBoss2();
                                if (hpboss3 <= 0)
                                {
                                    Serdze.Visible = false;
                                    Enemy.Location = new Point(start, end);
                                    hpboss3 = 88;
                                    MessageBox.Show("Ви перемогли Цаля Ragee та отримали в нагороду 250 coins, які Ви можете витратити у магазині.", "Ви вбили ворога!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    balance = balance + 250;
                                    menugame_Click(sender, e);
                                    Enemy.Image = null;
                                    Enemy.Image = Properties.Resources.zall;
                                }
                                else if (hpboss3 < 25)
                                {
                                    Serdze3.Visible = false;
                                    Serdze2.Visible = false;
                                }
                                else if (hpboss3 < 50)
                                {
                                    Serdze3.Visible = false;
                                }
                                hpboss3 = hpboss3 - n;
                                if (hpboss3 >= 0)
                                hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss3).ToString();
                                Allclicks = Allclicks + n;
                                allclik.Text = ("Загальна кількість кліків:").ToString() + (Allclicks).ToString();
                                money.Text = ("Coins:").ToString() + (balance).ToString();
                            }
                                else if (casemenu == 5)
                                {
                                    EnemyBloodFor4Boss();
                                    RandPossBossLast();
                                    if (hpboss4 <= 0)
                                    {
                                        Serdze.Visible = false;
                                        Enemy.Location = new Point(start, end);
                                        hpboss4 = 150;
                                        MessageBox.Show("Ви перемогли Абобуса та отримали в нагороду 500 coins, які Ви можете витратити у магазині.", "Ви вбили ворога!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        balance = balance + 500;
                                        menugame_Click(sender, e);
                                        Enemy.Image = null;
                                        Enemy.Image = Properties.Resources.zall;
                                    }
                                    else if (hpboss4 < 50)
                                    {
                                        Serdze3.Visible = false;
                                        Serdze2.Visible = false;
                                    }
                                    else if (hpboss4 < 100)
                                    {
                                        Serdze3.Visible = false;
                                    }
                                    hpboss4 = hpboss4 - n;
                                    if (hpboss4 >= 0)
                                    hpenemy.Text = ("Очки життя ворогу:").ToString() + (hpboss4).ToString();
                                    Allclicks = Allclicks + n;
                                    allclik.Text = ("Загальна кількість кліків:").ToString() + (Allclicks).ToString();
                                    money.Text = ("Coins:").ToString() + (balance).ToString();
                                }
        }

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateEllipticRgn(int Left, int Top, int Right, int Bot);
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr Vusota, IntPtr VusKr, bool bRed);
    }
}

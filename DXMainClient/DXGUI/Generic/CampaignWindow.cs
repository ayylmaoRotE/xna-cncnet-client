using ClientCore;
using ClientGUI;
using DTAClient.Domain;
using Microsoft.Xna.Framework;
using Rampastring.XNAUI;
using System;
using System.Diagnostics;

namespace DTAClient.DXGUI.Generic
{
    public class CampaignWindow : XNAWindow
    {
        private DiscordHandler discordHandler;

        public CampaignWindow(WindowManager windowManager) : base(windowManager)
        {

        }

        public CampaignWindow(WindowManager windowManager, DiscordHandler discordHandler) : this(windowManager)
        {
            this.discordHandler = discordHandler;
        }

        public override void Initialize()
        {
            Name = "CampaignWindow";
            ClientRectangle = new Rectangle(0, 0, 284, 190);
            BackgroundTexture = AssetLoader.LoadTexture("Resources\\RotE Theme\\MainMenu\\mainmenubg.png");

            var btnCampaignRA2 = new XNAClientButton(WindowManager);
            btnCampaignRA2.Name = "btnCampaignRA2";
            btnCampaignRA2.ClientRectangle = new Rectangle(76, 17, 133, 23);
            btnCampaignRA2.Text = "Red Alert 2";
            btnCampaignRA2.LeftClick += BtnCampaignRA2_LeftClick;

            var btnCampaignYR = new XNAClientButton(WindowManager);
            btnCampaignYR.Name = "btnCampaignYR";
            btnCampaignYR.ClientRectangle = new Rectangle(76, 59, 133, 23);
            btnCampaignYR.Text = "Yuri's Revenge";
            btnCampaignYR.LeftClick += BtnCampaignYR_LeftClick;

            var btnCampaignGEN = new XNAClientButton(WindowManager);
            btnCampaignGEN.Name = "btnCampaignGEN";
            btnCampaignGEN.ClientRectangle = new Rectangle(76, 101, 133, 23);
            btnCampaignGEN.Text = "Generals";
            btnCampaignGEN.LeftClick += BtnCampaignGEN_LeftClick;

            var btnCampaignROTE = new XNAClientButton(WindowManager);
            btnCampaignROTE.Name = "btnCampaignROTE";
            btnCampaignROTE.ClientRectangle = new Rectangle(76, 143, 133, 23);
            btnCampaignROTE.Text = "Rise of the East";
            btnCampaignROTE.LeftClick += BtnCampaignROTE_LeftClick;

            var btnChallenge = new XNAClientButton(WindowManager);
            btnChallenge.Name = "btnChallenge";
            btnChallenge.ClientRectangle = new Rectangle(76, 185, 133, 23);
            btnChallenge.Text = "Challenge Maps";
            btnChallenge.LeftClick += BtnChallenge_LeftClick;

            var btnCamCancel = new XNAClientButton(WindowManager);
            btnCamCancel.Name = "btnCamCancel";
            btnCamCancel.ClientRectangle = new Rectangle(76, 227, 133, 23);
            btnCamCancel.Text = "Cancel";
            btnCamCancel.LeftClick += BtnCamCancel_LeftClick;

            AddChild(btnCampaignRA2);
            AddChild(btnCampaignYR);
            AddChild(btnCampaignGEN);
            AddChild(btnCampaignROTE);
            AddChild(btnChallenge);
            AddChild(btnCamCancel);

            base.Initialize();

            CenterOnParent();
        }

        private void BtnCampaignRA2_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelector);
        }

        private void BtnCampaignYR_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelector);
        }

        private void BtnCampaignGEN_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelector);
        }

        private void BtnCampaignROTE_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelector);
        }

        private void BtnChallenge_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelector);
        }

        private void BtnCamCancel_LeftClick(object sender, EventArgs e)
        {
            Enabled = false;
        }
    }
}

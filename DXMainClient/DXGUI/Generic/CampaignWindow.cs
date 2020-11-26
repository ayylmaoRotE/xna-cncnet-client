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
        public CampaignWindow(WindowManager windowManager) : base(windowManager)
        {

        }

        public override void Initialize()
        {
            Name = "CampaignWindow";
            ClientRectangle = new Rectangle(0, 0, 284, 190);
            BackgroundTexture = AssetLoader.LoadTexture("mainmenubg.png");

            var btnRA2Campaign = new XNAClientButton(WindowManager);
            btnRA2Campaign.Name = "btnRA2Campaign";
            btnRA2Campaign.ClientRectangle = new Rectangle(76, 15, 133, 23);
            btnRA2Campaign.Text = "RA2 Campaign";
            btnRA2Campaign.LeftClick += BtnRA2Campaign_LeftClick;

            var btnYRCampaign = new XNAClientButton(WindowManager);
            btnYRCampaign.Name = "btnYRCampaign";
            btnYRCampaign.ClientRectangle = new Rectangle(76, 30, 133, 23);
            btnYRCampaign.Text = "YR Campaign";
            btnYRCampaign.LeftClick += BtnYRCampaign_LeftClick;

            var btnGENCampaign = new XNAClientButton(WindowManager);
            btnGENCampaign.Name = "btnGENCampaign";
            btnGENCampaign.ClientRectangle = new Rectangle(76, 45, 133, 23);
            btnGENCampaign.Text = "Generals Campaign";
            btnGENCampaign.LeftClick += BtnGENCampaign_LeftClick;

            var btnROTECampaign = new XNAClientButton(WindowManager);
            btnROTECampaign.Name = "btnROTECampaign";
            btnROTECampaign.ClientRectangle = new Rectangle(76, 60, 133, 23);
            btnROTECampaign.Text = "RotE Campaign";
            btnROTECampaign.LeftClick += BtnROTECampaign_LeftClick;

            var btnChallenge = new XNAClientButton(WindowManager);
            btnChallenge.Name = "btnChallenge";
            btnChallenge.ClientRectangle = new Rectangle(76, 75, 133, 23);
            btnChallenge.Text = "Challenge Maps";
            btnChallenge.LeftClick += BtnChallenge_LeftClick;

            var btnCampCancel = new XNAClientButton(WindowManager);
            btnCampCancel.Name = "btnCampCancel";
            btnCampCancel.ClientRectangle = new Rectangle(76, 90, 133, 23);
            btnCampCancel.Text = "Cancel";
            btnCampCancel.LeftClick += BtnCampCancel_LeftClick;

            AddChild(btnRA2Campaign);
            AddChild(btnYRCampaign);
            AddChild(btnGENCampaign);
            AddChild(btnROTECampaign);
            AddChild(btnChallenge);
            AddChild(btnCampCancel);

            base.Initialize();

            CenterOnParent();
        }

        private void BtnRA2Campaign_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelectorRA2);
        }

        private void BtnYRCampaign_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelectorYR);
        }

        private void BtnGENCampaign_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelectorGEN);
        }

        private void BtnROTECampaign_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelectorROTE);
        }

        private void BtnChallenge_LeftClick(object sender, EventArgs e)
        {
            MainMenuDarkeningPanel parent = (MainMenuDarkeningPanel)Parent;
            parent.Show(parent.CampaignSelectorCHL);
        }

        private void BtnCampCancel_LeftClick(object sender, EventArgs e)
        {
            Enabled = false;
        }
    }
}

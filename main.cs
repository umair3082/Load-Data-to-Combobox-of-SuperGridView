common_code cc = new common_code();
#region Load CMB of SuperGridview
cc.CMB_in_SuperGridview_Load(superGridControl2, 0, @"SELECT distinct [fee] FROM [dbo].[fee]");
#endregion

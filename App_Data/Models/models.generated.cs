//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.0.90
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;



namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("umbMaster")]
	public partial class UmbMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Key words
		///</summary>
		[ImplementPropertyType("keyWords")]
		public string KeyWords
		{
			get { return this.GetPropertyValue<string>("keyWords"); }
		}

		///<summary>
		/// NavSortId: 栏目排序
		///</summary>
		[ImplementPropertyType("navSortId")]
		public int NavSortId
		{
			get { return this.GetPropertyValue<int>("navSortId"); }
		}

		///<summary>
		/// Page title: The page title overrules the name this page was given. So if the page name is "About us" the title could be "About Our Company Name".
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Hide in navigation?: If set to "Yes", this page will be hidden from the navigation menu at the top.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner background image
		///</summary>
		[ImplementPropertyType("bannerBackgroundImage")]
		public object BannerBackgroundImage
		{
			get { return this.GetPropertyValue("bannerBackgroundImage"); }
		}

		///<summary>
		/// Banner Header
		///</summary>
		[ImplementPropertyType("bannerHeader")]
		public string BannerHeader
		{
			get { return this.GetPropertyValue<string>("bannerHeader"); }
		}

		///<summary>
		/// Banner link
		///</summary>
		[ImplementPropertyType("bannerLink")]
		public object BannerLink
		{
			get { return this.GetPropertyValue("bannerLink"); }
		}

		///<summary>
		/// Banner link text
		///</summary>
		[ImplementPropertyType("bannerLinkText")]
		public string BannerLinkText
		{
			get { return this.GetPropertyValue<string>("bannerLinkText"); }
		}

		///<summary>
		/// Banner Subheader
		///</summary>
		[ImplementPropertyType("bannerSubheader")]
		public string BannerSubheader
		{
			get { return this.GetPropertyValue<string>("bannerSubheader"); }
		}

		///<summary>
		/// Dribbble link
		///</summary>
		[ImplementPropertyType("dribbbleLink")]
		public string DribbbleLink
		{
			get { return this.GetPropertyValue<string>("dribbbleLink"); }
		}

		///<summary>
		/// Facebook link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Google+ link
		///</summary>
		[ImplementPropertyType("googleLink")]
		public string GoogleLink
		{
			get { return this.GetPropertyValue<string>("googleLink"); }
		}

		///<summary>
		/// Hide banner?
		///</summary>
		[ImplementPropertyType("hideBanner")]
		public bool HideBanner
		{
			get { return this.GetPropertyValue<bool>("hideBanner"); }
		}

		///<summary>
		/// LinkedIn link
		///</summary>
		[ImplementPropertyType("linkedInLink")]
		public string LinkedInLink
		{
			get { return this.GetPropertyValue<string>("linkedInLink"); }
		}

		///<summary>
		/// Rss link
		///</summary>
		[ImplementPropertyType("rssLink")]
		public string RssLink
		{
			get { return this.GetPropertyValue<string>("rssLink"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Twitter link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}
	}

	/// <summary>Blog Item</summary>
	[PublishedContentModel("octBlogItem")]
	public partial class OctBlogItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octBlogItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctBlogItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctBlogItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BlogCategory
		///</summary>
		[ImplementPropertyType("blogCategory")]
		public object BlogCategory
		{
			get { return this.GetPropertyValue("blogCategory"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Icon
		///</summary>
		[ImplementPropertyType("icon")]
		public object Icon
		{
			get { return this.GetPropertyValue("icon"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}

		///<summary>
		/// Publish date: You can overrule the date shown on the site by changing it here. If you don't set a date explicitly here then the news item's create date will be shown.
		///</summary>
		[ImplementPropertyType("publishDate")]
		public DateTime PublishDate
		{
			get { return this.GetPropertyValue<DateTime>("publishDate"); }
		}

		///<summary>
		/// Subheader
		///</summary>
		[ImplementPropertyType("subheader")]
		public string Subheader
		{
			get { return this.GetPropertyValue<string>("subheader"); }
		}
	}

	/// <summary>Blog Overview</summary>
	[PublishedContentModel("octBlogOverview")]
	public partial class OctBlogOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octBlogOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctBlogOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctBlogOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("umbTextPage")]
	public partial class UmbTextPage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbTextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbTextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbTextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Featured Page?: Is this a page that should be featured on the home page?
		///</summary>
		[ImplementPropertyType("featuredPage")]
		public bool FeaturedPage
		{
			get { return this.GetPropertyValue<bool>("featuredPage"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}
	}

	/// <summary>Price</summary>
	[PublishedContentModel("price")]
	public partial class Price : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "price";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Price(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Price, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Professional Edition Buy Url: Professional Edition Buy Url
		///</summary>
		[ImplementPropertyType("professionalEditionBuyUrl")]
		public Newtonsoft.Json.Linq.JArray ProfessionalEditionBuyUrl
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("professionalEditionBuyUrl"); }
		}

		///<summary>
		/// Professional Edition Price: Professional Edition Current Price
		///</summary>
		[ImplementPropertyType("professionalEditionPrice")]
		public int ProfessionalEditionPrice
		{
			get { return this.GetPropertyValue<int>("professionalEditionPrice"); }
		}

		///<summary>
		/// Standard Edition Buy Url: Standard Edition Buy Url
		///</summary>
		[ImplementPropertyType("standardEditionBuyUrl")]
		public Newtonsoft.Json.Linq.JArray StandardEditionBuyUrl
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("standardEditionBuyUrl"); }
		}

		///<summary>
		/// Standard Edition Price: Standard Edition Current Price
		///</summary>
		[ImplementPropertyType("standardEditionPrice")]
		public int StandardEditionPrice
		{
			get { return this.GetPropertyValue<int>("standardEditionPrice"); }
		}
	}

	/// <summary>Download</summary>
	[PublishedContentModel("download")]
	public partial class Download : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "download";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Download(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Download, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Download Url
		///</summary>
		[ImplementPropertyType("downloadUrl")]
		public string DownloadUrl
		{
			get { return this.GetPropertyValue<string>("downloadUrl"); }
		}
	}

	/// <summary>Common</summary>
	[PublishedContentModel("common")]
	public partial class Common : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "common";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Common(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Common, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Profile</summary>
	[PublishedContentModel("profile")]
	public partial class Profile : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "profile";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Profile(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Profile, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Orders</summary>
	[PublishedContentModel("orders")]
	public partial class Orders : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "orders";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Orders(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Orders, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Tutorial Overview</summary>
	[PublishedContentModel("octTutorialOverview")]
	public partial class OctTutorialOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octTutorialOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctTutorialOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctTutorialOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Tutorial Item</summary>
	[PublishedContentModel("octTutorialItem")]
	public partial class OctTutorialItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octTutorialItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctTutorialItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctTutorialItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// All Show
		///</summary>
		[ImplementPropertyType("allShow")]
		public bool AllShow
		{
			get { return this.GetPropertyValue<bool>("allShow"); }
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public object Category
		{
			get { return this.GetPropertyValue("category"); }
		}

		///<summary>
		/// Graphic Tutorial
		///</summary>
		[ImplementPropertyType("graphicTutorial")]
		public IHtmlString GraphicTutorial
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicTutorial"); }
		}

		///<summary>
		/// Learn Category
		///</summary>
		[ImplementPropertyType("learnCategory")]
		public object LearnCategory
		{
			get { return this.GetPropertyValue("learnCategory"); }
		}

		///<summary>
		/// On top
		///</summary>
		[ImplementPropertyType("onTop")]
		public bool OnTop
		{
			get { return this.GetPropertyValue<bool>("onTop"); }
		}

		///<summary>
		/// Thumbnail
		///</summary>
		[ImplementPropertyType("thumbnail")]
		public object Thumbnail
		{
			get { return this.GetPropertyValue("thumbnail"); }
		}

		///<summary>
		/// Tutorial Name
		///</summary>
		[ImplementPropertyType("tutorialName")]
		public string TutorialName
		{
			get { return this.GetPropertyValue<string>("tutorialName"); }
		}

		///<summary>
		/// Video Tutorial: Video url
		///</summary>
		[ImplementPropertyType("videoTutorial")]
		public string VideoTutorial
		{
			get { return this.GetPropertyValue<string>("videoTutorial"); }
		}
	}

	/// <summary>Manual Overview</summary>
	[PublishedContentModel("octManualOverview")]
	public partial class OctManualOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octManualOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctManualOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctManualOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Manual Item</summary>
	[PublishedContentModel("octManualItem")]
	public partial class OctManualItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octManualItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctManualItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctManualItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body Text: content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Section Name
		///</summary>
		[ImplementPropertyType("sectionName")]
		public string SectionName
		{
			get { return this.GetPropertyValue<string>("sectionName"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tags")]
		public object Tags
		{
			get { return this.GetPropertyValue("tags"); }
		}
	}

	/// <summary>Release Item</summary>
	[PublishedContentModel("releaseItem")]
	public partial class ReleaseItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "releaseItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ReleaseItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ReleaseItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Current Version
		///</summary>
		[ImplementPropertyType("currentVersion")]
		public string CurrentVersion
		{
			get { return this.GetPropertyValue<string>("currentVersion"); }
		}

		///<summary>
		/// Notes
		///</summary>
		[ImplementPropertyType("notes")]
		public IHtmlString Notes
		{
			get { return this.GetPropertyValue<IHtmlString>("notes"); }
		}

		///<summary>
		/// Release Date
		///</summary>
		[ImplementPropertyType("releaseDate")]
		public DateTime ReleaseDate
		{
			get { return this.GetPropertyValue<DateTime>("releaseDate"); }
		}
	}

	/// <summary>FAQ Item</summary>
	[PublishedContentModel("octFAQItem")]
	public partial class OctFaqitem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octFAQItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctFaqitem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctFaqitem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// FaqCategory
		///</summary>
		[ImplementPropertyType("faqCategory")]
		public object FaqCategory
		{
			get { return this.GetPropertyValue("faqCategory"); }
		}

		///<summary>
		/// FaqContent
		///</summary>
		[ImplementPropertyType("faqContent")]
		public IHtmlString FaqContent
		{
			get { return this.GetPropertyValue<IHtmlString>("faqContent"); }
		}

		///<summary>
		/// FaqTitle
		///</summary>
		[ImplementPropertyType("faqTitle")]
		public string FaqTitle
		{
			get { return this.GetPropertyValue<string>("faqTitle"); }
		}
	}

	/// <summary>FAQ Overview</summary>
	[PublishedContentModel("octFaqOverview")]
	public partial class OctFaqOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "octFaqOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OctFaqOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OctFaqOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>TutorialSearcher</summary>
	[PublishedContentModel("tutorialSearcher")]
	public partial class TutorialSearcher : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "tutorialSearcher";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TutorialSearcher(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TutorialSearcher, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Empty Page</summary>
	[PublishedContentModel("emptyPage")]
	public partial class EmptyPage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "emptyPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EmptyPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EmptyPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}
	}

	/// <summary>Tutorial Item v7</summary>
	[PublishedContentModel("tutorialItemV7")]
	public partial class TutorialItemV7 : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "tutorialItemV7";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TutorialItemV7(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TutorialItemV7, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// All Show
		///</summary>
		[ImplementPropertyType("allShow")]
		public bool AllShow
		{
			get { return this.GetPropertyValue<bool>("allShow"); }
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public object Category
		{
			get { return this.GetPropertyValue("category"); }
		}

		///<summary>
		/// Graphic Tutorial
		///</summary>
		[ImplementPropertyType("graphicTutorial")]
		public IHtmlString GraphicTutorial
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicTutorial"); }
		}

		///<summary>
		/// Learn Category
		///</summary>
		[ImplementPropertyType("learnCategory")]
		public object LearnCategory
		{
			get { return this.GetPropertyValue("learnCategory"); }
		}

		///<summary>
		/// Thumbnail
		///</summary>
		[ImplementPropertyType("thumbnail")]
		public object Thumbnail
		{
			get { return this.GetPropertyValue("thumbnail"); }
		}

		///<summary>
		/// Tutorial Name
		///</summary>
		[ImplementPropertyType("tutorialName")]
		public string TutorialName
		{
			get { return this.GetPropertyValue<string>("tutorialName"); }
		}

		///<summary>
		/// Video Tutorial
		///</summary>
		[ImplementPropertyType("videoTutorial")]
		public string VideoTutorial
		{
			get { return this.GetPropertyValue<string>("videoTutorial"); }
		}
	}

	/// <summary>Tutorial7 Overview</summary>
	[PublishedContentModel("tutorial7Overview")]
	public partial class Tutorial7Overview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "tutorial7Overview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Tutorial7Overview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Tutorial7Overview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}

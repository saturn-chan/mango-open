﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web.Common
{
    /// <summary>
    /// API服务器请求地址配置类
    /// </summary>
    public class ApiServerConfig
    {
        #region 账号中心接口
        /// <summary>
        /// 账号登录接口
        /// </summary>
        public static string Account_Login { get; set; } = "/api/Account/Login";
        public static string Account_Regiser { get; set; } = "/api/Account/Register";
        /// <summary>
        /// 验证码获取接口
        /// (/api/Account/ValidateCode/{email}/{ticket}/{randstr}/{userIP})
        /// </summary>
        public static string Account_AuthorizationValidateCode { get; set; } = "/api/Account/ValidateCode";
        #endregion
        #region 网址导航接口
        /// <summary>
        /// 根据指定条件获取数据
        /// </summary>
        public static string Navigation_GetNavigationByCondition { get; set; } = "/api/Navigation/GetNavigationByCondition";
        /// <summary>
        /// 获取导航数据
        /// </summary>
        public static string Navigation_GetNavigationList { get; set; } = "/api/Navigation/GetNavigationList";
        /// <summary>
        /// 获取导航分类
        /// </summary>
        public static string Navigation_GetNavigationClassify { get; set; } = "/api/Navigation/GetNavigationClassify";
        #endregion
        #region 文档模块接口
        /// <summary>
        /// 根据文档主题ID获取文档主题数据
        /// (/api/Docs/Contents/{themeId})
        /// (/api/Docs/Contents/{themeId}/{docsId})
        /// </summary>
        public static string Docs_DocsContentsApi { get; set; } = "/api/Docs/Contents";
        /// <summary>
        /// 根据文档主题ID获取文档列表(/api/Docs/Theme/document/{id})
        /// </summary>
        public static string Docs_GetDocsListApi { get; set; } = "/api/Docs/Theme/document";
        /// <summary>
        /// 获取文档主题列表(/api/Docs/Theme/{p})
        /// </summary>
        public static string Docs_ThemeApi { get; set; } = "/api/Docs/Theme";
        #endregion
        #region CMS模块接口
        /// <summary>
        /// 获取自定义类型的数据(/api/CMS/Content/customize/{type}/{count})
        /// </summary>
        public static string CMS_ContentsCustomizeApi { get; set; } = "/api/CMS/Contents/customize";
        /// <summary>
        /// CMS内容相关API
        /// (/api/CMS/Contents/{contentsId})
        /// </summary>
        public static string CMS_ContentsApi { get; set; } = "/api/CMS/Contents";
        /// <summary>
        /// CMS频道相关API
        /// (/api/CMS/Channel)
        /// (/api/CMS/Channel/{channelId}/{p})
        /// </summary>
        public static string CMS_ChannelApi { get; set; } = "/api/CMS/Channel";
        #endregion
        #region 公共数据接口
        /// <summary>
        /// 获取网站顶部导航数据接口
        /// </summary>
        public static string WebSite_GetWebSiteNavigation { get; set; } = "/api/WebSite/Base/navigation";
        /// <summary>
        /// 获取网站基本设置数据接口
        /// </summary>
        public static string WebSite_GetWebSiteConfig { get; set; } = "/api/WebSite/Base/config";
        #endregion
    }
}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadRevisionHistoryListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language. Automatically passed through by the browser. You can manually override this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The application name of the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The business line of the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The request protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        /// <summary>
        /// <para>The category code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod_edu_content</para>
        /// </summary>
        [NameInMap("CategoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <para>The channel group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("ChannelGroupCode")]
        [Validation(Required=false)]
        public string ChannelGroupCode { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The source of the operation terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The user cookies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public string PageInfoShrink { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The source page URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The tenant information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// <para>Ignored. No need to pass this parameter. The user type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

    }

}

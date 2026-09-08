// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMetaConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language type of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application project name of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The business line of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemAlerts</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The request protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        /// <summary>
        /// <para>The source of the operation terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h5</para>
        /// </summary>
        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// <para>The user cookies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        /// <summary>
        /// <para>The URL of the source page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/notify,0">https://example.com/notify,0</a></para>
        /// </summary>
        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        /// <summary>
        /// <para>The tenant information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T002</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunPk</para>
        /// </summary>
        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

    }

}

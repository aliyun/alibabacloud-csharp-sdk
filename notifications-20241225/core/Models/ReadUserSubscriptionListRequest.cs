// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadUserSubscriptionListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("CallerProtocol")]
        [Validation(Required=false)]
        public string CallerProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prod_msg</para>
        /// </summary>
        [NameInMap("CategoryGroupCode")]
        [Validation(Required=false)]
        public string CategoryGroupCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("ChannelGroupCode")]
        [Validation(Required=false)]
        public string ChannelGroupCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("ClientSource")]
        [Validation(Required=false)]
        public string ClientSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string Cookies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SrcUrl")]
        [Validation(Required=false)]
        public string SrcUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("UidType")]
        [Validation(Required=false)]
        public string UidType { get; set; }

    }

}

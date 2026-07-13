// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmGlobalAlertShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>zh-CN</c>: Chinese</para>
        /// </description></item>
        /// <item><description><para><c>en-US</c>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A list of alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfigShrink { get; set; }

        /// <summary>
        /// <para>A list of alert notification groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroupShrink { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This token must be unique for each request, contain only ASCII characters, and be no more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}

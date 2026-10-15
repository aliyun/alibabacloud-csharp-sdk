// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppLlmApiKeyForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The idempotency token. This parameter is reserved for future use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the API key usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The custom IP address whitelist defined by the invoker. The system default IP ranges are appended by the backend.</para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public List<string> IpWhiteList { get; set; }

    }

}

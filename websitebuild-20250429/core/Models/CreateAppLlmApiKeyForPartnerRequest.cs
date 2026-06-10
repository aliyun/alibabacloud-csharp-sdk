// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppLlmApiKeyForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>Business ID of the application instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Idempotent token (reserved)</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Description of the API key usage</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Caller-defined IP address whitelist (the backend appends the system default IP segment)</para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public List<string> IpWhiteList { get; set; }

    }

}

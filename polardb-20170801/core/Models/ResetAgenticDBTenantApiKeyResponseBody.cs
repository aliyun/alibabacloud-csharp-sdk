// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ResetAgenticDBTenantApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The plaintext of the new API key, which is returned only in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pagc_key_cGFnYy1icDFh...newSignature22ch</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The API key resource ID, which remains unchanged after the reset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ak-71304e39c7e841a1</para>
        /// </summary>
        [NameInMap("ApiKeyId")]
        [Validation(Required=false)]
        public string ApiKeyId { get; set; }

        /// <summary>
        /// <para>The reset time, which indicates the effective period of the new key.</para>
        /// <para>The time follows the ISO 8601 standard in the UTC time zone. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// <para>The time follows the ISO 8601 standard in the UTC time zone. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2C3D4E5-F6A7-8901-BCDE-F12345678901</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The tenant name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-saas-app</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}

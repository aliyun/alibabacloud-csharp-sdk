// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class RevokeContextDatabaseApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the API key was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-28T17:59:55Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for nightly cron</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A reserved field. This field is currently empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(null)</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The suffix of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33631c</para>
        /// </summary>
        [NameInMap("KeyDisplaySuffix")]
        [Validation(Required=false)]
        public string KeyDisplaySuffix { get; set; }

        /// <summary>
        /// <para>The key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public long? KeyId { get; set; }

        /// <summary>
        /// <para>The prefix of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ctxdb-</para>
        /// </summary>
        [NameInMap("KeyPrefix")]
        [Validation(Required=false)]
        public string KeyPrefix { get; set; }

        /// <summary>
        /// <para>The time when the API key was last used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-01T08:30:12Z</para>
        /// </summary>
        [NameInMap("LastUsedAt")]
        [Validation(Required=false)]
        public string LastUsedAt { get; set; }

        /// <summary>
        /// <para>The name of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-key</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the API key was revoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07T10:15:30Z</para>
        /// </summary>
        [NameInMap("RevokedAt")]
        [Validation(Required=false)]
        public string RevokedAt { get; set; }

        /// <summary>
        /// <para>The status of the API key. After revocation, the value is revoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>revoked</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

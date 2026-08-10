// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateContextDatabaseApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ctxdb-*****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public CreateContextDatabaseApiKeyResponseBodyKey Key { get; set; }
        public class CreateContextDatabaseApiKeyResponseBodyKey : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-28T17:59:55Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(null)</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33631c</para>
            /// </summary>
            [NameInMap("KeyDisplaySuffix")]
            [Validation(Required=false)]
            public string KeyDisplaySuffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public long? KeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ctxdb-</para>
            /// </summary>
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(null)</para>
            /// </summary>
            [NameInMap("LastUsedAt")]
            [Validation(Required=false)]
            public string LastUsedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-key</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(null)</para>
            /// </summary>
            [NameInMap("RevokedAt")]
            [Validation(Required=false)]
            public string RevokedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

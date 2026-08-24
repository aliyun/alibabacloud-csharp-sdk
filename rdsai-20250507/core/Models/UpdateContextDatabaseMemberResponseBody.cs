// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateContextDatabaseMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the member was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-28T17:59:55Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The list of API keys.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<UpdateContextDatabaseMemberResponseBodyKeys> Keys { get; set; }
        public class UpdateContextDatabaseMemberResponseBodyKeys : TeaModel {
            /// <summary>
            /// <para>The time when the member was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-28T17:59:55Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The API key description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data pipeline key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This field is empty.</para>
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
            /// <para>1</para>
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
            /// <para>2026-07-15T08:30:00Z</para>
            /// </summary>
            [NameInMap("LastUsedAt")]
            [Validation(Required=false)]
            public string LastUsedAt { get; set; }

            /// <summary>
            /// <para>The API key name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-key</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(null)</para>
            /// </summary>
            [NameInMap("RevokedAt")]
            [Validation(Required=false)]
            public string RevokedAt { get; set; }

            /// <summary>
            /// <para>The API key status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The member ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mb-cz51tnnp8****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The member name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

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
        /// <para>The member role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The member status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

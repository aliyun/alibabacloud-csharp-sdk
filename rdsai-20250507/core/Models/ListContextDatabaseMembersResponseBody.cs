// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseMembersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>(null)</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ListContextDatabaseMembersResponseBodyMembers> Members { get; set; }
        public class ListContextDatabaseMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-28T17:59:55Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<ListContextDatabaseMembersResponseBodyMembersKeys> Keys { get; set; }
            public class ListContextDatabaseMembersResponseBodyMembersKeys : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-05-28T17:59:55Z</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>data pipeline key</para>
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
                /// <para>2026-07-15T08:30:00Z</para>
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
            /// <para>mb-cz51tnnp8****</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

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
        /// <para>(null)</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

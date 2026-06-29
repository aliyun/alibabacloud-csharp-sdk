// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateConsumerAuthorizationRulesRequest : TeaModel {
        /// <summary>
        /// <para>The consumer authentication rules.</para>
        /// </summary>
        [NameInMap("authorizationRules")]
        [Validation(Required=false)]
        public List<CreateConsumerAuthorizationRulesRequestAuthorizationRules> AuthorizationRules { get; set; }
        public class CreateConsumerAuthorizationRulesRequestAuthorizationRules : TeaModel {
            /// <summary>
            /// <para>The consumer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-******</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The expiration mode. Currently, only LongTerm is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LongTerm</para>
            /// </summary>
            [NameInMap("expireMode")]
            [Validation(Required=false)]
            public string ExpireMode { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174116222x</para>
            /// </summary>
            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The resource identifier, which serves as a unique identifier for non-standard code sources for space reuse.</para>
            /// </summary>
            [NameInMap("resourceIdentifier")]
            [Validation(Required=false)]
            public CreateConsumerAuthorizationRulesRequestAuthorizationRulesResourceIdentifier ResourceIdentifier { get; set; }
            public class CreateConsumerAuthorizationRulesRequestAuthorizationRulesResourceIdentifier : TeaModel {
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-******</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The parent resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-******</para>
                /// </summary>
                [NameInMap("parentResourceId")]
                [Validation(Required=false)]
                public string ParentResourceId { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-li942gy8p03</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource information.</para>
                /// </summary>
                [NameInMap("resources")]
                [Validation(Required=false)]
                public List<string> Resources { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HttpApiRoute</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}

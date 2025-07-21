// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateConsumerAuthorizationRulesRequest : TeaModel {
        /// <summary>
        /// <para>The consumer authentication rules to be created.</para>
        /// </summary>
        [NameInMap("authorizationRules")]
        [Validation(Required=false)]
        public List<CreateConsumerAuthorizationRulesRequestAuthorizationRules> AuthorizationRules { get; set; }
        public class CreateConsumerAuthorizationRulesRequestAuthorizationRules : TeaModel {
            /// <summary>
            /// <para>The consumer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-cu08olem1hkokaut34i0</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The expiration mode. Valid values: LongTerm and ShortTerm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LongTerm</para>
            /// </summary>
            [NameInMap("expireMode")]
            [Validation(Required=false)]
            public string ExpireMode { get; set; }

            /// <summary>
            /// <para>The expiration timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174116222x</para>
            /// </summary>
            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            /// <summary>
            /// <para>The resource identifier, which is provided to non-standard code sources for space reuse.</para>
            /// </summary>
            [NameInMap("resourceIdentifier")]
            [Validation(Required=false)]
            public CreateConsumerAuthorizationRulesRequestAuthorizationRulesResourceIdentifier ResourceIdentifier { get; set; }
            public class CreateConsumerAuthorizationRulesRequestAuthorizationRulesResourceIdentifier : TeaModel {
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-cti17hem1hktoruj98ug</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-li942gy8p03</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

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

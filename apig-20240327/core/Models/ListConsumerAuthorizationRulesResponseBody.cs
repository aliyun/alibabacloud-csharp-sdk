// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerAuthorizationRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerAuthorizationRulesResponseBodyData Data { get; set; }
        public class ListConsumerAuthorizationRulesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListConsumerAuthorizationRulesResponseBodyDataItems> Items { get; set; }
            public class ListConsumerAuthorizationRulesResponseBodyDataItems : TeaModel {
                [NameInMap("apiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ApiInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>car-csgeka5lhtggrjcprok0</para>
                /// </summary>
                [NameInMap("consumerAuthorizationRuleId")]
                [Validation(Required=false)]
                public string ConsumerAuthorizationRuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cs-csheiftlhtgmp0j0hp4g</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                [NameInMap("environmentInfo")]
                [Validation(Required=false)]
                public EnvironmentInfo EnvironmentInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ShortTerm</para>
                /// </summary>
                [NameInMap("expireMode")]
                [Validation(Required=false)]
                public string ExpireMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InEffect</para>
                /// </summary>
                [NameInMap("expireStatus")]
                [Validation(Required=false)]
                public string ExpireStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>172086834548</para>
                /// </summary>
                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                [NameInMap("gatewayInfo")]
                [Validation(Required=false)]
                public GatewayInfo GatewayInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2351944</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HttpApiRoute</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1721116090326</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>294382D9-EE60-5735-A4CD-F2AC2840423D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

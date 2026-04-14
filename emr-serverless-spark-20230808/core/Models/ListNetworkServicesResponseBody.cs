// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListNetworkServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>一次获取的最大记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("networkServices")]
        [Validation(Required=false)]
        public List<ListNetworkServicesResponseBodyNetworkServices> NetworkServices { get; set; }
        public class ListNetworkServicesResponseBodyNetworkServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc_test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ns-d7a1d02045fb****</para>
            /// </summary>
            [NameInMap("networkServiceId")]
            [Validation(Required=false)]
            public string NetworkServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListNetworkServicesResponseBodyNetworkServicesStateChangeReason StateChangeReason { get; set; }
            public class ListNetworkServicesResponseBodyNetworkServicesStateChangeReason : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NetworkService</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>VPC id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vt6r7o1w4tw7j6****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("vswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>下一页TOKEN。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("queues")]
        [Validation(Required=false)]
        public List<ListNetworkServicesResponseBodyQueues> Queues { get; set; }
        public class ListNetworkServicesResponseBodyQueues : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ns-d7a1d02045fb****</para>
            /// </summary>
            [NameInMap("networkServiceId")]
            [Validation(Required=false)]
            public string NetworkServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListNetworkServicesResponseBodyQueuesStateChangeReason StateChangeReason { get; set; }
            public class ListNetworkServicesResponseBodyQueuesStateChangeReason : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NetworkService</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-uf6k2anfa9nzbm4cj****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("vswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18C7775A-7995-128A-A10C-9116EA87****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>记录总数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

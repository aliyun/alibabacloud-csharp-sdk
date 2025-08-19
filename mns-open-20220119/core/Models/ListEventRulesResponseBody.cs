// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventRulesResponseBodyData Data { get; set; }
        public class ListEventRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a88f58d504b8b4c4e0b5e8707e68181f</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListEventRulesResponseBodyDataPageData> PageData { get; set; }
            public class ListEventRulesResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>--</para>
                /// </summary>
                [NameInMap("DeliveryMode")]
                [Validation(Required=false)]
                public string DeliveryMode { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public ListEventRulesResponseBodyDataPageDataEndpoint Endpoint { get; set; }
                public class ListEventRulesResponseBodyDataPageDataEndpoint : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>topic</para>
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-topic</para>
                    /// </summary>
                    [NameInMap("EndpointValue")]
                    [Validation(Required=false)]
                    public string EndpointValue { get; set; }

                }

                [NameInMap("EventTypes")]
                [Validation(Required=false)]
                public List<string> EventTypes { get; set; }

                [NameInMap("MatchRules")]
                [Validation(Required=false)]
                public List<List<EventMatchRule>> MatchRules { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rule-xsXDW</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Subscriptions")]
                [Validation(Required=false)]
                public List<ListEventRulesResponseBodyDataPageDataSubscriptions> Subscriptions { get; set; }
                public class ListEventRulesResponseBodyDataPageDataSubscriptions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>queue</para>
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>wyx-vp-complete-queue</para>
                    /// </summary>
                    [NameInMap("EndpointValue")]
                    [Validation(Required=false)]
                    public string EndpointValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo-topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123E62C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

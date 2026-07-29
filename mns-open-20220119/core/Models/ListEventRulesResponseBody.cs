// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventRulesResponseBodyData Data { get; set; }
        public class ListEventRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is deprecated. The maximum number of entries is based on Total.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated. Paged queries are based on PageNum.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a88f58d504b8b4c4e0b5e8707e68181f</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The data entries.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListEventRulesResponseBodyDataPageData> PageData { get; set; }
            public class ListEventRulesResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--</para>
                /// </summary>
                [NameInMap("DeliveryMode")]
                [Validation(Required=false)]
                public string DeliveryMode { get; set; }

                /// <summary>
                /// <para>The endpoint of the subscription.</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public ListEventRulesResponseBodyDataPageDataEndpoint Endpoint { get; set; }
                public class ListEventRulesResponseBodyDataPageDataEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The endpoint type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>topic</b>: A topic can deliver messages to multiple subscribers. You can add or remove subscribers later.</para>
                    /// </description></item>
                    /// <item><description><para><b>queue</b>: Messages are delivered directly to a queue. This simplifies the delivery path, but you cannot add new subscribers later.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topic</para>
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <para>The actual value of the endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-topic</para>
                    /// </summary>
                    [NameInMap("EndpointValue")]
                    [Validation(Required=false)]
                    public string EndpointValue { get; set; }

                }

                /// <summary>
                /// <para>The list of event types.</para>
                /// </summary>
                [NameInMap("EventTypes")]
                [Validation(Required=false)]
                public List<string> EventTypes { get; set; }

                /// <summary>
                /// <para>The event matching rules. The rules have an OR relationship.</para>
                /// </summary>
                [NameInMap("MatchRules")]
                [Validation(Required=false)]
                public List<List<EventMatchRule>> MatchRules { get; set; }

                /// <summary>
                /// <para>The name of the event notification rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-xsXDW</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The subscribers. A maximum of 20 entries are returned. If there are more subscribers, see <a href="https://help.aliyun.com/document_detail/2804757.html">List Subscriptions</a>.</para>
                /// </summary>
                [NameInMap("Subscriptions")]
                [Validation(Required=false)]
                public List<ListEventRulesResponseBodyDataPageDataSubscriptions> Subscriptions { get; set; }
                public class ListEventRulesResponseBodyDataPageDataSubscriptions : TeaModel {
                    /// <summary>
                    /// <para>The endpoint type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue</para>
                    /// </summary>
                    [NameInMap("EndpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    /// <summary>
                    /// <para>The actual value of the endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wyx-vp-complete-queue</para>
                    /// </summary>
                    [NameInMap("EndpointValue")]
                    [Validation(Required=false)]
                    public string EndpointValue { get; set; }

                }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123E62C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

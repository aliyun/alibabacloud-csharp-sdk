// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEventRuleResponseBody : TeaModel {
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
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventRuleResponseBodyData Data { get; set; }
        public class GetEventRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--</para>
            /// </summary>
            [NameInMap("DeliveryMode")]
            [Validation(Required=false)]
            public string DeliveryMode { get; set; }

            /// <summary>
            /// <para>The endpoint address.</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public GetEventRuleResponseBodyDataEndpoint Endpoint { get; set; }
            public class GetEventRuleResponseBodyDataEndpoint : TeaModel {
                /// <summary>
                /// <para>The endpoint type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>queue</b>: A queue.</para>
                /// </description></item>
                /// <item><description><para><b>topic</b>: A topic.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The value of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>retry-queue</para>
                /// </summary>
                [NameInMap("EndpointValue")]
                [Validation(Required=false)]
                public string EndpointValue { get; set; }

            }

            /// <summary>
            /// <para>A list of event types.</para>
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
            /// <para>event-recorder</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Subscription endpoints.</para>
            /// </summary>
            [NameInMap("Subscriptions")]
            [Validation(Required=false)]
            public List<GetEventRuleResponseBodyDataSubscriptions> Subscriptions { get; set; }
            public class GetEventRuleResponseBodyDataSubscriptions : TeaModel {
                /// <summary>
                /// <para>The endpoint type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>queue</b>: A queue.</para>
                /// </description></item>
                /// <item><description><para><b>topic</b>: A topic.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The value of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>retry-queue</para>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

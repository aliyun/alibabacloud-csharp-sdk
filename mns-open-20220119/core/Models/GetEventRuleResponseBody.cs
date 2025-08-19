// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEventRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventRuleResponseBodyData Data { get; set; }
        public class GetEventRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>--</para>
            /// </summary>
            [NameInMap("DeliveryMode")]
            [Validation(Required=false)]
            public string DeliveryMode { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public GetEventRuleResponseBodyDataEndpoint Endpoint { get; set; }
            public class GetEventRuleResponseBodyDataEndpoint : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>retry-queue</para>
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
            /// <para>event-recorder</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Subscriptions")]
            [Validation(Required=false)]
            public List<GetEventRuleResponseBodyDataSubscriptions> Subscriptions { get; set; }
            public class GetEventRuleResponseBodyDataSubscriptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>retry-queue</para>
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
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIvrTrackingDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIvrTrackingDetailsResponseBodyData Data { get; set; }
        public class ListIvrTrackingDetailsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIvrTrackingDetailsResponseBodyDataList> List { get; set; }
            public class ListIvrTrackingDetailsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>65cp2c15-92ac-4e67-98b2-073a3c541c5d</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A=B;C=D</para>
                /// </summary>
                [NameInMap("ChannelVariables")]
                [Validation(Required=false)]
                public string ChannelVariables { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-10963442671187****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1621910542876</para>
                /// </summary>
                [NameInMap("EnterTime")]
                [Validation(Required=false)]
                public long? EnterTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc99462-1058-47d0-a114-f145ea7444ff</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1621910545105</para>
                /// </summary>
                [NameInMap("LeaveTime")]
                [Validation(Required=false)]
                public long? LeaveTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("NodeExitCode")]
                [Validation(Required=false)]
                public string NodeExitCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e0bc19a3</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeProperties { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PLAY_OR_SAY</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;digits&quot;:&quot;2&quot;}</para>
                /// </summary>
                [NameInMap("NodeVariables")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeVariables { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D2RB671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

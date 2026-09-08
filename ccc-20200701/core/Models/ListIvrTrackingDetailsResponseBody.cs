// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIvrTrackingDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIvrTrackingDetailsResponseBodyData Data { get; set; }
        public class ListIvrTrackingDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of IVR tracking details.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIvrTrackingDetailsResponseBodyDataList> List { get; set; }
            public class ListIvrTrackingDetailsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Callee number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                /// <summary>
                /// <para>The calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                /// <summary>
                /// <para>Voice channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65cp2c15-92ac-4e67-98b2-073a3c541c5d</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>Channel-associated data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A=B;C=D</para>
                /// </summary>
                [NameInMap("ChannelVariables")]
                [Validation(Required=false)]
                public string ChannelVariables { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-10963442671187****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <para>The time when the call entered this IVR edge zone, in Unix timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1621910542876</para>
                /// </summary>
                [NameInMap("EnterTime")]
                [Validation(Required=false)]
                public long? EnterTime { get; set; }

                /// <summary>
                /// <para>Contact flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc99462-1058-47d0-a114-f145ea7444ff</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The name of the contact flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试IVR</para>
                /// </summary>
                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>Time when leaving this IVR node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1621910545105</para>
                /// </summary>
                [NameInMap("LeaveTime")]
                [Validation(Required=false)]
                public long? LeaveTime { get; set; }

                /// <summary>
                /// <para>Status code of the edge zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("NodeExitCode")]
                [Validation(Required=false)]
                public string NodeExitCode { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e0bc19a3</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Edge zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>放音</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>A collection of properties of the edge zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;say&quot;:&quot;您好。&quot;}</para>
                /// </summary>
                [NameInMap("NodeProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeProperties { get; set; }

                /// <summary>
                /// <para>File Type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PLAY_SAY</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>Node variables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;digits&quot;:&quot;2&quot;}</para>
                /// </summary>
                [NameInMap("NodeVariables")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeVariables { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2RB671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

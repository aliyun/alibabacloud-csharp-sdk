// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAiAppDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>appId。</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-xxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-xxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The chart.</para>
        /// </summary>
        [NameInMap("Chart")]
        [Validation(Required=false)]
        public GetAiAppDetailResponseBodyChart Chart { get; set; }
        public class GetAiAppDetailResponseBodyChart : TeaModel {
            /// <summary>
            /// <para>The X value of the coordinate point.</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            /// <summary>
            /// <para>The Y value of the coordinate point.</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetAiAppDetailResponseBodyChartY> Y { get; set; }
            public class GetAiAppDetailResponseBodyChartY : TeaModel {
                /// <summary>
                /// <para>The returned collection.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>score</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The risk events.</para>
        /// </summary>
        [NameInMap("RiskEvents")]
        [Validation(Required=false)]
        public List<GetAiAppDetailResponseBodyRiskEvents> RiskEvents { get; set; }
        public class GetAiAppDetailResponseBodyRiskEvents : TeaModel {
            /// <summary>
            /// <para>The risk event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hit_xxx</para>
            /// </summary>
            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The number of events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public long? EventCount { get; set; }

            /// <summary>
            /// <para>The list of risk event IDs.</para>
            /// </summary>
            [NameInMap("EventIds")]
            [Validation(Required=false)]
            public List<string> EventIds { get; set; }

            /// <summary>
            /// <para>The risk event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unhandled</b>: Not handled.</description></item>
            /// <item><description><b>resolved</b>: Handled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            /// <summary>
            /// <para>The labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<GetAiAppDetailResponseBodyRiskEventsLabels> Labels { get; set; }
            public class GetAiAppDetailResponseBodyRiskEventsLabels : TeaModel {
                /// <summary>
                /// <para>The labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inappropriate_profanity</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("LabelDesc")]
                [Validation(Required=false)]
                public string LabelDesc { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contentModeration</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// <para>UID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>17726*****370735</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}

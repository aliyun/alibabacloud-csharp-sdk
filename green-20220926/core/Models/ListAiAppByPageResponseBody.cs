// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListAiAppByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data on the current page.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListAiAppByPageResponseBodyItems> Items { get; set; }
        public class ListAiAppByPageResponseBodyItems : TeaModel {
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
            /// <para>name-xxx</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("AppStatus")]
            [Validation(Required=false)]
            public string AppStatus { get; set; }

            /// <summary>
            /// <para>The channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The last active time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("LastTraceTime")]
            [Validation(Required=false)]
            public string LastTraceTime { get; set; }

            /// <summary>
            /// <para>The risk events.</para>
            /// </summary>
            [NameInMap("RiskEvents")]
            [Validation(Required=false)]
            public List<ListAiAppByPageResponseBodyItemsRiskEvents> RiskEvents { get; set; }
            public class ListAiAppByPageResponseBodyItemsRiskEvents : TeaModel {
                /// <summary>
                /// <para>The risk event code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hit-xxx</para>
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
                /// <para>The event descriptions.</para>
                /// </summary>
                [NameInMap("EventDescs")]
                [Validation(Required=false)]
                public List<string> EventDescs { get; set; }

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
                /// <para>The list of label items.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<ListAiAppByPageResponseBodyItemsRiskEventsLabels> Labels { get; set; }
                public class ListAiAppByPageResponseBodyItemsRiskEventsLabels : TeaModel {
                    /// <summary>
                    /// <para>The label name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
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
                    /// <para>sensitiveData</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The Tracing Analysis status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("TraceStatus")]
            [Validation(Required=false)]
            public string TraceStatus { get; set; }

            /// <summary>
            /// <para>UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>104813*****2399</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WarningCount")]
            [Validation(Required=false)]
            public int? WarningCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

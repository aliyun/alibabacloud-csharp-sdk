// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListAiAppRiskEventByPageResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListAiAppRiskEventByPageResponseBodyItems> Items { get; set; }
        public class ListAiAppRiskEventByPageResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The unique ID of the AI application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id-xxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the AI application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name-xxx</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The channel source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The end time that indicates when the event was resolved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-10 11:42:31</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event code that identifies the type or category of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aamexg3015</para>
            /// </summary>
            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The detailed description of the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("EventDesc")]
            [Validation(Required=false)]
            public string EventDesc { get; set; }

            /// <summary>
            /// <para>The detailed description of the risk event in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("EventDescEn")]
            [Validation(Required=false)]
            public string EventDescEn { get; set; }

            /// <summary>
            /// <para>The event ID that uniquely identifies a risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-a7gvnv3vid536dfxj</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The brief name that describes the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The time when the event was handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-10 11:42:31</para>
            /// </summary>
            [NameInMap("HandleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            /// <summary>
            /// <para>The label used to mark or categorize the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>label-03</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The detailed description of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("LabelDesc")]
            [Validation(Required=false)]
            public string LabelDesc { get; set; }

            /// <summary>
            /// <para>The risk level that indicates the severity of the event, such as high, medium, or low.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The start time that indicates when the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-21 15:30:19</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The event status that indicates the current processing state of the event, such as pending or resolved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The event type that indicates the category of the risk event, such as security or performance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a320d468c75e987f297484532c16e34d0ab6e7e43f8b73d</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

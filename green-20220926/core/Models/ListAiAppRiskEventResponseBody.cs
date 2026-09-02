// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListAiAppRiskEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAiAppRiskEventResponseBodyData> Data { get; set; }
        public class ListAiAppRiskEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-25 10:22:02</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event code that identifies the type or category of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hit-xxxx</para>
            /// </summary>
            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The event description that provides details about the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc-xxx</para>
            /// </summary>
            [NameInMap("EventDesc")]
            [Validation(Required=false)]
            public string EventDesc { get; set; }

            /// <summary>
            /// <para>The event description in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc-xxx</para>
            /// </summary>
            [NameInMap("EventDescEn")]
            [Validation(Required=false)]
            public string EventDescEn { get; set; }

            /// <summary>
            /// <para>The event ID that uniquely identifies a risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id-xxx</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The event name that briefly describes the risk event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name-xxx</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The label used to mark or categorize the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>porn</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The label description that provides details about the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc-xxx</para>
            /// </summary>
            [NameInMap("LabelDesc")]
            [Validation(Required=false)]
            public string LabelDesc { get; set; }

            /// <summary>
            /// <para>The risk level that indicates the severity of the event, such as high, medium, or low.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The effective period. Format: YYYY-MM-DD HH:mm:ss (default time zone: UTC+08:00).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-22 16:41:15</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The event status that indicates the current processing state of the event, such as pending or resolved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resovled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The event type that indicates the category of the risk event, such as security or performance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sensitiveData</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID assigned by the backend that uniquely identifies a request. This ID can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

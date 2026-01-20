// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ThirdswAicall20251127.Models
{
    public class ReadOutboundTaskCallListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ReadOutboundTaskCallListResponseBodyRecords> Records { get; set; }
        public class ReadOutboundTaskCallListResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-23 19:38:44</para>
            /// </summary>
            [NameInMap("CallEndTime")]
            [Validation(Required=false)]
            public string CallEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>call_123456</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-23 19:34:12</para>
            /// </summary>
            [NameInMap("CallStartTime")]
            [Validation(Required=false)]
            public string CallStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>客户对双十一活动很感兴趣</para>
            /// </summary>
            [NameInMap("CallSummary")]
            [Validation(Required=false)]
            public string CallSummary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张先生</para>
            /// </summary>
            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131****9908</para>
            /// </summary>
            [NameInMap("CustomerPhone")]
            [Validation(Required=false)]
            public string CustomerPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("DialogueList")]
            [Validation(Required=false)]
            public List<ReadOutboundTaskCallListResponseBodyRecordsDialogueList> DialogueList { get; set; }
            public class ReadOutboundTaskCallListResponseBodyRecordsDialogueList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public int? BeginTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>您好，请问有什么可以帮助您？</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已接通</para>
            /// </summary>
            [NameInMap("DisplayStatus")]
            [Validation(Required=false)]
            public string DisplayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>272</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4m32s</para>
            /// </summary>
            [NameInMap("DurationText")]
            [Validation(Required=false)]
            public string DurationText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;123&quot;:&quot;122&quot;}</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-23 19:34:12</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-23 19:34:12</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance_001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;有意向&quot;, &quot;高净值&quot;]</para>
            /// </summary>
            [NameInMap("LabelTags")]
            [Validation(Required=false)]
            public List<string> LabelTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RecordDetailReady")]
            [Validation(Required=false)]
            public bool? RecordDetailReady { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx.com/record.mp3">https://xxx.com/record.mp3</a></para>
            /// </summary>
            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tenant_001</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xiaomei</para>
            /// </summary>
            [NameInMap("TtsVoiceCode")]
            [Validation(Required=false)]
            public string TtsVoiceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小美(声音甜美)</para>
            /// </summary>
            [NameInMap("TtsVoiceDesc")]
            [Validation(Required=false)]
            public string TtsVoiceDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202BFA44-28D8-571E-B992-BA70F2E92FB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743387963</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F47D4976-FC5A-5687-A890-B7923D3B429B</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VoiceModerationResultResponseBodyData Data { get; set; }
        public class VoiceModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the moderated object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The unique ID of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveId</para>
            /// </summary>
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }

            /// <summary>
            /// <para>Risk Level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The moderation results of audio segments.</para>
            /// </summary>
            [NameInMap("SliceDetails")]
            [Validation(Required=false)]
            public List<VoiceModerationResultResponseBodyDataSliceDetails> SliceDetails { get; set; }
            public class VoiceModerationResultResponseBodyDataSliceDetails : TeaModel {
                /// <summary>
                /// <para>The end time of the audio segment in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The end timestamp of the segment. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678854649720</para>
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// <para>Extended fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;riskTips\&quot;:\&quot;sexuality_Suggestive\&quot;,\&quot;riskWords\&quot;:\&quot;pxxxxy\&quot;}</para>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// <para>The details of the labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sexual_sounds</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>Reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OriginAlgoResult")]
                [Validation(Required=false)]
                public Dictionary<string, object> OriginAlgoResult { get; set; }

                /// <summary>
                /// <para>Risk Level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The details of the risky content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sexuality_Suggestive</para>
                /// </summary>
                [NameInMap("RiskTips")]
                [Validation(Required=false)]
                public string RiskTips { get; set; }

                /// <summary>
                /// <para>The term hit by the risky content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAA,BBB,CCC</para>
                /// </summary>
                [NameInMap("RiskWords")]
                [Validation(Required=false)]
                public string RiskWords { get; set; }

                /// <summary>
                /// <para>The risk score. Default range: 0 to 99.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87.01</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>The start time of the audio segment in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The start timestamp of the segment. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678854649720</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <para>The text converted from the audio segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Disgusting</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The temporary URL of the audio segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyundoc.com">https://aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kw24ihd0WGkdi5nniVZM@qOj-1x5Ibb</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The URL of the moderated content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyundoc.com">https://aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2881AD4F-638B-52A3-BA20-F74C5B1CEAE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

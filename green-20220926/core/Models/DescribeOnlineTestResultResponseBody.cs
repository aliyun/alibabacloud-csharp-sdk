// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DescribeOnlineTestResultResponseBody : TeaModel {
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public DescribeOnlineTestResultResponseBodyAudioData AudioData { get; set; }
        public class DescribeOnlineTestResultResponseBodyAudioData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1724378510396</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        [NameInMap("FrameData")]
        [Validation(Required=false)]
        public DescribeOnlineTestResultResponseBodyFrameData FrameData { get; set; }
        public class DescribeOnlineTestResultResponseBodyFrameData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1725761005419</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxxxxx.com/data/data.mp4">https://xxxxxxxxx.com/data/data.mp4</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1725761005419</para>
        /// </summary>
        [NameInMap("ModerationTime")]
        [Validation(Required=false)]
        public string ModerationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VideoModeration</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("SummaryList")]
        [Validation(Required=false)]
        public List<DescribeOnlineTestResultResponseBodySummaryList> SummaryList { get; set; }
        public class DescribeOnlineTestResultResponseBodySummaryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("RiskLevelSummary")]
            [Validation(Required=false)]
            public Dictionary<string, long?> RiskLevelSummary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceCount")]
            [Validation(Required=false)]
            public int? SliceCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx-xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxx.com/data/data.png">https://xxxxxxxxx.com/data/data.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}

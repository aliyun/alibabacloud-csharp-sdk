// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DescribeOnlineTestResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The audio data.</para>
        /// </summary>
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public DescribeOnlineTestResultResponseBodyAudioData AudioData { get; set; }
        public class DescribeOnlineTestResultResponseBodyAudioData : TeaModel {
            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724378510396</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The video frame data.</para>
        /// </summary>
        [NameInMap("FrameData")]
        [Validation(Required=false)]
        public DescribeOnlineTestResultResponseBodyFrameData FrameData { get; set; }
        public class DescribeOnlineTestResultResponseBodyFrameData : TeaModel {
            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725761005419</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>The detection URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxxxxx.com/data/data.mp4">https://xxxxxxxxx.com/data/data.mp4</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The detection time, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725761005419</para>
        /// </summary>
        [NameInMap("ModerationTime")]
        [Validation(Required=false)]
        public string ModerationTime { get; set; }

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
        /// <para>The risk level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The list of detection results.</para>
        /// </summary>
        [NameInMap("SummaryList")]
        [Validation(Required=false)]
        public List<DescribeOnlineTestResultResponseBodySummaryList> SummaryList { get; set; }
        public class DescribeOnlineTestResultResponseBodySummaryList : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

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
            /// <para>The risk level summary.</para>
            /// </summary>
            [NameInMap("RiskLevelSummary")]
            [Validation(Required=false)]
            public Dictionary<string, long?> RiskLevelSummary { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SliceCount")]
            [Validation(Required=false)]
            public int? SliceCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx-xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The detection status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The detection URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxxx.com/data/data.png">https://xxxxxxxxx.com/data/data.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}

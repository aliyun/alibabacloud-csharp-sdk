// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetVideoModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceNotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T10:20:56.87Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05C-1XBQvsG2Tn5kBx2dUWo43******</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The error message of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource TaskId is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The result of the image compliance detection task.</para>
        /// </summary>
        [NameInMap("ModerationResult")]
        [Validation(Required=false)]
        public GetVideoModerationResultResponseBodyModerationResult ModerationResult { get; set; }
        public class GetVideoModerationResultResponseBodyModerationResult : TeaModel {
            /// <summary>
            /// <para>The category list.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The information about video and motion detection frames.</para>
            /// </summary>
            [NameInMap("Frames")]
            [Validation(Required=false)]
            public GetVideoModerationResultResponseBodyModerationResultFrames Frames { get; set; }
            public class GetVideoModerationResultResponseBodyModerationResultFrames : TeaModel {
                /// <summary>
                /// <para>The information about violated frames.</para>
                /// </summary>
                [NameInMap("BlockFrames")]
                [Validation(Required=false)]
                public List<GetVideoModerationResultResponseBodyModerationResultFramesBlockFrames> BlockFrames { get; set; }
                public class GetVideoModerationResultResponseBodyModerationResultFramesBlockFrames : TeaModel {
                    /// <summary>
                    /// <para>The label of the violation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;teat&quot;:&quot;val&quot;}</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The offset of the frame.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public int? Offset { get; set; }

                    /// <summary>
                    /// <para>The confidence level of the violation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public double? Rate { get; set; }

                }

                /// <summary>
                /// <para>The total number of detected frames.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The recommended operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pass: The image has passed the check. No action is required.</description></item>
            /// <item><description>review: The image contains suspected violations and requires human review.</description></item>
            /// <item><description>block: The image contains violations. Further actions, such as deleting or blocking the image, are recommended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The OSS URI of the file. The URI follows the oss://${bucketname}/${objectname} format. bucketname indicates the name of an OSS bucket that is in the same region as the current project, and objectname is the file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoModeration-d0f0df1d-531d-4ab4-b353-e7f475******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T10:20:41.432Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The task is running.</description></item>
        /// <item><description>Succeeded: The task is successful.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoModeration-d0f0df1d-531d-4ab4-b353-e7f4750******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoModeration</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;id&quot;: &quot;test-id&quot;,
        ///       &quot;name&quot;: &quot;test-name&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

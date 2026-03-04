// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputDetail : TeaModel {
        /// <summary>
        /// <para>The error code for a failed task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter.ResourceContentBad</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time the output task was created, in UTC format (<em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T06:06:58Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time the output task finished, in UTC format (<em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T13:01:07Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The reason for a task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource operated InputFile is bad</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P-mp4</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The detailed output results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public MediaConvertOutputDetailResult Result { get; set; }
        public class MediaConvertOutputDetailResult : TeaModel {
            /// <summary>
            /// <para>The metadata of the audio and video streams.</para>
            /// </summary>
            [NameInMap("OutFileMeta")]
            [Validation(Required=false)]
            public MediaConvertOutputDetailFileMeta OutFileMeta { get; set; }

            /// <summary>
            /// <para>Details about the generated output file.</para>
            /// </summary>
            [NameInMap("OutputFile")]
            [Validation(Required=false)]
            public MediaConvertOutputDetailResultOutputFile OutputFile { get; set; }
            public class MediaConvertOutputDetailResultOutputFile : TeaModel {
                /// <summary>
                /// <para>The value depends on the Type field:</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, the value is the URL of the output file. The following formats are supported: oss://... and https://...</description></item>
                /// <item><description>If Type is set to Media, the value is the ID of the media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the output file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>If Type is set to Media, this field provides the actual storage URL of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init: Initializing the task.</description></item>
        /// <item><description>Scheduled: The task is scheduled for processing.</description></item>
        /// <item><description>Success: The task is completed.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// <item><description>Skipped: The task was skipped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>4215e042b3966ca5441e</b></b></b></para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

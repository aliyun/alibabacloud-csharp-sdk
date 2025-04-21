// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetBatchMediaProducingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the quick video production job.</para>
        /// </summary>
        [NameInMap("EditingBatchJob")]
        [Validation(Required=false)]
        public GetBatchMediaProducingJobResponseBodyEditingBatchJob EditingBatchJob { get; set; }
        public class GetBatchMediaProducingJobResponseBodyEditingBatchJob : TeaModel {
            /// <summary>
            /// <para>The time when the job was complete.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:57:07Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:47:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The editing configurations. For more information, see <a href="~~2692547#1be9bba03b7qu~~">EditingConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaConfig&quot;: {
            ///       &quot;Volume&quot;: 0
            ///   },
            ///   &quot;SpeechConfig&quot;: {
            ///       &quot;Volume&quot;: 1
            ///   },
            ///  &quot;BackgroundMusicConfig&quot;: {
            ///       &quot;Volume&quot;: 0.3
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            /// <summary>
            /// <para>The extended information. This parameter contains the following fields:</para>
            /// <para>ErrorCode: the error code of the main job.</para>
            /// <para>ErrorMessage: the error message of the main job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ErrorCode&quot;: &quot;InvalidMaterial.NotFound&quot;,
            ///     &quot;ErrorMessage&quot;: &quot;The specified clips id not found:[\&quot;<b><b>30d0b5e871eebb2ff7f6c75a</b></b>\&quot;]&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <para>The input configurations. For more information, see <a href="~~2692547#2faed1559549n~~">InputConfig</a>.</para>
            /// </summary>
            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>b6b2750d4308892ac3330238</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:57:07Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The output configurations. For more information, see <a href="~~2692547#447b928fcbuoa~~">OutputConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaURL&quot;: &quot;<a href="http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_%7Bindex%7D.mp4">http://xxx.oss-cn-shanghai.aliyuncs.com/xxx_{index}.mp4</a>&quot;,
            ///   &quot;Count&quot;: 20,
            ///   &quot;MaxDuration&quot;: 15,
            ///   &quot;Width&quot;: 1080,
            ///   &quot;Height&quot;: 1920,
            ///   &quot;Video&quot;: {&quot;Crf&quot;: 27}
            /// }</para>
            /// </summary>
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }

            /// <summary>
            /// <para>The job state. Valid values:</para>
            /// <para>Init: The job is initialized.</para>
            /// <para>Processing: The job is in progress.</para>
            /// <para>Finished: The job is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The quick video production subjobs.</para>
            /// </summary>
            [NameInMap("SubJobList")]
            [Validation(Required=false)]
            public List<GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList> SubJobList { get; set; }
            public class GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The error code that is returned if the subjob failed. This parameter is not returned if the subjob is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidMaterial.NotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message that is returned if the subjob failed. This parameter is not returned if the subjob is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified clips id not found:[&quot;<b><b>30d0b5e871eebb2ff7f6c75a</b></b>&quot;]</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The subjob ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>8e81933d44e3ae69e2f81485</b></b></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The ID of the output media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>1470b11171ee9d19e7e6c66a</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The URL of the output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http:/xxx.oss-cn-shanghai.aliyuncs.com/xxx_0.mp4</para>
                /// </summary>
                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                /// <summary>
                /// <para>The ID of the online editing project.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>7cc47fe04eaa81bd853acb6a</b></b></para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The subjob state. Valid values:</para>
                /// <para>Init: The subjob is initialized.</para>
                /// <para>Processing: The subjob is in progress.</para>
                /// <para>Success: The subjob is successful.</para>
                /// <para>Failed: The subjob failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The user-defined data, including the business and callback configurations. For more information, see <a href="https://help.aliyun.com/document_detail/357745.html">UserData</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

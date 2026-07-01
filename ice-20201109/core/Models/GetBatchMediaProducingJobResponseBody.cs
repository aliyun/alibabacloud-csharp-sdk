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
            /// <para>Additional input.</para>
            /// <list type="bullet">
            /// <item><description><para>When JobType is Smart_Mix_Timeline_Organize or Screen_Media_Highlights_Timeline_Organize, the additional input is the material selection result.</para>
            /// </description></item>
            /// <item><description><para>When JobType is Scene_Batch_Editing, the additional input is a list of video editing project IDs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;<b><b>7cc47fe04eaa81bd853acb6a</b></b>&quot;, &quot;<b><b>04eaa7cc47fe81bd853acb6a</b></b>&quot;]</para>
            /// </summary>
            [NameInMap("ExtendInput")]
            [Validation(Required=false)]
            public string ExtendInput { get; set; }

            /// <summary>
            /// <para>Additional outputs.</para>
            /// <list type="bullet">
            /// <item><description>When JobType is Smart_Mix_Media_Select or Screen_Media_Highlights_Media_Select, material selection results are additionally returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;textMatchMediaOutputList&quot;: [{
            /// &quot;textMatchMediaSentenceOutputList&quot;: [{
            /// &quot;duration&quot;: 3.366667,
            /// &quot;matchClipList&quot;: [{
            /// &quot;clipId&quot;: &quot;null-2&quot;,
            /// &quot;endTime&quot;: 11.16,
            /// &quot;mediaId&quot;: &quot;<b><b>a0900f5071efbf1ce7e6c66a</b></b>&quot;,
            /// &quot;score&quot;: -0.253,
            /// &quot;startTime&quot;: 8.04
            /// }],
            /// &quot;text&quot;: &quot;A new Freshippo store just opened at the nearby mall.&quot;,
            /// &quot;textId&quot;: &quot;0&quot;
            /// },
            /// {
            /// &quot;duration&quot;: 1.566667,
            /// &quot;matchClipList&quot;: [{
            /// &quot;clipId&quot;: &quot;null-1&quot;,
            /// &quot;endTime&quot;: 1.54,
            /// &quot;mediaId&quot;: &quot;<b><b>a0900f5071efbf1ce7e6c66a</b></b>&quot;,
            /// &quot;score&quot;: -0.2326,
            /// &quot;startTime&quot;: 0
            /// }],
            /// &quot;text&quot;: &quot;today Yesfirst day of opening&quot;,
            /// &quot;textId&quot;: &quot;0&quot;
            /// }
            /// ]
            /// }]
            /// }</para>
            /// </summary>
            [NameInMap("ExtendOutput")]
            [Validation(Required=false)]
            public string ExtendOutput { get; set; }

            /// <summary>
            /// <para>The input configurations. For more information, see <a href="~~2692547#2faed1559549n~~">InputConfig</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;MediaGroupArray&quot;: [{
            ///       &quot;GroupName&quot;: &quot;MediaGroup1&quot;,
            ///       &quot;MediaArray&quot;: [
            ///         &quot;<b><b>9d46c886b45481030f6e</b></b>&quot;,
            ///         &quot;<b><b>6c886b4549d481030f6e</b></b>&quot; ]
            ///     }, {
            ///       &quot;GroupName&quot;: &quot;MediaGroup2&quot;,
            ///       &quot;MediaArray&quot;: [
            ///         &quot;<b><b>d46c886810b454930f6e</b></b>&quot;,
            ///         &quot;<b><b>4549d886810b46c30f6e</b></b>&quot; ]
            ///   }],
            ///   &quot;TitleArray&quot;: [
            ///       &quot;回龙观盒马鲜生开业啦&quot;,
            ///       &quot;盒马鲜生开业啦&quot; ],
            ///   &quot;SpeechTextArray&quot;: [
            ///       &quot;附近的商场新开了一家盒马鲜生，今天是第一天开业&quot;
            ///       &quot;商场里的人不少，零食、酒水都比较便宜大家也快来看看呀&quot; ]
            /// }</para>
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

            /// <summary>
            /// <para>Task Type:</para>
            /// <list type="bullet">
            /// <item><description><para>Script (Script-based automated video editing)</para>
            /// </description></item>
            /// <item><description><para>Smart_Mix (Intelligent text-to-media matching for video editing)</para>
            /// </description></item>
            /// <item><description><para>Sports_Highlights (Sporting event highlights compilation)</para>
            /// </description></item>
            /// <item><description><para>Screen_Media_Highlights (High-energy multi-media mashup editing)</para>
            /// </description></item>
            /// <item><description><para>Smart_Mix_Media_Select (Intelligent matching – Material selection)</para>
            /// </description></item>
            /// <item><description><para>Smart_Mix_Timeline_Organize (Intelligent matching – Timeline orchestration)</para>
            /// </description></item>
            /// <item><description><para>Screen_Media_Highlights_Media_Select (High-energy mashup – Material selection)</para>
            /// </description></item>
            /// <item><description><para>Screen_Media_Highlights_Timeline_Organize (High-energy mashup – Timeline orchestration)</para>
            /// </description></item>
            /// <item><description><para>Scene_Batch_Editing (Batch synthesis across multiple timelines)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Script</para>
            /// </summary>
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
                /// <summary>
                /// <para>The duration of the output video, in seconds (s).</para>
                /// 
                /// <b>Example:</b>
                /// <para>24.5</para>
                /// </summary>
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

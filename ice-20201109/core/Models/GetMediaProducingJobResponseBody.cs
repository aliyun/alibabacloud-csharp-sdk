// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaProducingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media producing job.</para>
        /// </summary>
        [NameInMap("MediaProducingJob")]
        [Validation(Required=false)]
        public GetMediaProducingJobResponseBodyMediaProducingJob MediaProducingJob { get; set; }
        public class GetMediaProducingJobResponseBodyMediaProducingJob : TeaModel {
            /// <summary>
            /// <para>The clip parameters of the template used for the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoArray&quot;:[&quot;<b><b>05512043f49f697f7425</b></b>&quot;,&quot;<b><b>05512043f49f697f7425</b></b>&quot;,&quot;<b><b>05512043f49f697f7425</b></b>&quot;]}</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The error code of the media producing job. &gt;Notice: This parameter is returned only if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExceededMaximumValue</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time in UTC when the media producing job was completed, formatted as <c>YYYY-MM-DD\\&quot;T\\&quot;hh:mm:ss\\&quot;Z\\&quot;</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:52Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time in UTC when the media producing job was created, formatted as <c>YYYY-MM-DD\\&quot;T\\&quot;hh:mm:ss\\&quot;Z\\&quot;</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The duration of the output media. &gt;Notice: This parameter is returned only if the job is successful and the output is an audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.500000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the output media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>0cc6ba49eab379332c5b</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The URL of the output media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4</a></para>
            /// </summary>
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }

            /// <summary>
            /// <para>The error message of the media producing job.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is returned only if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified &quot;Width_Height&quot; has exceeded maximum value.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time in UTC when the media producing job was last modified, formatted as <c>YYYY-MM-DD\\&quot;T\\&quot;hh:mm:ss\\&quot;Z\\&quot;</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:49Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The progress of the job. Valid values: 0 to 100.</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The status of the media producing job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Init</c> (Initialized)</para>
            /// </description></item>
            /// <item><description><para><c>Queuing</c> (In queue)</para>
            /// </description></item>
            /// <item><description><para><c>Processing</c> (In progress)</para>
            /// </description></item>
            /// <item><description><para><c>Success</c> (Successful)</para>
            /// </description></item>
            /// <item><description><para><c>Failed</c> (Failed)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>If the job is a subtask of a batch smart one-click video creation task, this parameter contains the subtask\&quot;s materials, such as the title and speech script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Title&quot;: &quot;标题&quot;, &quot;SpeechText&quot;: &quot;批量智能一键成片口播文案&quot;}</para>
            /// </summary>
            [NameInMap("SubJobMaterials")]
            [Validation(Required=false)]
            public string SubJobMaterials { get; set; }

            /// <summary>
            /// <para>The ID of the template used for the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>6e76134d739cc3e85d3e</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The timeline of the media producing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;},{&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;}]}]}</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }

            /// <summary>
            /// <para>The user data, in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22,%22Key%22:%22Valuexxx%22%7D">http://xx.xx.xxx&quot;,&quot;Key&quot;:&quot;Valuexxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The ID of the media asset in VOD (Video on Demand). This ID is returned if the job\&quot;s output is stored in VOD.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>332c5b0cc6ba49eab379</b></b></para>
            /// </summary>
            [NameInMap("VodMediaId")]
            [Validation(Required=false)]
            public string VodMediaId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>83B7-7F87-4792-BFE9-63CD2137</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

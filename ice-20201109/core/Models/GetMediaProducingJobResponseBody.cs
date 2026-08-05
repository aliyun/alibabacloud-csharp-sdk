// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaProducingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The media producing job information.</para>
        /// </summary>
        [NameInMap("MediaProducingJob")]
        [Validation(Required=false)]
        public GetMediaProducingJobResponseBodyMediaProducingJob MediaProducingJob { get; set; }
        public class GetMediaProducingJobResponseBodyMediaProducingJob : TeaModel {
            /// <summary>
            /// <para>The template parameters of the media producing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;VideoArray&quot;:[&quot;<b><b>05512043f49f697f7425</b></b>&quot;,&quot;<b><b>05512043f49f697f7425</b></b>&quot;,&quot;<b><b>05512043f49f697f7425</b></b>&quot;]}</para>
            /// </summary>
            [NameInMap("ClipsParam")]
            [Validation(Required=false)]
            public string ClipsParam { get; set; }

            /// <summary>
            /// <para>The error code of the media producing job.</para>
            /// <remarks>
            /// <para>Notice: Check this field when the job fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ExceededMaximumValue</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the media producing job was completed, in UTC.</para>
            /// <para>Format: &quot;YYYY-MM-DD\&quot;T\&quot;hh:mm:ss\&quot;Z\&quot;&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:52Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the media producing job was created, in UTC.</para>
            /// <para>Format: &quot;YYYY-MM-DD\&quot;T\&quot;hh:mm:ss\&quot;Z\&quot;&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:40Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The duration of the output media asset.</para>
            /// <remarks>
            /// <para>Notice: This field has a value only when the producing job succeeds and the output media asset type is audio or video.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30.500000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the media producing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The resource ID of the output media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>0cc6ba49eab379332c5b</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The resource file URL of the output media asset.</para>
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
            /// <para>Notice: Check this field when the job fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>The specified &quot;Width_Height&quot; has exceeded maximum value.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the media producing job was last modified, in UTC.</para>
            /// <para>Format: &quot;YYYY-MM-DD\&quot;T\&quot;hh:mm:ss\&quot;Z\&quot;&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23T13:33:49Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The ID of the cloud editing project.</para>
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
            /// <item><description>Init: init state.</description></item>
            /// <item><description>Queuing: queuing.</description></item>
            /// <item><description>Processing: processing.</description></item>
            /// <item><description>Success: succeeded.</description></item>
            /// <item><description>Failed: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>If this media producing job is a subtask of a batch intelligent one-click video production job, this field returns the material information used by the subtask, such as the narration text and title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Title&quot;: &quot;Title&quot;, &quot;SpeechText&quot;: &quot;Narration text for batch intelligent one-click video production&quot;}</para>
            /// </summary>
            [NameInMap("SubJobMaterials")]
            [Validation(Required=false)]
            public string SubJobMaterials { get; set; }

            /// <summary>
            /// <para>The template ID of the media producing job.</para>
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
            /// <para>The custom settings in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22,%22Key%22:%22Valuexxx%22%7D">http://xx.xx.xxx&quot;,&quot;Key&quot;:&quot;Valuexxx&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>If the output of the media producing job is delivered to ApsaraVideo VOD, the output is registered as a VOD media asset. The vodMediaId is the media asset ID in VOD.</para>
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

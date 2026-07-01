// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConvertJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The media transcoding job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetMediaConvertJobResponseBodyJob Job { get; set; }
        public class GetMediaConvertJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The idempotency parameter for the job creation request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>780018cb-55ba-466d-8acc-946c0c319a0e</para>
            /// </summary>
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <para>The error code if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.ResourceContentBad</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The job configuration.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMediaConvertJobResponseBodyJobConfig Config { get; set; }
            public class GetMediaConvertJobResponseBodyJobConfig : TeaModel {
                /// <summary>
                /// <para>The job inputs.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<MediaConvertInput> Inputs { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-1-20241205-102045</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The job output group configurations.</para>
                /// </summary>
                [NameInMap("OutputGroups")]
                [Validation(Required=false)]
                public List<MediaConvertOutputGroup> OutputGroups { get; set; }

                /// <summary>
                /// <para>The job output configurations.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public List<MediaConvertOutput> Outputs { get; set; }

            }

            /// <summary>
            /// <para>The time when the job was created, in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-07T13:01:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job finished, in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-07T13:01:07Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The job ID. This is a 32-character string.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>4579b5e748b99a27f6d6</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message detailing the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated InputFile is bad</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution results of the outputs specified in the job configuration.</para>
            /// </summary>
            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputDetail> OutputDetails { get; set; }

            /// <summary>
            /// <para>The execution results of the output groups specified in the job configuration.</para>
            /// </summary>
            [NameInMap("OutputGroupDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputGroupDetail> OutputGroupDetails { get; set; }

            /// <summary>
            /// <para>The completion percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83500cb2a3b94fabb0956e38d64bd16d</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The ID of the job creation request.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The job state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Inited: The job is initialized.</para>
            /// </description></item>
            /// <item><description><para>Running: The job is in progress.</para>
            /// </description></item>
            /// <item><description><para>Complete: The job finished successfully.</para>
            /// </description></item>
            /// <item><description><para>Error: The job failed.</para>
            /// </description></item>
            /// <item><description><para>Cancelled: The job was cancelled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;videoId&quot;:&quot;ddd333&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BAEA8E8-1C16-5CD3-AC50-CCBA81A53402</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

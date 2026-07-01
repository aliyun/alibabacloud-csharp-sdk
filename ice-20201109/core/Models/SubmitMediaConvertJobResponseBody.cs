// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaConvertJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The media transcoding job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public SubmitMediaConvertJobResponseBodyJob Job { get; set; }
        public class SubmitMediaConvertJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The idempotency token for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FB7F25E9-AD9B-1603-8AF6-F1E42DF2E706</para>
            /// </summary>
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <para>The error code returned if the job fails.</para>
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
            public SubmitMediaConvertJobResponseBodyJobConfig Config { get; set; }
            public class SubmitMediaConvertJobResponseBodyJobConfig : TeaModel {
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
                /// <para>Name</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The output group configurations.</para>
                /// </summary>
                [NameInMap("OutputGroups")]
                [Validation(Required=false)]
                public List<MediaConvertOutputGroup> OutputGroups { get; set; }

                /// <summary>
                /// <para>The output configurations.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public List<MediaConvertOutput> Outputs { get; set; }

            }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message returned if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated InputFile is bad</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The output details.</para>
            /// </summary>
            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputDetail> OutputDetails { get; set; }

            /// <summary>
            /// <para>The output group details.</para>
            /// </summary>
            [NameInMap("OutputGroupDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputGroupDetail> OutputGroupDetails { get; set; }

            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em><b>48a4edf410b908aecd91fc3b</b></em></para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A2129C9F-CE95-58B5-B8C1-07758FF6C86F</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Inited: The job has been initialized.</para>
            /// </description></item>
            /// <item><description><para>Running: The job is running.</para>
            /// </description></item>
            /// <item><description><para>Success: The job has completed successfully.</para>
            /// </description></item>
            /// <item><description><para>Failed: The job has failed.</para>
            /// </description></item>
            /// <item><description><para>Canceled: The job has been canceled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;videoId&quot;:&quot;abcd&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

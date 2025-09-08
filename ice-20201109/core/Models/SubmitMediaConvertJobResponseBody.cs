// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaConvertJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The transcoding task.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public SubmitMediaConvertJobResponseBodyJob Job { get; set; }
        public class SubmitMediaConvertJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The idempotency key of the request for creating the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FB7F25E9-AD9B-1603-8AF6-F1E42DF2E706</para>
            /// </summary>
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <para>The error code returned when the transcoding task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The configurations of the transcoding task.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public SubmitMediaConvertJobResponseBodyJobConfig Config { get; set; }
            public class SubmitMediaConvertJobResponseBodyJobConfig : TeaModel {
                /// <summary>
                /// <para>The inputs of the transcoding task.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<MediaConvertInput> Inputs { get; set; }

                /// <summary>
                /// <para>The name of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>insx6-1310</para>
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
            /// <para>The ID of the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message returned when the transcoding task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The details of the transcoded outputs.</para>
            /// </summary>
            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputDetail> OutputDetails { get; set; }

            /// <summary>
            /// <para>The details of the output groups.</para>
            /// </summary>
            [NameInMap("OutputGroupDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputGroupDetail> OutputGroupDetails { get; set; }

            /// <summary>
            /// <para>The ID of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3780049</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A2129C9F-CE95-58B5-B8C1-07758FF6C86F</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The status of the transcoding task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Inited: The task is initialized.</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Complete</description></item>
            /// <item><description>Error</description></item>
            /// <item><description>Cancelled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Inited</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

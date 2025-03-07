// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConvertJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The transcoding task.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetMediaConvertJobResponseBodyJob Job { get; set; }
        public class GetMediaConvertJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The idempotency key of the request for creating the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>780018cb-55ba-466d-8acc-946c0c319a0e</para>
            /// </summary>
            [NameInMap("ClientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <para>The error code returned when the transcoding task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.ResourceContentBad</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The configurations of the transcoding task.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMediaConvertJobResponseBodyJobConfig Config { get; set; }
            public class GetMediaConvertJobResponseBodyJobConfig : TeaModel {
                /// <summary>
                /// <para>The inputs of the transcoding task.</para>
                /// </summary>
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<MediaConvertInput> Inputs { get; set; }

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
            /// <para>The ID of the transcoding task, which is a 32-bit string.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>4579b5e748b99a27f6d6</b></b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message returned when the transcoding task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated InputFile is bad</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The details of the transcoded outputs, each corresponding to an output configuration.</para>
            /// </summary>
            [NameInMap("OutputDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputDetail> OutputDetails { get; set; }

            /// <summary>
            /// <para>The details of the output groups, each corresponding to an output group configuration.</para>
            /// </summary>
            [NameInMap("OutputGroupDetails")]
            [Validation(Required=false)]
            public List<MediaConvertOutputGroupDetail> OutputGroupDetails { get; set; }

            /// <summary>
            /// <para>The ID of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83500cb2a3b94fabb0956e38d64bd16d</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The ID of the request for creating the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The status of the transcoding task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Inited: The task is initialized.</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Success</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Cancelled</description></item>
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
            /// <para>{&quot;videoId&quot;:&quot;ddd333&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BAEA8E8-1C16-5CD3-AC50-CCBA81A53402</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

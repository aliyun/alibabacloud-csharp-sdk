// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobWithoutDetail : TeaModel {
        /// <summary>
        /// <para>The idempotency token provided during the task creation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The error code for a failed task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter.ResourceNotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public MediaConvertJobWithoutDetailConfig Config { get; set; }
        public class MediaConvertJobWithoutDetailConfig : TeaModel {
            /// <summary>
            /// <para>The input files for the task.</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public List<MediaConvertInput> Inputs { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The output groups.</para>
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
        /// <para>The time the task was created, in UTC format (<em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T13:01:07Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time the task finished processing, in UTC format (<em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-07T13:01:07Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The reason for a task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource operated &quot;%s&quot; cannot be found</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the queue on which this task was processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>688c2a8bfa4e44ddbba0c8730db91b0c</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The ID of the API request that created this task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the task.</para>
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
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;info&quot;: &quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

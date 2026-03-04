// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJob : TeaModel {
        /// <summary>
        /// <para>The idempotency key of the request for creating the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>An error code returned if the task failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter.ResourceContentBad</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public MediaConvertJobConfig Config { get; set; }

        /// <summary>
        /// <para>The time the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-07T07:16:11Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time the task was completed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-07T07:16:11Z</para>
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
        /// <para>The reason for a failed task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource operated InputFile is bad</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>An array containing the results for each output.</para>
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
        /// <para>The completion percentage of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Percent")]
        [Validation(Required=false)]
        public int? Percent { get; set; }

        /// <summary>
        /// <para>The ID of the queue that processed the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The ID of the API request that created this task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B117AF5-2A1******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <list type="bullet">
        /// <item><description>Inited: Initialized</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Complete</description></item>
        /// <item><description>Error</description></item>
        /// <item><description>Cancelled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

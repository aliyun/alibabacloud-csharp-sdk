// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobItem : TeaModel {
        /// <summary>
        /// <para>The algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grpo</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swebench-lite-grpo-qwen27b</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The creation time in UTC RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T07:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The end time in the UTC RFC 3339 format. This is consistent with the DLC GetJob operation. The job end time is used first. If the job end time is missing, the stop time is used. If both are missing, this field is not returned. The same value rule applies to sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T09:30:00Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The start time in UTC RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T07:05:00Z</para>
        /// </summary>
        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        /// <summary>
        /// <para>The RLJob ID. This field is required and always returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc5yfk7eyg95lac</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job type. Valid value: Train.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Train</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The model names and in-container paths associated with the job.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<RLJobModelConfig> Models { get; set; }

        /// <summary>
        /// <para>The reason code. This is an independent field and must not be parsed from the ReasonMessage text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobStoppedByUser</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The reason description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job is stopped by user.</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The job-level resource group or quota ID persisted in the current job record. This is consistent with DLC GetJob and GetRLJob, and is not the original request value. It is returned from the job record even if the execution snapshot is unreadable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-quota</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The job configuration summary. Uses a supported subset of DLC JobSettings fields. The list returns only the current job tags in Settings.Tags. For the complete configuration, call GetRLJob.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Tags&quot;:{&quot;rls.scene&quot;:&quot;code-rl&quot;}}</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public RLJobSettings Settings { get; set; }

        /// <summary>
        /// <para>The job status. Uses the same vocabulary as DLC ValidJobStatus: Creating, Queuing, Running, Stopping, Succeeded, Failed, or Stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The substatus. Examples include Evaluating, WritingResults, EarlyStopped, Validating, Deleting, and Archived.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Evaluating</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <para>The training and sampling execution mode that takes effect for the job. Valid values: ColocateSync and DisaggregateAsync.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ColocateSync</para>
        /// </summary>
        [NameInMap("TrainerMode")]
        [Validation(Required=false)]
        public string TrainerMode { get; set; }

        /// <summary>
        /// <para>The ID of the user who submitted the job. This has the same meaning as UserId in DLC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

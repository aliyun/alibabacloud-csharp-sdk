// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Run : TeaModel {
        /// <summary>
        /// <para>The visibility of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The ID of the experiment associated with the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-1zpfthdx******</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <para>The time when the run was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the run was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of labels for the run.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<RunLabel> Labels { get; set; }

        /// <summary>
        /// <para>The list of metrics for the run.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<RunMetric> Metrics { get; set; }

        /// <summary>
        /// <para>Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrun</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the owner\&quot;s root account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>163104*****3440</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The list of hyperparameters for the run.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RunParam> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique ID of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run-1qJhzJ2YXgX****</para>
        /// </summary>
        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The ID of the source PAI workload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train9s0afvjkf</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the source PAI workload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TrainingService</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the owner.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the run belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145883</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

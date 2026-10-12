// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RerunWorkflowInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data timestamp specified for the manual workflow instance run, used for matching.</para>
        /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public long? Bizdate { get; set; }

        /// <summary>
        /// <para>The end trigger time (creation time) of the manual workflow instance used for matching. This parameter must be used together with StartTriggerTime.</para>
        /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("EndTriggerTime")]
        [Validation(Required=false)]
        public long? EndTriggerTime { get; set; }

        /// <summary>
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: Production.</description></item>
        /// <item><description>Dev: Development.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The matching conditions for the internal instances of the manual workflow instance.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The list of manual workflow instance IDs used for matching.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the manual workflow used for fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The start trigger time (creation time) of the manual workflow instance used for matching. This parameter must be used together with EndTriggerTime.</para>
        /// <para>The value is a 13-digit number, such as <c>1710239005403</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("StartTriggerTime")]
        [Validation(Required=false)]
        public long? StartTriggerTime { get; set; }

        /// <summary>
        /// <para>The running status of the manual workflow instance used for matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failure</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ManualWorkflow: Manual workflow.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManualWorkflow</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

    }

}

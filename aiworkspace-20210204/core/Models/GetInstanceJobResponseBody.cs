// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetInstanceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time in UTC, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The instance ID. For example, if a job creates a custom role, this parameter returns the corresponding role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>12qb3</b></b></em></para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateWorkspaceCustomRole-role-<em><b>abc</b></em>****</para>
        /// </summary>
        [NameInMap("InstanceJobId")]
        [Validation(Required=false)]
        public string InstanceJobId { get; set; }

        /// <summary>
        /// <para>A message providing details about the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-example</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e195c5116124202371861018d5bde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating: The job is being created.</para>
        /// </description></item>
        /// <item><description><para>Updating: The job is being updated.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The job is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Successful: The job completed successfully (a final state).</para>
        /// </description></item>
        /// <item><description><para>Failed: The job failed (a final state).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateWorkspaceCustomRole</para>
        /// </description></item>
        /// <item><description><para>UpdateWorkspaceCustomRole</para>
        /// </description></item>
        /// <item><description><para>DeleteWorkspaceCustomRole</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateWorkspaceCustomRole</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

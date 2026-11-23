// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetInstanceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time. The time is in UTC and follows the ISO 8601 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Instance ID of the task instance. For example, in a task that creates a custom role, this is instance ID of the generated role.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>12qb3</b></b></em></para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateWorkspaceCustomRole-role-<em><b>abc</b></em>****</para>
        /// </summary>
        [NameInMap("InstanceJobId")]
        [Validation(Required=false)]
        public string InstanceJobId { get; set; }

        /// <summary>
        /// <para>The detailed description of the task.</para>
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
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The task is being created.</description></item>
        /// <item><description>Updating: The task is being updated.</description></item>
        /// <item><description>Deleting: The task is being deleted.</description></item>
        /// <item><description>Successful: The task succeeded. This is a desired state.</description></item>
        /// <item><description>Failed: The task failed. This is a desired state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateWorkspaceCustomRole</description></item>
        /// <item><description>UpdateWorkspaceCustomRole</description></item>
        /// <item><description>DeleteWorkspaceCustomRole</description></item>
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

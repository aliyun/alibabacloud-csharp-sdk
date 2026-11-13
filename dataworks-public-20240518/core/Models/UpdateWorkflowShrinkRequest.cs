// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateWorkflowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client unique code of the workflow, which is used to implement asynchronous and idempotent operations. If you do not specify this parameter when creating a workflow, the system automatically generates one and uniquely binds it to the resource ID. If you specify this parameter when updating or deleting a resource, it must be the same as the client unique code used during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        /// <summary>
        /// <para>The dependency information.</para>
        /// </summary>
        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string DependenciesShrink { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
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
        /// <para>The workflow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The instance generation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T+1: Generates the instance on the next day.</description></item>
        /// <item><description>Immediately: Generates the instance immediately. Note: Periodic instances are generated normally only if the scheduled time of the workflow is at least 10 minutes after the workflow publish time. Real-time instance generation is not supported during the full instance generation period (22:00 to 24:00). You can submit and publish workflows during this period, but instances are not regenerated after submission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Workflow</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string OutputsShrink { get; set; }

        /// <summary>
        /// <para>The account ID of the owner.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The parameter list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>para1=$bizdate para2=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The list of workflow tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string TasksShrink { get; set; }

        /// <summary>
        /// <para>The trigger method.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}

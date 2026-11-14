// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetTaskRequest : TeaModel {
        /// <summary>
        /// <para>The associated resource ID. <b>If TaskId is not specified, you must provide EntityId, EntityType, and TaskCategory at the same time.</b> The resource ID must match the selected resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The associated resource type. Required if TaskId is not specified.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE</b>: Image resource.</description></item>
        /// <item><description><b>APP</b>: Application resource.</description></item>
        /// <item><description><b>SNAPSHOT</b>: Snapshot resource.</description></item>
        /// </list>
        /// <para>You must also select the applicable TaskCategory. The resource type itself does not mean that all task categories can be queried by resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The associated resource version ID. Used to specify the version when querying by resource. For image resources, enter the image version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("EntityVersionId")]
        [Validation(Required=false)]
        public string EntityVersionId { get; set; }

        /// <summary>
        /// <para>The task category when querying by resource. Required if TaskId is not specified.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE_BUILDER</b>: Image creation. Queries tasks for manual creation, automatic creation, or creation based on an instance.</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE</b>: Image region distribution task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_BUILDER</para>
        /// </summary>
        [NameInMap("TaskCategory")]
        [Validation(Required=false)]
        public string TaskCategory { get; set; }

        /// <summary>
        /// <para>The task ID. If specified, the query prioritizes this ID, and resource information query conditions are no longer used for locating the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-bp1example****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not pass this parameter.</b> When querying a task, locate the task by using TaskId or resource information and TaskCategory. This parameter is not used for task filtering.</para>
        /// <para>The example &quot;Not applicable (not enabled)&quot; is only a description of the field status, not a valid parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not applicable (not enabled)</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

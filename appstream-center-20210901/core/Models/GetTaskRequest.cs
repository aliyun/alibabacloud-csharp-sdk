// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetTaskRequest : TeaModel {
        /// <summary>
        /// <para>The associated resource ID. <b>If you do not specify the TaskId parameter, you must specify the EntityId, EntityType, and TaskCategory parameters at the same time.</b> The resource ID must match the selected resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>The associated resource type. This parameter is required if you do not specify the TaskId parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE</b>: image resource.</description></item>
        /// <item><description><b>APP</b>: application resource.</description></item>
        /// <item><description><b>SNAPSHOT</b>: snapshot resource.</description></item>
        /// </list>
        /// <para>You must also select an applicable TaskCategory. The resource type itself does not mean that all task categories can be queried by resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The associated resource version ID. This parameter is used to specify the version when you query by resource. For image resources, specify the image version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("EntityVersionId")]
        [Validation(Required=false)]
        public string EntityVersionId { get; set; }

        /// <summary>
        /// <para>The task category when you query by resource. This parameter is required if you do not specify the TaskId parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE_BUILDER</b>: image creation. Queries tasks for manual creation, automatic creation, or creation based on an instance.</description></item>
        /// <item><description><b>IMAGE_DISTRIBUTE</b>: image distribution across regions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_BUILDER</para>
        /// </summary>
        [NameInMap("TaskCategory")]
        [Validation(Required=false)]
        public string TaskCategory { get; set; }

        /// <summary>
        /// <para>The task ID. If you specify this parameter, the system queries the task by this ID first, and the resource information query conditions are no longer used for locating the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tid-bp1example****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><b>Not enabled. Do not specify this parameter.</b> When you query a task, locate the task by using the TaskId parameter or the resource information and TaskCategory parameter. This parameter is not used for task filtering.</para>
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

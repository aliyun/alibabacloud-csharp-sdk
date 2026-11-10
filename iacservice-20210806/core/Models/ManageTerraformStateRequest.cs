// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ManageTerraformStateRequest : TeaModel {
        /// <summary>
        /// <para>The modification action for the state file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Import</description></item>
        /// <item><description>StateRemove</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Import</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. A UUID is recommended.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The task identifier. For stack tasks, the format is &lt;$stackId&gt;:&lt;$deploymentName&gt;. For regular tasks, the format is &lt;$TaskId&gt;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-as11xxxxxxxxx:developmentA</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The actual ID of the Terraform resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxx</para>
        /// </summary>
        [NameInMap("importResourceId")]
        [Validation(Required=false)]
        public string ImportResourceId { get; set; }

        /// <summary>
        /// <para>The identifier of the resource in the Terraform template. For stack tasks, the format is &lt;$componetName&gt;:&lt;$resourceName&gt;. For regular tasks, the format is &lt;$resourceName&gt;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc:alicloud_vswitch.vswitches[0]</para>
        /// </summary>
        [NameInMap("resourceIdentifier")]
        [Validation(Required=false)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Stack</description></item>
        /// <item><description>Task</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stack</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

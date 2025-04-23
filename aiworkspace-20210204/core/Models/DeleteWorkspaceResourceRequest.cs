// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource group. You can call <a href="https://help.aliyun.com/document_detail/449143.html">ListResources</a> to obtain the name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The tags. Multiple tags are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.supported.eas=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DetachAndDelete: disassociates a resource from a workspace and deletes the resource in the workspace. This is the default value.</description></item>
        /// <item><description>Detach: disassociates a resource group from a workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DetachAndDelete</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>**This field is no longer used and will be removed. Use the ResourceType field instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The resource IDs. Multiple resource IDs are separated by commas (,). The GroupName values for the specified resources must be the same. You cannot leave both GroupName and ResourceIds empty. You can specify both parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource-dks<b><b><b>jkf,Resource-adf</b></b></b>dss</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// <item><description>Lingjun</description></item>
        /// <item><description>ACS</description></item>
        /// <item><description>FLINK</description></item>
        /// <item><description>MaxCompute (This resource type is valid only if Option is set to Detach.)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The resource group name. To get the resource group name, see <a href="https://help.aliyun.com/document_detail/449143.html">ListResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>A comma-separated list of labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system.supported.eas=true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The deletion behavior. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DetachAndDelete</c> (default): Detaches the resource from the workspace and deletes the resource.</para>
        /// </description></item>
        /// <item><description><para><c>Detach</c>: Detaches the resource from the workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DetachAndDelete</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para><b>This parameter is deprecated and will be removed. Use the <c>ResourceType</c> parameter instead.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>A comma-separated list of resource IDs. All specified resources must belong to the same <c>GroupName</c>. You must specify a value for at least one of the <c>GroupName</c> or <c>ResourceIds</c> parameters.</para>
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
        /// <item><description><para><c>ECS</c>: general-purpose computing resources</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: Lingjun intelligent computing resources</para>
        /// </description></item>
        /// <item><description><para><c>ACS</c>: ACS computing resources</para>
        /// </description></item>
        /// <item><description><para><c>Flink</c>: Flink resources.</para>
        /// </description></item>
        /// <item><description><para><c>MaxCompute</c>: MaxCompute resources. For this resource type, the <c>Option</c> parameter can only be set to <c>Detach</c>.</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedAckPro</c>: AckPro unified management cluster resources</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedAckLingjun</c>: AckLinjun unified management cluster resources</para>
        /// </description></item>
        /// <item><description><para><c>SelfManagedASI</c>: ASI unified management cluster resources (third-party cloud)</para>
        /// </description></item>
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

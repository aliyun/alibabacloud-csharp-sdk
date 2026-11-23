// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the resource group. To obtain the name of the resource group, see <a href="https://help.aliyun.com/document_detail/449143.html">ListResources</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The list of tags, separated by commas.</para>
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
        /// <item><description>DetachAndDelete: Unbinds the resources from the workspace and deletes the resources. This is the default value.</description></item>
        /// <item><description>Detach: Unbinds the resources from the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DetachAndDelete</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is deprecated and will be retired. Use the ResourceType field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The IDs of the resources, separated by commas. The GroupName of these resource IDs must be the same. GroupName and ResourceIds cannot be empty at the same time, but both can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource-dks<b><b><b>jkf,Resource-adf</b></b></b>dss</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The list of resource types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: general computing resources</description></item>
        /// <item><description>Lingjun: Lingjun AI computing resources</description></item>
        /// <item><description>ACS: ACS computing resources</description></item>
        /// <item><description>FLINK: Flink resources</description></item>
        /// <item><description>MaxCompute: MaxCompute resources. Only the Detach option is supported. The DetachAndDelete option is not supported.</description></item>
        /// <item><description>SelfManagedAckPro: ACK Pro unified management cluster resources</description></item>
        /// <item><description>SelfManagedAckLingjun: ACK Lingjun unified management cluster resources</description></item>
        /// <item><description>SelfManagedASI: ASI unified management cluster resources (third-party cloud)</description></item>
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

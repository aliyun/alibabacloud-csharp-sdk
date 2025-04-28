// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateAndAttach: creates resources and associates the resources with a workspace.</description></item>
        /// <item><description>Attach: associates resources with a workspace.</description></item>
        /// </list>
        /// <remarks>
        /// <para> MaxCompute supports only the Attach operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateAndAttach</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateWorkspaceResourceRequestResources> Resources { get; set; }
        public class CreateWorkspaceResourceRequestResources : TeaModel {
            /// <summary>
            /// <para>The environment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dev: development environment</description></item>
            /// <item><description>prod: production environment</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The name of the resource group, which is unique within your Alibaba Cloud account. This parameter is required for MaxCompute, Elastic Compute Service (ECS), Lingjun, Alibaba Cloud Container Compute Service (ACS), and Realtime Compute for Apache Flink resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>groupName</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Specifies whether the resource is the default resource. Each type of resources has a default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default)</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The labels added to the resource.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesLabels> Labels { get; set; }
            public class CreateWorkspaceResourceRequestResourcesLabels : TeaModel {
                /// <summary>
                /// <para>The label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system.support.eas</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The resource name. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>The name must be 3 to 28 characters in length, and can contain only letters, digits, and underscores (_). The name must start with a letter.</description></item>
            /// <item><description>The name must be unique in the region.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>**This parameter is no longer used and will be removed. Use the ResourceType parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The quotas. Only MaxCompute quotas are available.</para>
            /// </summary>
            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesQuotas> Quotas { get; set; }
            public class CreateWorkspaceResourceRequestResourcesQuotas : TeaModel {
                /// <summary>
                /// <para>The quota ID. You can call <a href="https://help.aliyun.com/document_detail/449144.html">ListQuotas</a> to obtain the quota ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>232892******92912</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The resource types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MaxCompute</description></item>
            /// <item><description>ECS</description></item>
            /// <item><description>Lingjun</description></item>
            /// <item><description>ACS</description></item>
            /// <item><description>FLINK</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource specifications in the JSON format.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            /// <summary>
            /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}

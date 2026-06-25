// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceResourceRequest : TeaModel {
        /// <summary>
        /// <para>The creation behavior. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CreateAndAttach</c>: Creates a resource and attaches it to the workspace.</para>
        /// </description></item>
        /// <item><description><para><c>Attach</c>: Attaches an existing resource to the workspace. This option requires you to specify the <c>Name</c>, <c>ResourceType</c>, <c>GroupName</c>, and <c>EnvType</c> parameters.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>MaxCompute resources only support the <c>Attach</c> option.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CreateAndAttach</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateWorkspaceResourceRequestResources> Resources { get; set; }
        public class CreateWorkspaceResourceRequestResources : TeaModel {
            /// <summary>
            /// <para>The environment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>dev</c>: development environment</para>
            /// </description></item>
            /// <item><description><para><c>prod</c>: production environment</para>
            /// </description></item>
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
            /// <para>The name of the resource group. The name must be unique within an Alibaba Cloud account. This parameter is required for MaxCompute, ECS, Lingjun, ACS, and Flink resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>groupName</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default resource for its type. Each resource type can have only one default resource.</para>
            /// <list type="bullet">
            /// <item><description><para><c>false</c> (default): The resource is not the default resource.</para>
            /// </description></item>
            /// <item><description><para><c>true</c>: The resource is the default resource.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>An array of resource tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesLabels> Labels { get; set; }
            public class CreateWorkspaceResourceRequestResourcesLabels : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system.support.eas</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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
            /// <item><description><para>Must be 3 to 28 characters long, start with a letter, and can contain only letters, digits, and underscores (_).</para>
            /// </description></item>
            /// <item><description><para>Must be unique within the same region.</para>
            /// </description></item>
            /// <item><description><para>If <c>Option</c> is set to <c>Attach</c> and <c>ResourceType</c> is set to <c>MaxCompute</c>, this parameter specifies the project name.</para>
            /// </description></item>
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
            /// <para><b>[Deprecated]</b> This parameter is deprecated and will be removed in a future version. Use the <c>ResourceType</c> parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The resource quotas. Currently, only MaxCompute resources have resource quotas.</para>
            /// </summary>
            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<CreateWorkspaceResourceRequestResourcesQuotas> Quotas { get; set; }
            public class CreateWorkspaceResourceRequestResourcesQuotas : TeaModel {
                /// <summary>
                /// <para>The ID of the resource quota. To obtain the resource quota ID, see <a href="https://help.aliyun.com/document_detail/449144.html">ListQuotas</a>. This parameter is required only for subscription MaxCompute resources.
                /// For ECS, Lingjun, and ACS resources, you do not need to specify this parameter. Their quota information is configured in the <c>Spec</c> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>232892******92912</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>MaxCompute</c>: MaxCompute resources</para>
            /// </description></item>
            /// <item><description><para><c>ECS</c>: general-purpose computing resources</para>
            /// </description></item>
            /// <item><description><para><c>Lingjun</c>: Lingjun intelligent computing resources</para>
            /// </description></item>
            /// <item><description><para><c>ACS</c>: ACS computing resources</para>
            /// </description></item>
            /// <item><description><para><c>Flink</c>: Flink resources</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedAckPro</c>: unified managed cluster resource (AckPro)</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedAckLingjun</c>: unified managed cluster resource (AckLingjun)</para>
            /// </description></item>
            /// <item><description><para><c>SelfManagedASI</c>: unified managed cluster resource for third-party clouds (ASI)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource specification in JSON format. For ECS and Lingjun resources, the format is as follows:
            /// {<br>
            /// &quot;clusterType&quot;: &quot;The type of the cluster&quot;,
            /// &quot;resourceId&quot;: &quot;The ID of the quota&quot;,
            /// &quot;resourceName&quot;: &quot;The name of the quota&quot;
            /// }
            /// The <c>clusterType</c> parameter can have the following values:<br></para>
            /// <list type="bullet">
            /// <item><description><para><c>share</c>: shared resource group</para>
            /// </description></item>
            /// <item><description><para><c>private</c>: dedicated resource group</para>
            /// </description></item>
            /// <item><description><para><c>FullyManaged</c>: fully managed ACS resource</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;clusterType&quot;: &quot;private&quot;,
            ///         &quot;resourceId&quot;: &quot;quota1c<b><b><b>b4&quot;,
            ///         &quot;resourceName&quot;: &quot;unif</b></b></b>90&quot;
            ///       }</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the resource belongs. To obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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

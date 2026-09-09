// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of an existing model operator instance to associate. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("AIDBClusterId")]
        [Validation(Required=false)]
        public string AIDBClusterId { get; set; }

        /// <summary>
        /// <para>The AgenticDB branch specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DBClusterId&quot;:&quot;pagc-2zea920mcvd5o87&quot;,&quot;TenantId&quot;:&quot;t-cfc2d7df0e59439681f0087f51&quot;,&quot;ProjectId&quot;:&quot;proj-d7849d0050664c758af795d468&quot;,&quot;BranchId&quot;:&quot;br-9054b3b7649e4c0d977bd0df37&quot;,&quot;ForkFromBranch&quot;:true,&quot;ForkFromApplicationId&quot;:&quot;pa-source&quot;}</para>
        /// </summary>
        [NameInMap("AgenticDBBranchSpec")]
        [Validation(Required=false)]
        public CreateApplicationRequestAgenticDBBranchSpec AgenticDBBranchSpec { get; set; }
        public class CreateApplicationRequestAgenticDBBranchSpec : TeaModel {
            /// <summary>
            /// <para>The AgenticDB branch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-9054b3b7649e4c0d977bd0df37</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public string BranchId { get; set; }

            /// <summary>
            /// <para>The AgenticDB cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pagc-2zea920mcvd5o87</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the source application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-source</para>
            /// </summary>
            [NameInMap("ForkFromApplicationId")]
            [Validation(Required=false)]
            public string ForkFromApplicationId { get; set; }

            /// <summary>
            /// <para>Specifies whether to create the application based on a specified AgenticDB branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ForkFromBranch")]
            [Validation(Required=false)]
            public bool? ForkFromBranch { get; set; }

            /// <summary>
            /// <para>The AgenticDB project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-d7849d0050664c758af795d468</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The AgenticDB tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-cfc2d7df0e59439681f0087f51</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>supabase: Set this value to create a managed Supabase application.</description></item>
        /// <item><description>raycluster: Set this value to create a managed Ray Cluster application.</description></item>
        /// <item><description>polarclaw: Set this value to create a managed PolarClaw application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>x86</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The authentication service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu</para>
        /// </summary>
        [NameInMap("AuthProvider")]
        [Validation(Required=false)]
        public string AuthProvider { get; set; }

        /// <summary>
        /// <para>The authentication provider configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AuthProviderConfig")]
        [Validation(Required=false)]
        public string AuthProviderConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of an elastic IP address (EIP) and attach it to the instance. This is equivalent to associate with an EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("AutoAllocatePublicEip")]
        [Validation(Required=false)]
        public bool? AutoAllocatePublicEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of a cold storage Polarlakebase instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Automatic creation is disabled.</description></item>
        /// <item><description>true: Automatic creation is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreatePolarFs")]
        [Validation(Required=false)]
        public bool? AutoCreatePolarFs { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Use coupons.</description></item>
        /// <item><description>false: Do not use coupons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The list of user-defined application subcomponents.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestComponents> Components { get; set; }
        public class CreateApplicationRequestComponents : TeaModel {
            /// <summary>
            /// <para>The specification of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <para>The maximum number of replicas for the application subcomponent with the same specification. Default value: the value of ComponentReplica.</para>
            /// <list type="bullet">
            /// <item><description>Only raycluster supports this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentMaxReplica")]
            [Validation(Required=false)]
            public long? ComponentMaxReplica { get; set; }

            /// <summary>
            /// <para>The number of replicas for the application subcomponent. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentReplica")]
            [Validation(Required=false)]
            public long? ComponentReplica { get; set; }

            /// <summary>
            /// <para>The type of the application subcomponent.</para>
            /// <para>For supabase, valid values:</para>
            /// <list type="bullet">
            /// <item><description>gateway</description></item>
            /// <item><description>backend</description></item>
            /// </list>
            /// <para>For raycluster, valid values:</para>
            /// <list type="bullet">
            /// <item><description>head</description></item>
            /// <item><description>worker</description></item>
            /// <item><description>gpuworker</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The maximum number of replicas for component scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum number of replicas for component scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

            /// <summary>
            /// <para>The list of security groups for the application subcomponent, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-********************</para>
            /// </summary>
            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public string SecurityGroups { get; set; }

            /// <summary>
            /// <para>The name of the whitelist IP address group for the application subcomponent. Default value: default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <para>The whitelist IP addresses of the application subcomponent, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The type of the whitelist IP addresses for the application subcomponent. Default value: ipv4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the PolarDB instance on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of expected DNAT entries for NAT mapping. Specify this parameter together with VpcNatGatewayId. This parameter can be left empty, which indicates that no DNAT entries are created.</para>
        /// </summary>
        [NameInMap("DnatEntries")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestDnatEntries> DnatEntries { get; set; }
        public class CreateApplicationRequestDnatEntries : TeaModel {
            /// <summary>
            /// <para>The frontend port. This parameter is optional. If not specified, the system automatically assigns a port that does not conflict with ports already in use on the gateway. You can query the assignment result by calling the DescribeApplicationAttribute operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("FrontPort")]
            [Validation(Required=false)]
            public int? FrontPort { get; set; }

            /// <summary>
            /// <para>The port name. Valid values: webui, hermesagent, dashboard, and ssh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webui</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

        }

        /// <summary>
        /// <para>The DNAT-dedicated NAT IP address that has been allocated (separate from the SNAT IP address) for NAT mapping. The IP address must belong to the specified gateway and be in an available state. The vSwitch of the gateway must belong to a primary CIDR block that is reachable from the office network. Specify this parameter together with VpcNatGatewayId. Prerequisite: An SNAT entry has been bound to the vSwitch where the application resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.64.0.10</para>
        /// </summary>
        [NameInMap("DnatIpAddress")]
        [Validation(Required=false)]
        public string DnatIpAddress { get; set; }

        /// <summary>
        /// <para>Default value: <c>false</c>. If you set this parameter to <c>true</c>, only parameter and resource validation is performed without actually creating the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of user-defined service endpoints. By default, a VPC endpoint is created.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestEndpoints> Endpoints { get; set; }
        public class CreateApplicationRequestEndpoints : TeaModel {
            /// <summary>
            /// <para>The description of the service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_endpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the service endpoint. The value is fixed as Primary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// <para>Required for knowledge applications.</para>
        /// </summary>
        [NameInMap("KnowledgeApplicationSpec")]
        [Validation(Required=false)]
        public CreateApplicationRequestKnowledgeApplicationSpec KnowledgeApplicationSpec { get; set; }
        public class CreateApplicationRequestKnowledgeApplicationSpec : TeaModel {
            /// <summary>
            /// <para>The dashboard password.</para>
            /// </summary>
            [NameInMap("DashboardPassword")]
            [Validation(Required=false)]
            public string DashboardPassword { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// </summary>
            [NameInMap("DbPassword")]
            [Validation(Required=false)]
            public string DbPassword { get; set; }

            /// <summary>
            /// <para>Required for knowledge applications. The LLM model name, such as qwen3-max.</para>
            /// </summary>
            [NameInMap("LlmModel")]
            [Validation(Required=false)]
            public string LlmModel { get; set; }

        }

        /// <summary>
        /// <para>Required for mem0 applications.</para>
        /// </summary>
        [NameInMap("MemApplicationSpec")]
        [Validation(Required=false)]
        public CreateApplicationRequestMemApplicationSpec MemApplicationSpec { get; set; }
        public class CreateApplicationRequestMemApplicationSpec : TeaModel {
            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-database-name</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-user-password</para>
            /// </summary>
            [NameInMap("DbPassword")]
            [Validation(Required=false)]
            public string DbPassword { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-user</para>
            /// </summary>
            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            /// <summary>
            /// <para>Required for mem0 applications. The embedder model name, such as text-embedding-v4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("EmbedderModel")]
            [Validation(Required=false)]
            public string EmbedderModel { get; set; }

            /// <summary>
            /// <para>The vector dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("EmbedderModelDimension")]
            [Validation(Required=false)]
            public int? EmbedderModelDimension { get; set; }

            /// <summary>
            /// <para>The graph LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("GraphLlmModel")]
            [Validation(Required=false)]
            public string GraphLlmModel { get; set; }

            /// <summary>
            /// <para>Required for mem0 applications. The LLM model name, such as qwen3-max.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("LlmModel")]
            [Validation(Required=false)]
            public string LlmModel { get; set; }

            /// <summary>
            /// <para>The project name, which corresponds to the database schema that stores project data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project-name</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Required for mem0 applications. The reranker model name, such as qwen3-rerank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankerModel")]
            [Validation(Required=false)]
            public string RerankerModel { get; set; }

            /// <summary>
            /// <para>The number of table shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

        }

        /// <summary>
        /// <para>The model API. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai-completions</para>
        /// </summary>
        [NameInMap("ModelApi")]
        [Validation(Required=false)]
        public string ModelApi { get; set; }

        /// <summary>
        /// <para>The model API key. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelApiKey")]
        [Validation(Required=false)]
        public string ModelApiKey { get; set; }

        /// <summary>
        /// <para>The model base URL. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("ModelBaseUrl")]
        [Validation(Required=false)]
        public string ModelBaseUrl { get; set; }

        /// <summary>
        /// <para>The model source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>bailian: Alibaba Cloud Model Studio model.</description></item>
        /// <item><description>custom: Custom model.</description></item>
        /// <item><description>maas: PolarDB model operator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ModelFrom")]
        [Validation(Required=false)]
        public string ModelFrom { get; set; }

        /// <summary>
        /// <para>The model name. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The list of parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestParameters> Parameters { get; set; }
        public class CreateApplicationRequestParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret.gateway.auth.token</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TK***</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The billing type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription type (yearly or monthly).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The instance ID of the Polarlakebase cold storage or high-performance edition. Default value: empty. If specified, the corresponding storage is mounted to the application.</para>
        /// <para>Currently, only the following applications support this parameter:</para>
        /// <list type="bullet">
        /// <item><description>supabase</description></item>
        /// <item><description>raycluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-********************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <para>The coupon code. If you do not specify this parameter, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region. Default value: the region of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-********************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the IP whitelist group. Default value: <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SecurityIPArrayName")]
        [Validation(Required=false)]
        public string SecurityIPArrayName { get; set; }

        /// <summary>
        /// <para>The IP whitelist. If you do not specify this parameter, the default value is <c>127.0.0.1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1,172.17.0.0/24</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The type of the IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("SecurityIPType")]
        [Validation(Required=false)]
        public string SecurityIPType { get; set; }

        /// <summary>
        /// <para>The skill template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SkillTemplateId")]
        [Validation(Required=false)]
        public string SkillTemplateId { get; set; }

        /// <summary>
        /// <para>The list of application storages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;StorageType&quot;:&quot;oss&quot;,&quot;StorageInstanceId&quot;:&quot;pfs-xxxx&quot;,&quot;EndpointId&quot;:&quot;pe-xxxx&quot;}]</para>
        /// </summary>
        [NameInMap("Storages")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestStorages> Storages { get; set; }
        public class CreateApplicationRequestStorages : TeaModel {
            /// <summary>
            /// <para>The mount path inside the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/container</para>
            /// </summary>
            [NameInMap("ContainerMountPath")]
            [Validation(Required=false)]
            public string ContainerMountPath { get; set; }

            /// <summary>
            /// <para>The storage endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-xxxx</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The storage mount path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/source</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The storage capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageCapacity")]
            [Validation(Required=false)]
            public string StorageCapacity { get; set; }

            /// <summary>
            /// <para>The storage access endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarfs.example.com</para>
            /// </summary>
            [NameInMap("StorageEndpoint")]
            [Validation(Required=false)]
            public string StorageEndpoint { get; set; }

            /// <summary>
            /// <para>The storage instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pfs-xxxx</para>
            /// </summary>
            [NameInMap("StorageInstanceId")]
            [Validation(Required=false)]
            public string StorageInstanceId { get; set; }

            /// <summary>
            /// <para>The storage performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("StoragePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestTag> Tag { get; set; }
        public class CreateApplicationRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The target version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch. Default value: the vSwitch in the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-********************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The VPC NAT gateway ID for NAT mapping. If specified, NAT mapping is enabled when the instance is created. The NAT gateway must be in the same VPC as the application, use the private network type (intranet), and be in an active state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxx</para>
        /// </summary>
        [NameInMap("VpcNatGatewayId")]
        [Validation(Required=false)]
        public string VpcNatGatewayId { get; set; }

        /// <summary>
        /// <para>The zone. Default value: the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

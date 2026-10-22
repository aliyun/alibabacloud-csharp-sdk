// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated existing model operator instance. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("AIDBClusterId")]
        [Validation(Required=false)]
        public string AIDBClusterId { get; set; }

        /// <summary>
        /// <para>The AgenticDB branch specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DBClusterId&quot;:&quot;pagc-2zea920mcvd5o87&quot;,&quot;TenantId&quot;:&quot;t-cfc2d7df0e59439681f0087f51&quot;,&quot;ProjectId&quot;:&quot;proj-d7849d0050664c758af795d468&quot;,&quot;BranchId&quot;:&quot;br-9054b3b7649e4c0d977bd0df37&quot;,&quot;ForkFromBranch&quot;:true,&quot;ForkFromApplicationId&quot;:&quot;pa-source&quot;}</para>
        /// </summary>
        [NameInMap("AgenticDBBranchSpec")]
        [Validation(Required=false)]
        public CreateApplicationRequestAgenticDBBranchSpec AgenticDBBranchSpec { get; set; }
        public class CreateApplicationRequestAgenticDBBranchSpec : TeaModel {
            /// <summary>
            /// <para>The ID of the AgenticDB branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-9054b3b7649e4c0d977bd0df37</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public string BranchId { get; set; }

            /// <summary>
            /// <para>The ID of the AgenticDB cluster.</para>
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
            /// <para>The ID of the AgenticDB project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-d7849d0050664c758af795d468</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the AgenticDB tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-cfc2d7df0e59439681f0087f51</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the AgenticDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pagc-xxx</para>
        /// </summary>
        [NameInMap("AgenticDBClusterId")]
        [Validation(Required=false)]
        public string AgenticDBClusterId { get; set; }

        /// <summary>
        /// <para>The application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>supabase: Specify this value to create a managed Supabase application.</description></item>
        /// <item><description>raycluster: Specify this value to create a managed Ray Cluster application.</description></item>
        /// <item><description>polarclaw: Specify this value to create a managed PolarClaw application.</description></item>
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
        /// <para>Specifies whether to automatically create and attach an EIP.</para>
        /// </summary>
        [NameInMap("AutoAllocatePublicEip")]
        [Validation(Required=false)]
        public bool? AutoAllocatePublicEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a Polarlakebase Cold Storage Edition instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Do not automatically create the instance.</description></item>
        /// <item><description>true: Automatically create the instance.</description></item>
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
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Use the coupon.</description></item>
        /// <item><description>false: Do not use the coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The list of custom application subcomponents.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestComponents> Components { get; set; }
        public class CreateApplicationRequestComponents : TeaModel {
            /// <summary>
            /// <para>The specifications of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <para>The maximum number of application subcomponents of the same specifications. Default value: the value of ComponentReplica.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only by raycluster.</description></item>
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
            /// <para>The type of the application subcomponent.
            /// For supabase, valid values:</para>
            /// <list type="bullet">
            /// <item><description>gateway</description></item>
            /// <item><description>backend
            /// For raycluster, valid values:</description></item>
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
            /// <para>The upper limit for component scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <para>The lower limit for component scaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

            /// <summary>
            /// <para>The list of security groups for the application subcomponent. Separate multiple security group IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-********************</para>
            /// </summary>
            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public string SecurityGroups { get; set; }

            /// <summary>
            /// <para>The name of the IP address whitelist group for the application subcomponent. Default value: default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist for the application subcomponent. Separate multiple IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The type of the IP addresses in the whitelist for the application subcomponent. Default value: ipv4.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the PolarDB instance on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description or remark of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of expected DNAT entries for NAT mapping. Specify this parameter together with VpcNatGatewayId. If this parameter is left empty, no DNAT entries are created.</para>
        /// </summary>
        [NameInMap("DnatEntries")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestDnatEntries> DnatEntries { get; set; }
        public class CreateApplicationRequestDnatEntries : TeaModel {
            /// <summary>
            /// <para>The frontend port. This parameter is optional. By default, the system automatically assigns a port that is not occupied by the gateway. You can call the DescribeApplicationAttribute operation to query the assigned port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("FrontPort")]
            [Validation(Required=false)]
            public int? FrontPort { get; set; }

            /// <summary>
            /// <para>The name of the port. Valid values: webui, hermesagent, dashboard, and ssh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webui</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

        }

        /// <summary>
        /// <para>The DNAT-specific NAT IP address allocated for NAT mapping, which is separate from the SNAT IP address. The IP address must belong to the NAT gateway, be in the available state, and the vSwitch where the gateway resides must belong to a primary CIDR block reachable from the office network. Specify this parameter together with VpcNatGatewayId. Prerequisite: An SNAT entry is associated with the vSwitch where the application resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.64.0.10</para>
        /// </summary>
        [NameInMap("DnatIpAddress")]
        [Validation(Required=false)]
        public string DnatIpAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default value: false. If you set this parameter to true, only parameter and resource validation is performed, and no resources are actually created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of custom service endpoints. By default, a VPC endpoint is created.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateApplicationRequestEndpoints> Endpoints { get; set; }
        public class CreateApplicationRequestEndpoints : TeaModel {
            /// <summary>
            /// <para>The remark of the service endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_endpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the service endpoint. Set the value to Primary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

        }

        /// <summary>
        /// <para>The required parameters for knowledge applications.</para>
        /// </summary>
        [NameInMap("KnowledgeApplicationSpec")]
        [Validation(Required=false)]
        public CreateApplicationRequestKnowledgeApplicationSpec KnowledgeApplicationSpec { get; set; }
        public class CreateApplicationRequestKnowledgeApplicationSpec : TeaModel {
            /// <summary>
            /// <para>The dashboard password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-dashboard-password</para>
            /// </summary>
            [NameInMap("DashboardPassword")]
            [Validation(Required=false)]
            public string DashboardPassword { get; set; }

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
            /// <para>Required for knowledge applications. The name of the LLM model, such as qwen3-max.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("LlmModel")]
            [Validation(Required=false)]
            public string LlmModel { get; set; }

        }

        /// <summary>
        /// <para>The required parameters for mem0 applications.</para>
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
            /// <para>Required for mem0 applications. The name of the embedder model, such as text-embedding-v4.</para>
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
            /// <para>Required for mem0 applications. The name of the LLM model, such as qwen3-max.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("LlmModel")]
            [Validation(Required=false)]
            public string LlmModel { get; set; }

            /// <summary>
            /// <para>The memory type, such as multimodal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MULTIMODAL_TEXT</para>
            /// </summary>
            [NameInMap("MemoryType")]
            [Validation(Required=false)]
            public string MemoryType { get; set; }

            /// <summary>
            /// <para>The instance ID of the PolarAI embedding model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-xxx</para>
            /// </summary>
            [NameInMap("PolarAIEmbedderInstanceId")]
            [Validation(Required=false)]
            public string PolarAIEmbedderInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID of the PolarAI graph LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-xxx</para>
            /// </summary>
            [NameInMap("PolarAIGraphLlmInstanceId")]
            [Validation(Required=false)]
            public string PolarAIGraphLlmInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID of the PolarAI LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-xxx</para>
            /// </summary>
            [NameInMap("PolarAILlmInstanceId")]
            [Validation(Required=false)]
            public string PolarAILlmInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID of the PolarAI reranker model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-xxx</para>
            /// </summary>
            [NameInMap("PolarAIRerankerInstanceId")]
            [Validation(Required=false)]
            public string PolarAIRerankerInstanceId { get; set; }

            /// <summary>
            /// <para>The project name, which corresponds to the schema in the database where project data is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project-name</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Required for mem0 applications. The name of the reranker model, such as qwen3-rerank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankerModel")]
            [Validation(Required=false)]
            public string RerankerModel { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

            /// <summary>
            /// <para>The name of the visual embedder model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.7-text-embedding</para>
            /// </summary>
            [NameInMap("VisualEmbedderModel")]
            [Validation(Required=false)]
            public string VisualEmbedderModel { get; set; }

            /// <summary>
            /// <para>The vector dimensions of the visual embedder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2560</para>
            /// </summary>
            [NameInMap("VisualEmbedderModelDimension")]
            [Validation(Required=false)]
            public int? VisualEmbedderModelDimension { get; set; }

            /// <summary>
            /// <para>The list of modalities for the visual LLM, such as image.</para>
            /// </summary>
            [NameInMap("VisualLlmModalities")]
            [Validation(Required=false)]
            public List<string> VisualLlmModalities { get; set; }

            /// <summary>
            /// <para>The name of the visual LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.6-flash</para>
            /// </summary>
            [NameInMap("VisualLlmModel")]
            [Validation(Required=false)]
            public string VisualLlmModel { get; set; }

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
        /// <para>The model endpoint. This parameter takes effect only when ApplicationType is set to polarclaw.</para>
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
        /// <item><description>bailian: Model Studio model.</description></item>
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
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret.gateway.auth.token</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TK***</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription period unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the Polarlakebase Cold Storage Edition or High-performance Edition instance. Default value: empty. If you specify this parameter, the corresponding storage is mounted to the application.</para>
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
        /// <para>The region ID. Default value: the region of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-********************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist group. Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SecurityIPArrayName")]
        [Validation(Required=false)]
        public string SecurityIPArrayName { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. If you do not specify this parameter, the default value 127.0.0.1 is used.</para>
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
            /// <para>The mount path in the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/container</para>
            /// </summary>
            [NameInMap("ContainerMountPath")]
            [Validation(Required=false)]
            public string ContainerMountPath { get; set; }

            /// <summary>
            /// <para>The ID of the storage endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pe-xxxx</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The mount path of the storage.</para>
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
            /// <para>The access endpoint of the storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarfs.example.com</para>
            /// </summary>
            [NameInMap("StorageEndpoint")]
            [Validation(Required=false)]
            public string StorageEndpoint { get; set; }

            /// <summary>
            /// <para>The ID of the storage instance.</para>
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
            /// <para>The type of the storage.</para>
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
        /// <para>The vSwitch ID. Default value: the current vSwitch in the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-********************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The NAT gateway ID of the self-managed VPC NAT gateway for NAT mapping. If you specify this parameter, NAT mapping is enabled when the instance is created. The NAT gateway must be in the same VPC as the application, use the private network (intranet) type, and be active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxx</para>
        /// </summary>
        [NameInMap("VpcNatGatewayId")]
        [Validation(Required=false)]
        public string VpcNatGatewayId { get; set; }

        /// <summary>
        /// <para>The zone ID. Default value: the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

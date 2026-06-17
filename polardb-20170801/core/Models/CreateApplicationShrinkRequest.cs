// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of an existing model operator instance to associate. This parameter is effective only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("AIDBClusterId")]
        [Validation(Required=false)]
        public string AIDBClusterId { get; set; }

        /// <summary>
        /// <para>The type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>supabase: Creates a managed Supabase application.</para>
        /// </description></item>
        /// <item><description><para>raycluster: Creates a managed Ray Cluster application.</para>
        /// </description></item>
        /// <item><description><para>polarclaw: Creates a managed PolarClaw application.</para>
        /// </description></item>
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
        /// <para>The CPU architecture. Valid value:</para>
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
        /// <para>The configuration of the authentication provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AuthProviderConfig")]
        [Validation(Required=false)]
        public string AuthProviderConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create and bind an Elastic IP Address (EIP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("AutoAllocatePublicEip")]
        [Validation(Required=false)]
        public bool? AutoAllocatePublicEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a PolarFS cold storage instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Does not automatically create the instance.</para>
        /// </description></item>
        /// <item><description><para>true: Automatically creates the instance.</para>
        /// </description></item>
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
        /// <item><description><para>true (default): Uses a coupon.</para>
        /// </description></item>
        /// <item><description><para>false: Does not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A list of custom child components for the application.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB instance that the application depends on.</para>
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
        /// <para>The default value is <c>false</c>. If you set this parameter to <c>true</c>, the system only checks the parameters and resources without creating the actual resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>A list of custom server-side endpoints. By default, a VPC Endpoint is created.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public string EndpointsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required for knowledge applications.</para>
        /// </summary>
        [NameInMap("KnowledgeApplicationSpec")]
        [Validation(Required=false)]
        public string KnowledgeApplicationSpecShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required for mem0 applications.</para>
        /// </summary>
        [NameInMap("MemApplicationSpec")]
        [Validation(Required=false)]
        public string MemApplicationSpecShrink { get; set; }

        /// <summary>
        /// <para>The model API. This parameter is effective only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai-completions</para>
        /// </summary>
        [NameInMap("ModelApi")]
        [Validation(Required=false)]
        public string ModelApi { get; set; }

        /// <summary>
        /// <para>The API key for the model. This parameter is effective only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelApiKey")]
        [Validation(Required=false)]
        public string ModelApiKey { get; set; }

        /// <summary>
        /// <para>The URL of the model. This parameter is effective only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("ModelBaseUrl")]
        [Validation(Required=false)]
        public string ModelBaseUrl { get; set; }

        /// <summary>
        /// <para>The source of the model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>bailian: Alibaba Cloud Model Studio model.</para>
        /// </description></item>
        /// <item><description><para>custom: A custom model.</para>
        /// </description></item>
        /// <item><description><para>maas: PolarDB model operator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ModelFrom")]
        [Validation(Required=false)]
        public string ModelFrom { get; set; }

        /// <summary>
        /// <para>The name of the model. This parameter is effective only when ApplicationType is set to polarclaw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>A list of parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

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
        /// <para>The subscription period type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the PolarFileSystem (PolarFS) cold storage or high-performance instance. This parameter is empty by default. If you specify this parameter, the corresponding storage is mounted to the application.</para>
        /// <para>This feature is currently supported only by the following applications:</para>
        /// <list type="bullet">
        /// <item><description><para>supabase</para>
        /// </description></item>
        /// <item><description><para>raycluster</para>
        /// </description></item>
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
        /// <para>The region. The default value is the region of the instance.</para>
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
        /// <para>The name of the IP address whitelist group. The default value is <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SecurityIPArrayName")]
        [Validation(Required=false)]
        public string SecurityIPArrayName { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. If you do not specify this parameter, the default value <c>127.0.0.1</c> is used.</para>
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
        /// <para>The ID of the skill template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SkillTemplateId")]
        [Validation(Required=false)]
        public string SkillTemplateId { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateApplicationShrinkRequestTag> Tag { get; set; }
        public class CreateApplicationShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
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
        /// <para>The vSwitch. The default value is the current vSwitch in the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-********************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone. The default value is the primary zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

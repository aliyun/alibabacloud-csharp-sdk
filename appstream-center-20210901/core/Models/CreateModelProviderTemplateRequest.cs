// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateModelProviderTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The business platform to which the agent belongs. This value must be consistent with the target model group. If this parameter is not provided or an unrecognized value is passed, <c>ENTERPRISE</c> is used.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>COMMON</c>: common model group</description></item>
        /// <item><description><c>JVS</c>: JVS Claw business</description></item>
        /// <item><description><c>ENTERPRISE</c>: Enterprise Edition business</description></item>
        /// <item><description><c>ENTERPRISE_JVS</c>: Enterprise Edition JVS Computer business</description></item>
        /// <item><description><c>ENTERPRISE_SEAT</c>: Enterprise Edition seat business</description></item>
        /// <item><description><c>ENTERPRISE_AGENTIC_COMPUTER</c>: AI cloud computer business</description></item>
        /// <item><description><c>AGENTIC_COMPUTER</c>: Agentic Computer business</description></item>
        /// <item><description><c>FIXED_API_KEY</c>: fixed API key call business</description></item>
        /// </list>
        /// <para>The platform identifier does not automatically supplement the configuration capabilities or system templates for the corresponding agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent type, which must be consistent with the target model group.</para>
        /// <para>When you create a custom or managed model connection configuration, the following types are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>OpenClaw</c>: OpenClaw agent</description></item>
        /// <item><description><c>HermesAgent</c>: Hermes agent</description></item>
        /// <item><description><c>AgenticComputer</c>: Agentic Computer agent</description></item>
        /// <item><description><c>Common</c>: common model group</description></item>
        /// </list>
        /// <para>The provider configuration for <c>Common</c> uses the same field format as <c>OpenClaw</c>. The presence of an agent name in other businesses does not mean that this operation supports its model connection configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The business type, which is used to identify the business to which the model provider template belongs. Set this parameter to <c>1</c> for Enterprise Edition. This operation does not provide a default value for this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The connection configuration of the model provider, passed as a JSON string.</para>
        /// <para><b>When <c>ProviderType</c> is <c>Managed</c> or <c>Custom</c>, you must provide the service endpoint and key.</b> The field names depend on <c>AgentProvider</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>OpenClaw</c>, <c>AgenticComputer</c>, and <c>Common</c>: use <c>baseUrl</c> and <c>apiKey</c>. The protocol configuration field is <c>api</c>.</description></item>
        /// <item><description><c>HermesAgent</c>: use <c>base_url</c> and <c>api_key</c>. The protocol configuration field is <c>api_mode</c>.</description></item>
        /// </list>
        /// <para>Do not mix the two field formats. The key is encrypted and saved after creation. When <c>ProviderType</c> is <c>WuyingPlan</c> or <c>WuyingCredit</c>, the configuration is copied from the system template, and you do not need to pass this parameter.</para>
        /// <h3>Endpoint and key verification</h3>
        /// <list type="bullet">
        /// <item><description><c>Managed</c>: The service endpoint must exactly match the available endpoint configured by the platform for the provider. Bailian, Moonshot, and SiliconFlow use the provided key to request the <c>/models</c> API under the service endpoint. If the verification request fails, the creation fails and <c>ApiKey.Invalid</c> is returned. Invalid, inactive, or mismatched keys, as well as connection failures during the verification request, may trigger this error.</description></item>
        /// <item><description><c>Custom</c>: The provider name must start with <c>provider-</c>, and the service endpoint must be a valid public HTTP or HTTPS address. The preceding online key verification for the model list API is not performed during creation.</description></item>
        /// </list>
        /// <para>Other supported managed providers do not perform the preceding <c>/models</c> online verification. Successful creation does not replace actual model call verification. The keys in the examples are desensitized. You must use valid keys for actual calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;api&quot;: &quot;openai-completions&quot;,
        ///     &quot;apiKey&quot;: &quot;sk-xxxx&quot;,
        ///     &quot;baseUrl&quot;: &quot;<a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The description of the model provider template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Bailian provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Wuying secure proxy.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Yes.</description></item>
        /// <item><description><c>false</c>: No.</description></item>
        /// </list>
        /// <para>When <c>ProviderType</c> is <c>Managed</c> or <c>Custom</c>, this parameter takes effect only when the service provides proxy capabilities. If the service does not provide proxy capabilities, setting this parameter to <c>true</c> does not enable the proxy.</para>
        /// <para>When <c>ProviderType</c> is <c>WuyingPlan</c> or <c>WuyingCredit</c>, the actual proxy configuration is copied with the preset template and is not overridden by this parameter. Set this parameter to <c>true</c> when you use <c>WuyingCredit</c>. If the service requires the secure proxy to be enabled but the request is not set to <c>true</c>, <c>ModelProviderTemplate.WuyingProxyRequired</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        /// <summary>
        /// <para>The ID of the associated model group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the model provider template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Bailian</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the model provider. The name must be unique within the same model group.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>ProviderType</c> is <c>WuyingPlan</c>, set this parameter to <c>wuying-plan</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>ProviderType</c> is <c>WuyingCredit</c>, set this parameter to <c>wuying-credit</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>ProviderType</c> is <c>Custom</c>, the name must start with <c>provider-</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>ProviderType</c> is <c>Managed</c>, use one of the following provider names. <c>OpenClaw</c>, <c>AgenticComputer</c>, and <c>Common</c> use the values in the list. <c>HermesAgent</c> uses the names with the <c>wuying-</c> prefix, such as <c>wuying-bailian</c>.</para>
        /// </description></item>
        /// <item><description><para><c>bailian</c>: Alibaba Cloud Bailian</para>
        /// </description></item>
        /// <item><description><para><c>moonshot</c>: Moonshot</para>
        /// </description></item>
        /// <item><description><para><c>siliconflow</c>: SiliconFlow</para>
        /// </description></item>
        /// <item><description><para><c>bailian-coding</c>: Alibaba Cloud Bailian Coding Plan</para>
        /// </description></item>
        /// <item><description><para><c>bailian-token-plan</c>: Alibaba Cloud Bailian Token Plan</para>
        /// </description></item>
        /// <item><description><para><c>kimi-coding</c>: Kimi Coding Plan</para>
        /// </description></item>
        /// <item><description><para><c>zhipu</c>: Zhipu AI</para>
        /// </description></item>
        /// <item><description><para><c>zhipu-coding</c>: Zhipu AI Coding Plan</para>
        /// </description></item>
        /// <item><description><para><c>minimax-token-plan</c>: MiniMax Token Plan</para>
        /// </description></item>
        /// </list>
        /// <para>Whether the provider can be created also depends on whether the corresponding service endpoint and business configuration are available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>The access type of the model provider. We recommend that you explicitly pass this parameter. The value is case-sensitive.</para>
        /// <list type="bullet">
        /// <item><description><c>WuyingPlan</c>: Wuying plan model. <c>ProviderName</c> must be <c>wuying-plan</c>. The configuration is copied from the system template applicable to the current business and agent type. You do not need to provide <c>Config</c>.</description></item>
        /// <item><description><c>WuyingCredit</c>: Wuying credit package model. <c>ProviderName</c> must be <c>wuying-credit</c>. The configuration is copied from the system template. You do not need to provide <c>Config</c>. Set <c>EnableWuyingProxy</c> to <c>true</c>.</description></item>
        /// <item><description><c>Managed</c>: third-party model provider managed by the platform. You must provide <c>Config</c>, and the <c>ProviderName</c> and service endpoint must fall within the supported scope of the selected agent.</description></item>
        /// <item><description><c>Custom</c>: custom model provider. <c>ProviderName</c> must start with <c>provider-</c>. You must provide <c>Config</c>.</description></item>
        /// </list>
        /// <para><c>WuyingPlan</c> and <c>WuyingCredit</c> rely on the corresponding system templates being configured. If no template is found, <c>ModelProviderTemplate.NotFound</c> is returned. If this parameter is not provided, the preceding plan or credit package configuration is not automatically adopted.</para>
        /// <para><c>WuyingPreset</c> indicates the system-preset intelligent models in the common model group. Do not mistake it for the template copying method of <c>WuyingPlan</c> or <c>WuyingCredit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateAttackTargetRequest : TeaModel {
        /// <summary>
        /// <para>The API key for the target model service, used to authenticate with the endpoint. The key is encrypted and stored after submission. Subsequent queries do not return the plaintext value. When ConnectionMethod is set to enterprise_relay, the actual credentials are held by the corporate internal network agent. Transmit the key over HTTPS and avoid exposing it in plaintext in logs, URLs, or client code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-abcd1234****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The advanced connection configuration in JSON string format. Common fields: authType (authentication type. custom_header: custom request header authentication. none: no authentication), customAuthHeaderName (custom authentication header name, such as X-API-Key), and requestHeaders (additional HTTP request header key-value pairs).</para>
        /// <para>Common provider configuration templates ({{prompt}} is a prompt placeholder that you replace with the actual service value. When authType is set to bearer, the token is injected from ApiKey and the template does not contain credentials):</para>
        /// <list type="bullet">
        /// <item><description>Bailian: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;input\&quot;:{\&quot;prompt\&quot;:\&quot;{{prompt}}\&quot;},\&quot;parameters\&quot;:{\&quot;incremental_output\&quot;:true},\&quot;debug\&quot;:{}}&quot;,&quot;messageJsonPath&quot;:&quot;$.output.text&quot;,&quot;requestHeaders&quot;:&quot;{\&quot;X-DashScope-SSE\&quot;: \&quot;enable\&quot; }&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>PAI: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:60000,&quot;requestTemplate&quot;:&quot;{\&quot;inputs\&quot;:{\&quot;question\&quot;:\&quot;{{prompt}}\&quot;,\&quot;chat_history\&quot;:[]},\&quot;stream\&quot;:true}&quot;,&quot;messageJsonPath&quot;:&quot;$.outputs.answer&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>Dify: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;inputs\&quot;:{},\&quot;query\&quot;:\&quot;{{prompt}}\&quot;,\&quot;response_mode\&quot;:\&quot;streaming\&quot;,\&quot;conversation_id\&quot;:\&quot;\&quot;,\&quot;user\&quot;:\&quot;scanner\&quot;}&quot;,&quot;messageJsonPath&quot;:&quot;$.answer&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>AgentRun: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;custom_header&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;{{prompt}}\&quot;}],\&quot;stream\&quot;:true}&quot;,&quot;messageJsonPath&quot;:&quot;$.choices[0].delta.content&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;customAuthHeaderName&quot;:&quot;X-API-Key&quot;,&quot;stream&quot;:true}</description></item>
        /// <item><description>AgentKit: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;{{prompt}}\&quot;}]}&quot;,&quot;messageJsonPath&quot;:&quot;$.content.parts[0].text&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}
        /// When ConnectionMethod is set to enterprise_relay, you can use the protocol field to specify the tunnel protocol (defaults to openai). The provider configuration templates above apply only to non-enterprise_relay connections.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;httpMethod\&quot;:\&quot;POST\&quot;,\&quot;authType\&quot;:\&quot;bearer\&quot;,\&quot;timeoutMs\&quot;:30000,\&quot;requestTemplate\&quot;:\&quot;{\\\&quot;input\\\&quot;:{\\\&quot;prompt\\\&quot;:\\\&quot;{{prompt}}\\\&quot;},\\\&quot;parameters\\\&quot;:{\\\&quot;incremental_output\\\&quot;:true},\\\&quot;debug\\\&quot;:{}}\&quot;,\&quot;messageJsonPath\&quot;:\&quot;$.output.text\&quot;,\&quot;requestHeaders\&quot;:\&quot;{\\\&quot;X-DashScope-SSE\\\&quot;: \\\&quot;enable\\\&quot; }\&quot;,\&quot;stream\&quot;:true,\&quot;customAuthHeaderName\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionConfig")]
        [Validation(Required=false)]
        public string ConnectionConfig { get; set; }

        /// <summary>
        /// <para>The connection protocol type for the target service. The system selects the corresponding protocol adapter based on this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("ConnectionMethod")]
        [Validation(Required=false)]
        public string ConnectionMethod { get; set; }

        /// <summary>
        /// <para>An optional description of the scan target usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bailian application in the production environment</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS endpoint address of the target model service. When ConnectionMethod is set to enterprise_relay, this value is ignored and the platform uses a fixed internal endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The name of the target model. When ConnectionMethod is set to openai, specify the model ID under the OpenAI compatible protocol. When ConnectionMethod is set to anthropic, specify the model ID for the Anthropic Messages API. When ConnectionMethod is set to enterprise_relay, this value is ignored and the platform uses a fixed value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-flash</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The business label of the model or agent provider, used for UI filtering and form display. This is decoupled from ConnectionMethod (technical protocol): the same Provider may use multiple protocols, and vice versa.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The display name of the scan target, used for list display and filtering. Use a distinguishable name within the same tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Bailian Target</para>
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// <para>The type of the scan target, which determines the sampling dimension for scan tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>agent: agent-type samples.</description></item>
        /// <item><description>model: model-type samples.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}

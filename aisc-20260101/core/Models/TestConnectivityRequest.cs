// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class TestConnectivityRequest : TeaModel {
        /// <summary>
        /// <para>The API key for the target model service, used to authenticate with the Endpoint. If TargetId is specified, the system reads the key from the encrypted target configuration. This parameter is required if TargetId is empty. Transmit the key over HTTPS and avoid exposing it in plaintext in logs, URLs, or client code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-abcd1234****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The tracking identifier of the connectivity test. Do not specify this parameter for the first call. The system generates and returns it in the response. For subsequent calls, specify this value to query the latest status of the corresponding test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn-a1b2c3d4e5f67890</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <para>The advanced connection configuration in JSON string format. Common fields: authType (authentication type. custom_header indicates custom request header authentication. none indicates no authentication), customAuthHeaderName (custom authentication header name, such as X-API-Key), and requestHeaders (additional HTTP request header key-value pairs).</para>
        /// <para>Common provider configuration templates ({{prompt}} is the prompt placeholder. Replace it with the actual service value. When authType is set to bearer, the token is injected from ApiKey, and the template does not contain credentials):</para>
        /// <list type="bullet">
        /// <item><description>Bailian: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;input\&quot;:{\&quot;prompt\&quot;:\&quot;{{prompt}}\&quot;},\&quot;parameters\&quot;:{\&quot;incremental_output\&quot;:true},\&quot;debug\&quot;:{}}&quot;,&quot;messageJsonPath&quot;:&quot;$.output.text&quot;,&quot;requestHeaders&quot;:&quot;{\&quot;X-DashScope-SSE\&quot;: \&quot;enable\&quot; }&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>PAI: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:60000,&quot;requestTemplate&quot;:&quot;{\&quot;inputs\&quot;:{\&quot;question\&quot;:\&quot;{{prompt}}\&quot;,\&quot;chat_history\&quot;:[]},\&quot;stream\&quot;:true}&quot;,&quot;messageJsonPath&quot;:&quot;$.outputs.answer&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>Dify: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;inputs\&quot;:{},\&quot;query\&quot;:\&quot;{{prompt}}\&quot;,\&quot;response_mode\&quot;:\&quot;streaming\&quot;,\&quot;conversation_id\&quot;:\&quot;\&quot;,\&quot;user\&quot;:\&quot;scanner\&quot;}&quot;,&quot;messageJsonPath&quot;:&quot;$.answer&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// <item><description>AgentRun: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;custom_header&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;{{prompt}}\&quot;}],\&quot;stream\&quot;:true}&quot;,&quot;messageJsonPath&quot;:&quot;$.choices[0].delta.content&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;customAuthHeaderName&quot;:&quot;X-API-Key&quot;,&quot;stream&quot;:true}</description></item>
        /// <item><description>AgentKit: {&quot;httpMethod&quot;:&quot;POST&quot;,&quot;authType&quot;:&quot;bearer&quot;,&quot;timeoutMs&quot;:30000,&quot;requestTemplate&quot;:&quot;{\&quot;messages\&quot;:[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;{{prompt}}\&quot;}]}&quot;,&quot;messageJsonPath&quot;:&quot;$.content.parts[0].text&quot;,&quot;requestHeaders&quot;:&quot;&quot;,&quot;stream&quot;:true,&quot;customAuthHeaderName&quot;:&quot;&quot;}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;httpMethod\&quot;:\&quot;POST\&quot;,\&quot;authType\&quot;:\&quot;bearer\&quot;,\&quot;timeoutMs\&quot;:30000,\&quot;requestTemplate\&quot;:\&quot;{\\\&quot;input\\\&quot;:{\\\&quot;prompt\\\&quot;:\\\&quot;{{prompt}}\\\&quot;},\\\&quot;parameters\\\&quot;:{\\\&quot;incremental_output\\\&quot;:true},\\\&quot;debug\\\&quot;:{}}\&quot;,\&quot;messageJsonPath\&quot;:\&quot;$.output.text\&quot;,\&quot;requestHeaders\&quot;:\&quot;{\\\&quot;X-DashScope-SSE\\\&quot;: \\\&quot;enable\\\&quot; }\&quot;,\&quot;stream\&quot;:true,\&quot;customAuthHeaderName\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionConfig")]
        [Validation(Required=false)]
        public string ConnectionConfig { get; set; }

        /// <summary>
        /// <para>The connection protocol type of the target service. The system selects the corresponding protocol adapter to initiate the test based on this value. Default value: openai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("ConnectionMethod")]
        [Validation(Required=false)]
        public string ConnectionMethod { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS endpoint address of the target model service. This parameter is required if TargetId is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The name of the target model. If ConnectionMethod is set to openai, specify the model ID under the OpenAI compatible protocol. If ConnectionMethod is set to anthropic, specify the model ID for the Anthropic Messages API. This parameter is required if the scan target is a model and TargetId is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-flash</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the attack target. If specified, the system reads Endpoint, ApiKey, ModelName, ConnectionMethod, and ConnectionConfig from the target configuration and ignores any parameters with the same names in the request. If not specified, provide the connection parameters directly in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-abc123def4567</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}

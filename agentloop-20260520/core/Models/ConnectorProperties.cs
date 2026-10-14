// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ConnectorProperties : TeaModel {
        /// <summary>
        /// <para>The channel type. Valid values: custom and apig. This parameter is optional for model_service. Default value: custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>Specifies the sample request body provided by the user to verify endpoint connectivity. This parameter is required when dryRun is set to All and type is set to agent_app. The request body is not persisted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;input&quot;:&quot;Hello&quot;}</para>
        /// </summary>
        [NameInMap("dryRunRequestBody")]
        [Validation(Required=false)]
        public string DryRunRequestBody { get; set; }

        /// <summary>
        /// <para>The number of retry attempts after a failed service invocation when you invoke the synthetic monitoring registration service. Valid values: 0 to 10. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public string MaxRetries { get; set; }

        /// <summary>
        /// <para>The list of supported models in comma-separated format. This parameter is required for model_service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public string ModelList { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: internet and aliyun-vpc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values: openai, openai-compatible, and anthropic. This parameter is required for model_service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai-compatible</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The queries per second (QPS) limit for the dial test registration service. A value of 0 indicates no throttling. Otherwise, valid values are 0.1 to 1000. Default value: 20 for agent_app and 100 for model_service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("qpsLimit")]
        [Validation(Required=false)]
        public string QpsLimit { get; set; }

        /// <summary>
        /// <para>The region. This parameter is required when the network type is aliyun-vpc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The JSONPath extraction path for the response body. This parameter is optional for agent_app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$.choices[0].message.content</para>
        /// </summary>
        [NameInMap("responseBodyPath")]
        [Validation(Required=false)]
        public string ResponseBodyPath { get; set; }

        /// <summary>
        /// <para>The ID of the security group. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The timeout period for a single call in milliseconds. Valid values: 1000 to 1800000. Default value: 300000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("timeoutMs")]
        [Validation(Required=false)]
        public string TimeoutMs { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

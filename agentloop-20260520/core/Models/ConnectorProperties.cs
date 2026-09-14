// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ConnectorProperties : TeaModel {
        /// <summary>
        /// <para>The channel type: custom or apig. This parameter is optional for model_service and defaults to custom.</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The sample request body provided by the user for verifying endpoint connectivity. This parameter is required when dryRun is set to All and type is set to agent_app. The value is not persisted.</para>
        /// </summary>
        [NameInMap("dryRunRequestBody")]
        [Validation(Required=false)]
        public string DryRunRequestBody { get; set; }

        /// <summary>
        /// <para>The number of retries after a failed invocation of the dial-test registration service. Valid values: 0 to 10. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public string MaxRetries { get; set; }

        /// <summary>
        /// <para>The list of supported models in comma-separated format. This parameter is required for model_service.</para>
        /// </summary>
        [NameInMap("modelList")]
        [Validation(Required=false)]
        public string ModelList { get; set; }

        /// <summary>
        /// <para>The network type: internet or aliyun-vpc.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The protocol type: openai, openai-compatible, or anthropic. This parameter is required for model_service.</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The QPS limit for the dial-test registration service. A value of 0 indicates no throttling. Otherwise, valid values: 0.1 to 1000. Default value: 20 for agent_app, 100 for model_service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("qpsLimit")]
        [Validation(Required=false)]
        public string QpsLimit { get; set; }

        /// <summary>
        /// <para>The region. This parameter is required when the network type is aliyun-vpc.</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The JSON Path extraction path for the response body. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("responseBodyPath")]
        [Validation(Required=false)]
        public string ResponseBodyPath { get; set; }

        /// <summary>
        /// <para>The security group ID. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The timeout for a single call, in milliseconds. Valid values: 1000 to 1800000. Default value: 300000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("timeoutMs")]
        [Validation(Required=false)]
        public string TimeoutMs { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID. This parameter is optional for agent_app.</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentServiceConfig : TeaModel {
        /// <summary>
        /// <para>The address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/api/v1">https://dashscope.aliyuncs.com/api/v1</a></para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The custom configuration. Required when provider is set to custom.</para>
        /// </summary>
        [NameInMap("customConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigCustomConfig CustomConfig { get; set; }
        public class AgentServiceConfigCustomConfig : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-xxx</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The key generation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reference</para>
            /// </summary>
            [NameInMap("apiKeyGenerateMode")]
            [Validation(Required=false)]
            public string ApiKeyGenerateMode { get; set; }

        }

        /// <summary>
        /// <para>The DashScope service configuration. Required when provider is set to qwen. The appCredentials parameter cannot be empty, and each entry must have non-empty appId and apiKey values.</para>
        /// </summary>
        [NameInMap("dashScopeConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigDashScopeConfig DashScopeConfig { get; set; }
        public class AgentServiceConfigDashScopeConfig : TeaModel {
            /// <summary>
            /// <para>The application configuration.</para>
            /// </summary>
            [NameInMap("appCredentials")]
            [Validation(Required=false)]
            public List<AgentServiceConfigDashScopeConfigAppCredentials> AppCredentials { get; set; }
            public class AgentServiceConfigDashScopeConfigAppCredentials : TeaModel {
                /// <summary>
                /// <para>apiKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-xxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-xxx</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

            }

        }

        /// <summary>
        /// <para>The Dify service configuration. Required when provider is set to dify. The botType and apiKey parameters cannot be empty.</para>
        /// </summary>
        [NameInMap("difyConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigDifyConfig DifyConfig { get; set; }
        public class AgentServiceConfigDifyConfig : TeaModel {
            /// <summary>
            /// <para>API Key</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-xxx</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The interaction type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatflow</para>
            /// </summary>
            [NameInMap("botType")]
            [Validation(Required=false)]
            public string BotType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable outlier detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableOutlierDetection")]
        [Validation(Required=false)]
        public bool? EnableOutlierDetection { get; set; }

        /// <summary>
        /// <para>The list of communication protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>The service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}

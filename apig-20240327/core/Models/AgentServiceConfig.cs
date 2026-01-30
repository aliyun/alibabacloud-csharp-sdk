// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentServiceConfig : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dashscope.aliyuncs.com/api/v1">https://dashscope.aliyuncs.com/api/v1</a></para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("customConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigCustomConfig CustomConfig { get; set; }
        public class AgentServiceConfigCustomConfig : TeaModel {
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("apiKeyGenerateMode")]
            [Validation(Required=false)]
            public string ApiKeyGenerateMode { get; set; }

        }

        [NameInMap("dashScopeConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigDashScopeConfig DashScopeConfig { get; set; }
        public class AgentServiceConfigDashScopeConfig : TeaModel {
            [NameInMap("appCredentials")]
            [Validation(Required=false)]
            public List<AgentServiceConfigDashScopeConfigAppCredentials> AppCredentials { get; set; }
            public class AgentServiceConfigDashScopeConfigAppCredentials : TeaModel {
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

            }

        }

        [NameInMap("difyConfig")]
        [Validation(Required=false)]
        public AgentServiceConfigDifyConfig DifyConfig { get; set; }
        public class AgentServiceConfigDifyConfig : TeaModel {
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            [NameInMap("botType")]
            [Validation(Required=false)]
            public string BotType { get; set; }

        }

        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        [NameInMap("enableOutlierDetection")]
        [Validation(Required=false)]
        public bool? EnableOutlierDetection { get; set; }

        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}

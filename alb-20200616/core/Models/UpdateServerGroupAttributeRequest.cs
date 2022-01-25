// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateServerGroupAttributeRequest : TeaModel {
        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        ///  是否只预检此次请求
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 健康检查配置
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }
        };

        /// <summary>
        /// 调度策略
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// 服务器组Id
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// Acl名称
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// 服务器名称
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 会话保持配置
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestStickySessionConfig StickySessionConfig { get; set; }
        public class UpdateServerGroupAttributeRequestStickySessionConfig : TeaModel {
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }
            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }
            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }
        };

    }

}

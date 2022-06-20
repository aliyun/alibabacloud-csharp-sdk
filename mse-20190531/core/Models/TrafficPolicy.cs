// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class TrafficPolicy : TeaModel {
        /// <summary>
        /// 负载均衡相关配置
        /// </summary>
        [NameInMap("LoadBalancerSettings")]
        [Validation(Required=false)]
        public TrafficPolicyLoadBalancerSettings LoadBalancerSettings { get; set; }
        public class TrafficPolicyLoadBalancerSettings : TeaModel {
            [NameInMap("ConsistentHashLBConfig")]
            [Validation(Required=false)]
            public TrafficPolicyLoadBalancerSettingsConsistentHashLBConfig ConsistentHashLBConfig { get; set; }
            public class TrafficPolicyLoadBalancerSettingsConsistentHashLBConfig : TeaModel {
                /// <summary>
                /// HEADER, COOKIE, SOURCE_IP, QUERY_PARAMETER
                /// </summary>
                [NameInMap("ConsistentHashLBType")]
                [Validation(Required=false)]
                public string ConsistentHashLBType { get; set; }

                /// <summary>
                /// 使用cookie时配置
                /// </summary>
                [NameInMap("HttpCookie")]
                [Validation(Required=false)]
                public TrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie HttpCookie { get; set; }
                public class TrafficPolicyLoadBalancerSettingsConsistentHashLBConfigHttpCookie : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }
                    [NameInMap("TTL")]
                    [Validation(Required=false)]
                    public string TTL { get; set; }
                };

                /// <summary>
                /// 使用根据header和参数路由时生效
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }
            [NameInMap("LoadbalancerType")]
            [Validation(Required=false)]
            public string LoadbalancerType { get; set; }
            [NameInMap("WarmupDuration")]
            [Validation(Required=false)]
            public long? WarmupDuration { get; set; }
        };

        /// <summary>
        /// tls相关配置
        /// </summary>
        [NameInMap("TlsSetting")]
        [Validation(Required=false)]
        public TrafficPolicyTlsSetting TlsSetting { get; set; }
        public class TrafficPolicyTlsSetting : TeaModel {
            [NameInMap("CaCertContent")]
            [Validation(Required=false)]
            public string CaCertContent { get; set; }
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }
            [NameInMap("Sni")]
            [Validation(Required=false)]
            public string Sni { get; set; }
            [NameInMap("TlsMode")]
            [Validation(Required=false)]
            public string TlsMode { get; set; }
        };

    }

}

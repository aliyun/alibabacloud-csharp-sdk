// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class TrafficPolicy : TeaModel {
        [NameInMap("LoadBalancerSettings")]
        [Validation(Required=false)]
        public TrafficPolicyLoadBalancerSettings LoadBalancerSettings { get; set; }
        public class TrafficPolicyLoadBalancerSettings : TeaModel {
            [NameInMap("ConsistentHashLBConfig")]
            [Validation(Required=false)]
            public TrafficPolicyLoadBalancerSettingsConsistentHashLBConfig ConsistentHashLBConfig { get; set; }
            public class TrafficPolicyLoadBalancerSettingsConsistentHashLBConfig : TeaModel {
                [NameInMap("ConsistentHashLBType")]
                [Validation(Required=false)]
                public string ConsistentHashLBType { get; set; }

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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0s</para>
                    /// </summary>
                    [NameInMap("TTL")]
                    [Validation(Required=false)]
                    public string TTL { get; set; }

                }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RANDOM</para>
            /// </summary>
            [NameInMap("LoadbalancerType")]
            [Validation(Required=false)]
            public string LoadbalancerType { get; set; }

            [NameInMap("WarmupDuration")]
            [Validation(Required=false)]
            public long? WarmupDuration { get; set; }

        }

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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("TlsMode")]
            [Validation(Required=false)]
            public string TlsMode { get; set; }

        }

    }

}

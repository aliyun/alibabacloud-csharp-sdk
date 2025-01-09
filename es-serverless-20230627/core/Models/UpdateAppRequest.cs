// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateAppRequest : TeaModel {
        [NameInMap("applyReason")]
        [Validation(Required=false)]
        public string ApplyReason { get; set; }

        [NameInMap("authentication")]
        [Validation(Required=false)]
        public UpdateAppRequestAuthentication Authentication { get; set; }
        public class UpdateAppRequestAuthentication : TeaModel {
            [NameInMap("basicAuth")]
            [Validation(Required=false)]
            public List<UpdateAppRequestAuthenticationBasicAuth> BasicAuth { get; set; }
            public class UpdateAppRequestAuthenticationBasicAuth : TeaModel {
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("contactInfo")]
        [Validation(Required=false)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// <para>应用备注</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("limiterInfo")]
        [Validation(Required=false)]
        public UpdateAppRequestLimiterInfo LimiterInfo { get; set; }
        public class UpdateAppRequestLimiterInfo : TeaModel {
            [NameInMap("limiters")]
            [Validation(Required=false)]
            public List<UpdateAppRequestLimiterInfoLimiters> Limiters { get; set; }
            public class UpdateAppRequestLimiterInfoLimiters : TeaModel {
                [NameInMap("maxValue")]
                [Validation(Required=false)]
                public int? MaxValue { get; set; }

                [NameInMap("minValue")]
                [Validation(Required=false)]
                public int? MinValue { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        [NameInMap("network")]
        [Validation(Required=false)]
        public List<UpdateAppRequestNetwork> Network { get; set; }
        public class UpdateAppRequestNetwork : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("whiteIpGroup")]
            [Validation(Required=false)]
            public List<UpdateAppRequestNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
            public class UpdateAppRequestNetworkWhiteIpGroup : TeaModel {
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

            }

        }

        [NameInMap("privateNetwork")]
        [Validation(Required=false)]
        public List<UpdateAppRequestPrivateNetwork> PrivateNetwork { get; set; }
        public class UpdateAppRequestPrivateNetwork : TeaModel {
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("pvlEndpointId")]
            [Validation(Required=false)]
            public string PvlEndpointId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("whiteIpGroup")]
            [Validation(Required=false)]
            public List<UpdateAppRequestPrivateNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
            public class UpdateAppRequestPrivateNetworkWhiteIpGroup : TeaModel {
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

            }

        }

    }

}

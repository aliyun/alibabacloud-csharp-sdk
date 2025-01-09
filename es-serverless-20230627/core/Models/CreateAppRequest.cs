// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// <para>应用名</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authentication")]
        [Validation(Required=false)]
        public CreateAppRequestAuthentication Authentication { get; set; }
        public class CreateAppRequestAuthentication : TeaModel {
            [NameInMap("basicAuth")]
            [Validation(Required=false)]
            public List<CreateAppRequestAuthenticationBasicAuth> BasicAuth { get; set; }
            public class CreateAppRequestAuthenticationBasicAuth : TeaModel {
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>应用备注</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public List<CreateAppRequestNetwork> Network { get; set; }
        public class CreateAppRequestNetwork : TeaModel {
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
            public List<CreateAppRequestNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
            public class CreateAppRequestNetworkWhiteIpGroup : TeaModel {
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
        public List<CreateAppRequestPrivateNetwork> PrivateNetwork { get; set; }
        public class CreateAppRequestPrivateNetwork : TeaModel {
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
            public List<CreateAppRequestPrivateNetworkWhiteIpGroup> WhiteIpGroup { get; set; }
            public class CreateAppRequestPrivateNetworkWhiteIpGroup : TeaModel {
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ips")]
                [Validation(Required=false)]
                public List<string> Ips { get; set; }

            }

        }

        [NameInMap("quotaInfo")]
        [Validation(Required=false)]
        public CreateAppRequestQuotaInfo QuotaInfo { get; set; }
        public class CreateAppRequestQuotaInfo : TeaModel {
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            [NameInMap("storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

        }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The attribute information about the bastion host.
        /// </summary>
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            [NameInMap("AuthorizedSecurityGroups")]
            [Validation(Required=false)]
            public List<string> AuthorizedSecurityGroups { get; set; }

            /// <summary>
            /// The total bandwidth of the bastion host.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// The extra bandwidth plan of the bastion host.
            /// </summary>
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public string BandwidthPackage { get; set; }

            [NameInMap("DbOperationModule")]
            [Validation(Required=false)]
            public string DbOperationModule { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            [NameInMap("ModifyPasswordModule")]
            [Validation(Required=false)]
            public string ModifyPasswordModule { get; set; }

            [NameInMap("NetworkProxyModule")]
            [Validation(Required=false)]
            public string NetworkProxyModule { get; set; }

            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// The custom port.
                /// 
                /// >  You can change only the SSH and RDP ports. If O\&M ports are not specified, the value of the StandardPort parameter is returned.
                /// </summary>
                [NameInMap("CustomPort")]
                [Validation(Required=false)]
                public int? CustomPort { get; set; }

                /// <summary>
                /// The standard port of the bastion host. Valid values:
                /// 
                /// *   **SSH**: 60022
                /// *   **RDP**: 63389
                /// *   **HTTPS**: 443
                /// </summary>
                [NameInMap("StandardPort")]
                [Validation(Required=false)]
                public int? StandardPort { get; set; }

            }

            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("WebTerminalModule")]
            [Validation(Required=false)]
            public string WebTerminalModule { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

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
            /// <summary>
            /// An array that consists of the IDs of authorized security groups.
            /// </summary>
            [NameInMap("AuthorizedSecurityGroups")]
            [Validation(Required=false)]
            public List<string> AuthorizedSecurityGroups { get; set; }

            /// <summary>
            /// The status of the database O\&M feature.
            /// </summary>
            [NameInMap("DbOperationModule")]
            [Validation(Required=false)]
            public string DbOperationModule { get; set; }

            /// <summary>
            /// The remarks of the bastion host.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the elastic network interface (ENI).
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// The time when the bastion host expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The ID of the bastion host.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the bastion host. Valid values:
            /// 
            /// *   **PENDING**: The bastion host is not initialized.
            /// *   **CREATING**: The bastion host is being created.
            /// *   **RUNNING**: The bastion host is running.
            /// *   **EXPIRED**: The bastion host expired.
            /// *   **CREATE_FAILED**: The bastion host fails to be created.
            /// *   **UPGRADING**: The configurations of the bastion host are being changed.
            /// *   **UPGRADE_FAILED**: The configurations of the bastion host fail to be changed.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The public endpoint of the bastion host.
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// The internal endpoint of the bastion host.
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// The license code.
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// The status of the automatic password change feature.
            /// 
            /// *   **Enable**
            /// *   **Disable**
            /// </summary>
            [NameInMap("ModifyPasswordModule")]
            [Validation(Required=false)]
            public string ModifyPasswordModule { get; set; }

            /// <summary>
            /// The status of the network domain feature.
            /// 
            /// *   **Enable**
            /// *   **Disable**
            /// </summary>
            [NameInMap("NetworkProxyModule")]
            [Validation(Required=false)]
            public string NetworkProxyModule { get; set; }

            /// <summary>
            /// An array that consists of the O\&M ports of the bastion host.
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// The custom port.
                /// 
                /// > : You can change only the SSH and RDP ports. If O\&M ports are not specified, the value of the StandardPort parameter is returned.
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

            /// <summary>
            /// An array that consists of the egress private IP addresses of the bastion host.
            /// </summary>
            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            /// <summary>
            /// An array that consists of private IP addresses in a whitelist for the bastion host.
            /// </summary>
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            /// <summary>
            /// An array that consists of the egress public IP addresses of the bastion host.
            /// </summary>
            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            /// <summary>
            /// An array that consists of the public IP addresses of the bastion host.
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            /// <summary>
            /// Indicates whether the bastion host can be accessed over the Internet.
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// An array that consists of public IP addresses in a whitelist for the bastion host.
            /// </summary>
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

            /// <summary>
            /// The ID of the region in which the bastion host resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the bastion host belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// An array that consists of the IDs of the security groups to which the bastion host belongs.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The time when the bastion host was purchased.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The storage capacity of the bastion host.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the bastion host belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the bastion host belongs.
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// The status of the web terminal.
            /// 
            /// *   **Enable**
            /// *   **Disable**
            /// </summary>
            [NameInMap("WebTerminalModule")]
            [Validation(Required=false)]
            public string WebTerminalModule { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

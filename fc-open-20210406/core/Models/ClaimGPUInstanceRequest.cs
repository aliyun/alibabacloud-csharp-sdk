// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ClaimGPUInstanceRequest : TeaModel {
        /// <summary>
        /// The disk performance level of the GPU rendering instance.
        /// </summary>
        [NameInMap("diskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// The system disk space of the GPU rendering instance. Unit: GB.
        /// </summary>
        [NameInMap("diskSizeGigabytes")]
        [Validation(Required=false)]
        public string DiskSizeGigabytes { get; set; }

        /// <summary>
        /// The image ID of the GPU rendering instance.
        /// </summary>
        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The specifications of the GPU rendering instance.
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The outbound Internet bandwidth of the GPU rendering instance.
        /// </summary>
        [NameInMap("internetBandwidthOut")]
        [Validation(Required=false)]
        public string InternetBandwidthOut { get; set; }

        /// <summary>
        /// The password of the GPU rendering instance.
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The user role.
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The security group ID.
        /// </summary>
        [NameInMap("sgId")]
        [Validation(Required=false)]
        public string SgId { get; set; }

        /// <summary>
        /// The source IPv4 CIDR block of the GPU rendering instance.
        /// </summary>
        [NameInMap("sourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// The range of TCP ports that are open to the security group of the GPU rendering instance.
        /// </summary>
        [NameInMap("tcpPortRange")]
        [Validation(Required=false)]
        public List<string> TcpPortRange { get; set; }

        /// <summary>
        /// The range of UDP ports that are open to the security group of the GPU rendering instance.
        /// </summary>
        [NameInMap("udpPortRange")]
        [Validation(Required=false)]
        public List<string> UdpPortRange { get; set; }

        /// <summary>
        /// The ID of the VPC in which the instance resides.
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The vSwitch ID of the instance.
        /// </summary>
        [NameInMap("vswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

    }

}

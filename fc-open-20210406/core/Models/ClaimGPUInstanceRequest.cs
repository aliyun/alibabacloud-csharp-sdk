// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ClaimGPUInstanceRequest : TeaModel {
        [NameInMap("diskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        [NameInMap("diskSizeGigabytes")]
        [Validation(Required=false)]
        public string DiskSizeGigabytes { get; set; }

        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("internetBandwidthOut")]
        [Validation(Required=false)]
        public string InternetBandwidthOut { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("sgId")]
        [Validation(Required=false)]
        public string SgId { get; set; }

        [NameInMap("sourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        [NameInMap("tcpPortRange")]
        [Validation(Required=false)]
        public List<string> TcpPortRange { get; set; }

        [NameInMap("udpPortRange")]
        [Validation(Required=false)]
        public List<string> UdpPortRange { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vswId")]
        [Validation(Required=false)]
        public string VswId { get; set; }

    }

}

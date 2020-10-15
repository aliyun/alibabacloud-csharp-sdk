// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("InstanceType")]
        [Validation(Required=true)]
        public string InstanceType { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=true)]
        public string EnsRegionId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Period")]
        [Validation(Required=true)]
        public string Period { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateInstanceRequestSystemDisk SystemDisk { get; set; }
        public class CreateInstanceRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=true)]
            public string Size { get; set; }
        };

        [NameInMap("Quantity")]
        [Validation(Required=true)]
        public string Quantity { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestDataDisk> DataDisk { get; set; }
        public class CreateInstanceRequestDataDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=true)]
            public string Size { get; set; }

        }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

    }

}

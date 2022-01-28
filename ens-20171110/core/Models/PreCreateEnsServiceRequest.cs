// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreCreateEnsServiceRequest : TeaModel {
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        [NameInMap("BuyResourcesDetail")]
        [Validation(Required=false)]
        public string BuyResourcesDetail { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public string DataDiskSize { get; set; }

        [NameInMap("EnsServiceName")]
        [Validation(Required=false)]
        public string EnsServiceName { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InstanceBandwithdLimit")]
        [Validation(Required=false)]
        public string InstanceBandwithdLimit { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("NetLevel")]
        [Validation(Required=false)]
        public string NetLevel { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("SchedulingPriceStrategy")]
        [Validation(Required=false)]
        public string SchedulingPriceStrategy { get; set; }

        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public string SystemDiskSize { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

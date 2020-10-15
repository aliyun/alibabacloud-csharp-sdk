// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreCreateEnsServiceRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("EnsServiceName")]
        [Validation(Required=true)]
        public string EnsServiceName { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

        [NameInMap("InstanceSpec")]
        [Validation(Required=true)]
        public string InstanceSpec { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=true)]
        public string SystemDiskSize { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public string DataDiskSize { get; set; }

        [NameInMap("BandwidthType")]
        [Validation(Required=true)]
        public string BandwidthType { get; set; }

        [NameInMap("InstanceBandwithdLimit")]
        [Validation(Required=true)]
        public string InstanceBandwithdLimit { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("NetLevel")]
        [Validation(Required=true)]
        public string NetLevel { get; set; }

        [NameInMap("SchedulingStrategy")]
        [Validation(Required=true)]
        public string SchedulingStrategy { get; set; }

        [NameInMap("SchedulingPriceStrategy")]
        [Validation(Required=false)]
        public string SchedulingPriceStrategy { get; set; }

        [NameInMap("BuyResourcesDetail")]
        [Validation(Required=true)]
        public string BuyResourcesDetail { get; set; }

    }

}

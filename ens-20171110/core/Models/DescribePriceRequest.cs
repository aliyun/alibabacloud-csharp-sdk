// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceRequest : TeaModel {
        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=true)]
        public string InstanceType { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=true)]
        public string EnsRegionId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=true)]
        public int? Period { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=true)]
            public int? Size { get; set; }
        };

        [NameInMap("Quantity")]
        [Validation(Required=true)]
        public int? Quantity { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceRequestDataDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=true)]
            public int? Size { get; set; }

        }

        [NameInMap("InternetChargeType")]
        [Validation(Required=true)]
        public string InternetChargeType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceShrinkRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceShrinkRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceShrinkRequestDataDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceShrinkRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceShrinkRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public string DataDisksShrink { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

    }

}

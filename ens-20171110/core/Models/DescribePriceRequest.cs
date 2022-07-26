// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceRequestDataDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
        };

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisks> DataDisks { get; set; }
        public class DescribePriceRequestDataDisks : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

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

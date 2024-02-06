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
            /// <summary>
            /// The size of the data disk. Unit: GB. If you specify this parameter, this parameter takes precedence over the Size property in DataDisks.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// The size of the system disk. Unit: GB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// If you leave DataDisk.1.Size empty, the value that you specified for this parameter is used.
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisks> DataDisks { get; set; }
        public class DescribePriceRequestDataDisks : TeaModel {
            /// <summary>
            /// The category of the disk.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// The ID of the ENS node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The type of the instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The bandwidth metering method of the instance. Valid values:
        /// 
        /// *   BandwidthByDay: Pay by daily peak bandwidth
        /// *   95BandwidthByMonth: Pay by monthly 95th percentile bandwidth
        /// *   PayByBandwidth4thMonth: Pay by monthly fourth peak bandwidth
        /// *   PayByBandwidth: Pay by fixed bandwidth
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The subscription duration of the instance.
        /// 
        /// *   If you leave the PeriodUnit parameter empty, the instance is purchased on a monthly basis. Valid values: Day and Month.
        /// *   If you set PeriodUnit to Day, you can set Period only to 3.
        /// *   If you set PeriodUnit to Month, you can set Period to a number from 1 to 9, or set Period to 12.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The billing cycle of the ENS instance. Valid values:
        /// 
        /// *   Month (default):
        /// *   Day
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The number of instances.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

    }

}

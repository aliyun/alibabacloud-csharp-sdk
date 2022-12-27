// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNCInformationResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNCInformationResponseBodyData> Data { get; set; }
        public class DescribeNCInformationResponseBodyData : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataCpu Cpu { get; set; }
            public class DescribeNCInformationResponseBodyDataCpu : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataGpu Gpu { get; set; }
            public class DescribeNCInformationResponseBodyDataGpu : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Hdd")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataHdd Hdd { get; set; }
            public class DescribeNCInformationResponseBodyDataHdd : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataInfo Info { get; set; }
            public class DescribeNCInformationResponseBodyDataInfo : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataMemory Memory { get; set; }
            public class DescribeNCInformationResponseBodyDataMemory : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Nvme")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataNvme Nvme { get; set; }
            public class DescribeNCInformationResponseBodyDataNvme : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Ssd")]
            [Validation(Required=false)]
            public DescribeNCInformationResponseBodyDataSsd Ssd { get; set; }
            public class DescribeNCInformationResponseBodyDataSsd : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("OversellRatio")]
                [Validation(Required=false)]
                public long? OversellRatio { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public long? Remain { get; set; }

                [NameInMap("ReserveDisable")]
                [Validation(Required=false)]
                public bool? ReserveDisable { get; set; }

                [NameInMap("ReserveDisableTotal")]
                [Validation(Required=false)]
                public long? ReserveDisableTotal { get; set; }

                [NameInMap("Reserved")]
                [Validation(Required=false)]
                public long? Reserved { get; set; }

                [NameInMap("StatusDisable")]
                [Validation(Required=false)]
                public bool? StatusDisable { get; set; }

                [NameInMap("StatusDisableTotal")]
                [Validation(Required=false)]
                public long? StatusDisableTotal { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("UsedRatio")]
                [Validation(Required=false)]
                public long? UsedRatio { get; set; }

            }

            [NameInMap("Virtual")]
            [Validation(Required=false)]
            public string Virtual { get; set; }

        }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public DescribeNCInformationResponseBodyPager Pager { get; set; }
        public class DescribeNCInformationResponseBodyPager : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

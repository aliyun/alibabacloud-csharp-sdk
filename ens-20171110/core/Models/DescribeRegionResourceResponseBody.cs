// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeRegionResourceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRegionResourceResponseBodyData> Data { get; set; }
        public class DescribeRegionResourceResponseBodyData : TeaModel {
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            [NameInMap("ArmCard")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataArmCard ArmCard { get; set; }
            public class DescribeRegionResourceResponseBodyDataArmCard : TeaModel {
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

            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataBandwidth Bandwidth { get; set; }
            public class DescribeRegionResourceResponseBodyDataBandwidth : TeaModel {
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

            [NameInMap("BlockStorage")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataBlockStorage BlockStorage { get; set; }
            public class DescribeRegionResourceResponseBodyDataBlockStorage : TeaModel {
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

            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            [NameInMap("CountryName")]
            [Validation(Required=false)]
            public string CountryName { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataCpu Cpu { get; set; }
            public class DescribeRegionResourceResponseBodyDataCpu : TeaModel {
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
            public DescribeRegionResourceResponseBodyDataGpu Gpu { get; set; }
            public class DescribeRegionResourceResponseBodyDataGpu : TeaModel {
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
            public DescribeRegionResourceResponseBodyDataHdd Hdd { get; set; }
            public class DescribeRegionResourceResponseBodyDataHdd : TeaModel {
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

            [NameInMap("HouseId")]
            [Validation(Required=false)]
            public string HouseId { get; set; }

            [NameInMap("Ipv4s")]
            [Validation(Required=false)]
            public List<DescribeRegionResourceResponseBodyDataIpv4s> Ipv4s { get; set; }
            public class DescribeRegionResourceResponseBodyDataIpv4s : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

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

                [NameInMap("Vlan")]
                [Validation(Required=false)]
                public string Vlan { get; set; }

            }

            [NameInMap("Ipv6s")]
            [Validation(Required=false)]
            public List<DescribeRegionResourceResponseBodyDataIpv6s> Ipv6s { get; set; }
            public class DescribeRegionResourceResponseBodyDataIpv6s : TeaModel {
                [NameInMap("Display")]
                [Validation(Required=false)]
                public string Display { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

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

                [NameInMap("Vlan")]
                [Validation(Required=false)]
                public string Vlan { get; set; }

            }

            [NameInMap("IspTypes")]
            [Validation(Required=false)]
            public List<string> IspTypes { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataMemory Memory { get; set; }
            public class DescribeRegionResourceResponseBodyDataMemory : TeaModel {
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

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Nvme")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataNvme Nvme { get; set; }
            public class DescribeRegionResourceResponseBodyDataNvme : TeaModel {
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

            [NameInMap("OssStorage")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataOssStorage OssStorage { get; set; }
            public class DescribeRegionResourceResponseBodyDataOssStorage : TeaModel {
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

            [NameInMap("Pangu")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataPangu Pangu { get; set; }
            public class DescribeRegionResourceResponseBodyDataPangu : TeaModel {
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

            [NameInMap("PcfarmNum")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataPcfarmNum PcfarmNum { get; set; }
            public class DescribeRegionResourceResponseBodyDataPcfarmNum : TeaModel {
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

            [NameInMap("Poc")]
            [Validation(Required=false)]
            public bool? Poc { get; set; }

            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

            [NameInMap("ProvinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

            [NameInMap("ReserveDisable")]
            [Validation(Required=false)]
            public bool? ReserveDisable { get; set; }

            [NameInMap("Ssd")]
            [Validation(Required=false)]
            public DescribeRegionResourceResponseBodyDataSsd Ssd { get; set; }
            public class DescribeRegionResourceResponseBodyDataSsd : TeaModel {
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

            [NameInMap("StatusDisable")]
            [Validation(Required=false)]
            public bool? StatusDisable { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

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
        public DescribeRegionResourceResponseBodyPager Pager { get; set; }
        public class DescribeRegionResourceResponseBodyPager : TeaModel {
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

    }

}

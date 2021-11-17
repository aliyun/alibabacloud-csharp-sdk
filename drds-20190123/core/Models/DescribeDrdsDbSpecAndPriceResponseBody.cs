// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbSpecAndPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDbSpecAndPriceResponseBodyData Data { get; set; }
        public class DescribeDrdsDbSpecAndPriceResponseBodyData : TeaModel {
            [NameInMap("DrdsDbPrice")]
            [Validation(Required=false)]
            public DescribeDrdsDbSpecAndPriceResponseBodyDataDrdsDbPrice DrdsDbPrice { get; set; }
            public class DescribeDrdsDbSpecAndPriceResponseBodyDataDrdsDbPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }
            [NameInMap("DrdsInstance")]
            [Validation(Required=false)]
            public DescribeDrdsDbSpecAndPriceResponseBodyDataDrdsInstance DrdsInstance { get; set; }
            public class DescribeDrdsDbSpecAndPriceResponseBodyDataDrdsInstance : TeaModel {
                [NameInMap("DrdsInstanceId")]
                [Validation(Required=false)]
                public string DrdsInstanceId { get; set; }

                [NameInMap("InstRole")]
                [Validation(Required=false)]
                public string InstRole { get; set; }

                [NameInMap("InstanceSeries")]
                [Validation(Required=false)]
                public string InstanceSeries { get; set; }

                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public int? ProtocolType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VersionAction")]
                [Validation(Required=false)]
                public string VersionAction { get; set; }

                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }
            [NameInMap("RdsInstanceSpecsAndPrices")]
            [Validation(Required=false)]
            public List<DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPrices> RdsInstanceSpecsAndPrices { get; set; }
            public class DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPrices : TeaModel {
                public DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPricesRdsPrice RdsPrice { get; set; }
                public class DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPricesRdsPrice : TeaModel {
                    [NameInMap("Coupons")]
                    [Validation(Required=false)]
                    public string Coupons { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    [NameInMap("RuleIds")]
                    [Validation(Required=false)]
                    public List<string> RuleIds { get; set; }

                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                }
                public DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPricesStorageInstance StorageInstance { get; set; }
                public class DescribeDrdsDbSpecAndPriceResponseBodyDataRdsInstanceSpecsAndPricesStorageInstance : TeaModel {
                    [NameInMap("ConnectUrl")]
                    [Validation(Required=false)]
                    public string ConnectUrl { get; set; }

                    [NameInMap("DBInstType")]
                    [Validation(Required=false)]
                    public string DBInstType { get; set; }

                    [NameInMap("DBInstanceCPU")]
                    [Validation(Required=false)]
                    public string DBInstanceCPU { get; set; }

                    [NameInMap("DBInstanceClass")]
                    [Validation(Required=false)]
                    public string DBInstanceClass { get; set; }

                    [NameInMap("DBInstanceClassType")]
                    [Validation(Required=false)]
                    public string DBInstanceClassType { get; set; }

                    [NameInMap("DBInstanceDescription")]
                    [Validation(Required=false)]
                    public string DBInstanceDescription { get; set; }

                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    [NameInMap("DBInstanceMemory")]
                    [Validation(Required=false)]
                    public int? DBInstanceMemory { get; set; }

                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public int? DBInstanceStatus { get; set; }

                    [NameInMap("DBInstanceStorage")]
                    [Validation(Required=false)]
                    public int? DBInstanceStorage { get; set; }

                    [NameInMap("DBInstanceStorageType")]
                    [Validation(Required=false)]
                    public string DBInstanceStorageType { get; set; }

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("PayType")]
                    [Validation(Required=false)]
                    public string PayType { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("RDSInstType")]
                    [Validation(Required=false)]
                    public string RDSInstType { get; set; }

                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RemainDays")]
                    [Validation(Required=false)]
                    public int? RemainDays { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

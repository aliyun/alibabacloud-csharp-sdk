// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        [NameInMap("HaResourceSpec")]
        [Validation(Required=false)]
        public CreateInstanceRequestHaResourceSpec HaResourceSpec { get; set; }
        public class CreateInstanceRequestHaResourceSpec : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        [NameInMap("HaVSwitchIds")]
        [Validation(Required=false)]
        public List<string> HaVSwitchIds { get; set; }

        [NameInMap("HaZoneId")]
        [Validation(Required=false)]
        public string HaZoneId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("MonitorType")]
        [Validation(Required=false)]
        public string MonitorType { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public CreateInstanceRequestResourceSpec ResourceSpec { get; set; }
        public class CreateInstanceRequestResourceSpec : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public CreateInstanceRequestStorage Storage { get; set; }
        public class CreateInstanceRequestStorage : TeaModel {
            [NameInMap("FullyManaged")]
            [Validation(Required=false)]
            public bool? FullyManaged { get; set; }

            [NameInMap("Oss")]
            [Validation(Required=false)]
            public CreateInstanceRequestStorageOss Oss { get; set; }
            public class CreateInstanceRequestStorageOss : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UsePromotionCode")]
        [Validation(Required=false)]
        public bool? UsePromotionCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

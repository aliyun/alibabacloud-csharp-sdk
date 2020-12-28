// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<DescribeZonesResponseBodyZones> Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("AvailableResourceCreation")]
            [Validation(Required=false)]
            public List<string> AvailableResourceCreation { get; set; }

            [NameInMap("DedicatedHostGenerations")]
            [Validation(Required=false)]
            public List<string> DedicatedHostGenerations { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("AvailableInstanceTypes")]
            [Validation(Required=false)]
            public List<string> AvailableInstanceTypes { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("AvailableDiskCategories")]
            [Validation(Required=false)]
            public List<string> AvailableDiskCategories { get; set; }

            [NameInMap("AvailableDedicatedHostTypes")]
            [Validation(Required=false)]
            public List<string> AvailableDedicatedHostTypes { get; set; }

            [NameInMap("AvailableVolumeCategories")]
            [Validation(Required=false)]
            public List<string> AvailableVolumeCategories { get; set; }

            [NameInMap("AvailableResources")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesAvailableResources> AvailableResources { get; set; }
            public class DescribeZonesResponseBodyZonesAvailableResources : TeaModel {
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public bool? IoOptimized { get; set; }

                [NameInMap("SystemDiskCategories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                [NameInMap("InstanceGenerations")]
                [Validation(Required=false)]
                public List<string> InstanceGenerations { get; set; }

                [NameInMap("DataDiskCategories")]
                [Validation(Required=false)]
                public List<string> DataDiskCategories { get; set; }

                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                [NameInMap("InstanceTypeFamilies")]
                [Validation(Required=false)]
                public List<string> InstanceTypeFamilies { get; set; }

                [NameInMap("NetworkTypes")]
                [Validation(Required=false)]
                public List<string> NetworkTypes { get; set; }

            }

        }

    }

}

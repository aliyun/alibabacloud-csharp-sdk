// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableZoneResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableZoneResponseBodyData Data { get; set; }
        public class DescribeAvailableZoneResponseBodyData : TeaModel {
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<DescribeAvailableZoneResponseBodyDataAvailableZones> AvailableZones { get; set; }
            public class DescribeAvailableZoneResponseBodyDataAvailableZones : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Series")]
                [Validation(Required=false)]
                public string Series { get; set; }

                [NameInMap("SupportSpecifications")]
                [Validation(Required=false)]
                public List<DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecifications> SupportSpecifications { get; set; }
                public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecifications : TeaModel {
                    [NameInMap("DiskSizeRange")]
                    [Validation(Required=false)]
                    public DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsDiskSizeRange DiskSizeRange { get; set; }
                    public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsDiskSizeRange : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public long? Max { get; set; }

                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public long? Min { get; set; }

                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public long? Step { get; set; }

                    }

                    [NameInMap("DiskTypes")]
                    [Validation(Required=false)]
                    public List<string> DiskTypes { get; set; }

                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    [NameInMap("Spec")]
                    [Validation(Required=false)]
                    public string Spec { get; set; }

                    [NameInMap("SupportEngineVersions")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsSupportEngineVersions> SupportEngineVersions { get; set; }
                    public class DescribeAvailableZoneResponseBodyDataAvailableZonesSupportSpecificationsSupportEngineVersions : TeaModel {
                        [NameInMap("ObVersion")]
                        [Validation(Required=false)]
                        public string ObVersion { get; set; }

                        [NameInMap("SupportIsolationOptimization")]
                        [Validation(Required=false)]
                        public bool? SupportIsolationOptimization { get; set; }

                        [NameInMap("SupportReplicaModes")]
                        [Validation(Required=false)]
                        public List<string> SupportReplicaModes { get; set; }

                    }

                }

                [NameInMap("Zones")]
                [Validation(Required=false)]
                public string Zones { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

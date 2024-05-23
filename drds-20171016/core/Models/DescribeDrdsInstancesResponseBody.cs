// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeDrdsInstancesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsInstancesResponseBodyData Data { get; set; }
        public class DescribeDrdsInstancesResponseBodyData : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstancesResponseBodyDataInstance> Instance { get; set; }
            public class DescribeDrdsInstancesResponseBodyDataInstance : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DrdsInstanceId")]
                [Validation(Required=false)]
                public string DrdsInstanceId { get; set; }

                [NameInMap("InstRole")]
                [Validation(Required=false)]
                public string InstRole { get; set; }

                [NameInMap("MasterInstId")]
                [Validation(Required=false)]
                public string MasterInstId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SlaveInstId")]
                [Validation(Required=false)]
                public DescribeDrdsInstancesResponseBodyDataInstanceSlaveInstId SlaveInstId { get; set; }
                public class DescribeDrdsInstancesResponseBodyDataInstanceSlaveInstId : TeaModel {
                    [NameInMap("instId")]
                    [Validation(Required=false)]
                    public List<string> InstId { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

                [NameInMap("Vips")]
                [Validation(Required=false)]
                public DescribeDrdsInstancesResponseBodyDataInstanceVips Vips { get; set; }
                public class DescribeDrdsInstancesResponseBodyDataInstanceVips : TeaModel {
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsInstancesResponseBodyDataInstanceVipsVip> Vip { get; set; }
                    public class DescribeDrdsInstancesResponseBodyDataInstanceVipsVip : TeaModel {
                        [NameInMap("IP")]
                        [Validation(Required=false)]
                        public string IP { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                    }

                }

                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

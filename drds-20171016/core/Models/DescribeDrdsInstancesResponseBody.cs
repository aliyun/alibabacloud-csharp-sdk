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
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public string DrdsInstanceId { get; set; }
                public string InstRole { get; set; }
                public string MasterInstId { get; set; }
                public string NetworkType { get; set; }
                public string RegionId { get; set; }
                public DescribeDrdsInstancesResponseBodyDataInstanceSlaveInstId SlaveInstId { get; set; }
                public class DescribeDrdsInstancesResponseBodyDataInstanceSlaveInstId : TeaModel {
                    [NameInMap("instId")]
                    [Validation(Required=false)]
                    public List<string> InstId { get; set; }

                }
                public string Status { get; set; }
                public string Type { get; set; }
                public long? Version { get; set; }
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
                public string VpcCloudInstanceId { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

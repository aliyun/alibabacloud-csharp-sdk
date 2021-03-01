// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EcsEntityList")]
        [Validation(Required=false)]
        public ListEcsNotInClusterResponseBodyEcsEntityList EcsEntityList { get; set; }
        public class ListEcsNotInClusterResponseBodyEcsEntityList : TeaModel {
            [NameInMap("EcsEntity")]
            [Validation(Required=false)]
            public List<ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity> EcsEntity { get; set; }
            public class ListEcsNotInClusterResponseBodyEcsEntityListEcsEntity : TeaModel {
                public string Status { get; set; }
                public string VpcId { get; set; }
                public string PrivateIp { get; set; }
                public bool? Expired { get; set; }
                public string InstanceId { get; set; }
                public int? Mem { get; set; }
                public string RegionId { get; set; }
                public string VpcName { get; set; }
                public string InnerIp { get; set; }
                public int? Cpu { get; set; }
                public string Eip { get; set; }
                public string InstanceName { get; set; }
                public string PublicIp { get; set; }
            }
        };

    }

}

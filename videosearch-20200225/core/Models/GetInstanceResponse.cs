// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class GetInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetInstanceResponseData Data { get; set; }
        public class GetInstanceResponseData : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=true)]
            public string InstanceName { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long? CreateTime { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=true)]
            public string RegionId { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=true)]
            public int? InstanceStatus { get; set; }
            [NameInMap("VideoNumber")]
            [Validation(Required=true)]
            public int? VideoNumber { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public long? ExpireTime { get; set; }
            [NameInMap("ConcurrencyNumber")]
            [Validation(Required=true)]
            public int? ConcurrencyNumber { get; set; }
            [NameInMap("MaxVideoCapacity")]
            [Validation(Required=true)]
            public string MaxVideoCapacity { get; set; }
            [NameInMap("CurrentVideoCapacity")]
            [Validation(Required=true)]
            public string CurrentVideoCapacity { get; set; }
            [NameInMap("VideoInfoUpdateTime")]
            [Validation(Required=true)]
            public long? VideoInfoUpdateTime { get; set; }
            [NameInMap("BundlingType")]
            [Validation(Required=true)]
            public string BundlingType { get; set; }
        };

    }

}

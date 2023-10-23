// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstanceInfo InstanceInfo { get; set; }
        public class GetInstanceResponseBodyInstanceInfo : TeaModel {
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceInfoQuota Quota { get; set; }
            public class GetInstanceResponseBodyInstanceInfoQuota : TeaModel {
                [NameInMap("EntityQuota")]
                [Validation(Required=false)]
                public int? EntityQuota { get; set; }

            }

            [NameInMap("ReadCapacity")]
            [Validation(Required=false)]
            public int? ReadCapacity { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TagInfos")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceInfoTagInfos TagInfos { get; set; }
            public class GetInstanceResponseBodyInstanceInfoTagInfos : TeaModel {
                [NameInMap("TagInfo")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyInstanceInfoTagInfosTagInfo> TagInfo { get; set; }
                public class GetInstanceResponseBodyInstanceInfoTagInfosTagInfo : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WriteCapacity")]
            [Validation(Required=false)]
            public int? WriteCapacity { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

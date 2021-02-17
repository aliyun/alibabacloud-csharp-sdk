// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsInstanceInServiceListResponseBodyData Data { get; set; }
        public class OnsInstanceInServiceListResponseBodyData : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<OnsInstanceInServiceListResponseBodyDataInstanceVO> InstanceVO { get; set; }
            public class OnsInstanceInServiceListResponseBodyDataInstanceVO : TeaModel {
                public bool? IndependentNaming { get; set; }
                public string InstanceName { get; set; }
                public long? ReleaseTime { get; set; }
                public int? InstanceStatus { get; set; }
                public OnsInstanceInServiceListResponseBodyDataInstanceVOTags Tags { get; set; }
                public class OnsInstanceInServiceListResponseBodyDataInstanceVOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag> Tag { get; set; }
                    public class OnsInstanceInServiceListResponseBodyDataInstanceVOTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string InstanceId { get; set; }
                public int? InstanceType { get; set; }
            }
        };

    }

}

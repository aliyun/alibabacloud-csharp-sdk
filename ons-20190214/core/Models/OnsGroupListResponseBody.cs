// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupListResponseBodyData Data { get; set; }
        public class OnsGroupListResponseBodyData : TeaModel {
            [NameInMap("SubscribeInfoDo")]
            [Validation(Required=false)]
            public List<OnsGroupListResponseBodyDataSubscribeInfoDo> SubscribeInfoDo { get; set; }
            public class OnsGroupListResponseBodyDataSubscribeInfoDo : TeaModel {
                public string Owner { get; set; }
                public long? UpdateTime { get; set; }
                public bool? IndependentNaming { get; set; }
                public string GroupId { get; set; }
                public string Remark { get; set; }
                public long? CreateTime { get; set; }
                public OnsGroupListResponseBodyDataSubscribeInfoDoTags Tags { get; set; }
                public class OnsGroupListResponseBodyDataSubscribeInfoDoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag> Tag { get; set; }
                    public class OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string InstanceId { get; set; }
                public string GroupType { get; set; }
            }
        };

    }

}

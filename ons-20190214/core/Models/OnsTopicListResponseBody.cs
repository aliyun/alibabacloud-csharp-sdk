// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicListResponseBodyData Data { get; set; }
        public class OnsTopicListResponseBodyData : TeaModel {
            [NameInMap("PublishInfoDo")]
            [Validation(Required=false)]
            public List<OnsTopicListResponseBodyDataPublishInfoDo> PublishInfoDo { get; set; }
            public class OnsTopicListResponseBodyDataPublishInfoDo : TeaModel {
                public int? MessageType { get; set; }
                public string RelationName { get; set; }
                public string Owner { get; set; }
                public bool? IndependentNaming { get; set; }
                public string Remark { get; set; }
                public int? Relation { get; set; }
                public long? CreateTime { get; set; }
                public string Topic { get; set; }
                public OnsTopicListResponseBodyDataPublishInfoDoTags Tags { get; set; }
                public class OnsTopicListResponseBodyDataPublishInfoDoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsTopicListResponseBodyDataPublishInfoDoTagsTag> Tag { get; set; }
                    public class OnsTopicListResponseBodyDataPublishInfoDoTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string InstanceId { get; set; }
            }
        };

    }

}

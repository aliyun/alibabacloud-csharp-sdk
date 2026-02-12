// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicListResponseBodyData Data { get; set; }
        public class OnsTopicListResponseBodyData : TeaModel {
            [NameInMap("PublishInfoDo")]
            [Validation(Required=false)]
            public List<OnsTopicListResponseBodyDataPublishInfoDo> PublishInfoDo { get; set; }
            public class OnsTopicListResponseBodyDataPublishInfoDo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public int? MessageType { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Relation")]
                [Validation(Required=false)]
                public int? Relation { get; set; }

                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A978869-7681-4529-B470-107E1379****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

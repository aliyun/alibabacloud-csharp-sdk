// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetConsumerListResponseBody : TeaModel {
        /// <summary>
        /// The name of the consumer group.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("ConsumerList")]
        [Validation(Required=false)]
        public GetConsumerListResponseBodyConsumerList ConsumerList { get; set; }
        public class GetConsumerListResponseBodyConsumerList : TeaModel {
            [NameInMap("ConsumerVO")]
            [Validation(Required=false)]
            public List<GetConsumerListResponseBodyConsumerListConsumerVO> ConsumerVO { get; set; }
            public class GetConsumerListResponseBodyConsumerListConsumerVO : TeaModel {
                /// <summary>
                /// 自动创建的Group
                /// </summary>
                [NameInMap("AutomaticallyCreatedGroup")]
                [Validation(Required=false)]
                public bool? AutomaticallyCreatedGroup { get; set; }

                /// <summary>
                /// The ID of the instance to which the consumer group belongs.
                /// </summary>
                [NameInMap("ConsumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The description of the consumer group.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// Queries one or more consumer groups in a specified Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public GetConsumerListResponseBodyConsumerListConsumerVOTags Tags { get; set; }
                public class GetConsumerListResponseBodyConsumerListConsumerVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetConsumerListResponseBodyConsumerListConsumerVOTagsTagVO> TagVO { get; set; }
                    public class GetConsumerListResponseBodyConsumerListConsumerVOTagsTagVO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The key of the tag.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the consumer groups.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

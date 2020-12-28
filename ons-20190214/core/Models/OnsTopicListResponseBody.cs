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
        public List<OnsTopicListResponseBodyData> Data { get; set; }
        public class OnsTopicListResponseBodyData : TeaModel {
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public int? MessageType { get; set; }

            [NameInMap("RelationName")]
            [Validation(Required=false)]
            public string RelationName { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Relation")]
            [Validation(Required=false)]
            public int? Relation { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<OnsTopicListResponseBodyDataTags> Tags { get; set; }
            public class OnsTopicListResponseBodyDataTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("HelpUrl")]
        [Validation(Required=false)]
        public string HelpUrl { get; set; }

    }

}

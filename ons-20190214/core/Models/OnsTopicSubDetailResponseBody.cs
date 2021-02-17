// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicSubDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicSubDetailResponseBodyData Data { get; set; }
        public class OnsTopicSubDetailResponseBodyData : TeaModel {
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsTopicSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsTopicSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("MessageModel")]
                    [Validation(Required=false)]
                    public string MessageModel { get; set; }

                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                }

            }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
        };

    }

}

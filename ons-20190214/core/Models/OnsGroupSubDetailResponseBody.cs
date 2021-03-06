// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupSubDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupSubDetailResponseBodyData Data { get; set; }
        public class OnsGroupSubDetailResponseBodyData : TeaModel {
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsGroupSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsGroupSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("MessageModel")]
            [Validation(Required=false)]
            public string MessageModel { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
        };

    }

}

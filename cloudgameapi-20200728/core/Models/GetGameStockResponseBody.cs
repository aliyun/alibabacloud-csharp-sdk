// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameStockResponseBody : TeaModel {
        [NameInMap("AvailableTotal")]
        [Validation(Required=false)]
        public long? AvailableTotal { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("InstanceStockList")]
        [Validation(Required=false)]
        public List<GetGameStockResponseBodyInstanceStockList> InstanceStockList { get; set; }
        public class GetGameStockResponseBodyInstanceStockList : TeaModel {
            [NameInMap("AvailableSlots")]
            [Validation(Required=false)]
            public long? AvailableSlots { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("QuotaSlots")]
            [Validation(Required=false)]
            public long? QuotaSlots { get; set; }

            [NameInMap("ReginName")]
            [Validation(Required=false)]
            public string ReginName { get; set; }

            [NameInMap("UsedSlots")]
            [Validation(Required=false)]
            public long? UsedSlots { get; set; }

            [NameInMap("UserLevel")]
            [Validation(Required=false)]
            public long? UserLevel { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("QuotaTotal")]
        [Validation(Required=false)]
        public long? QuotaTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsedTotal")]
        [Validation(Required=false)]
        public long? UsedTotal { get; set; }

    }

}

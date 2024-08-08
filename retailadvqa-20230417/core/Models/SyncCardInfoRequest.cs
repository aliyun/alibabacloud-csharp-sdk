// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class SyncCardInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public SyncCardInfoRequestBody Body { get; set; }
        public class SyncCardInfoRequestBody : TeaModel {
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("Gifters")]
            [Validation(Required=false)]
            public SyncCardInfoRequestBodyGifters Gifters { get; set; }
            public class SyncCardInfoRequestBodyGifters : TeaModel {
                [NameInMap("HeaderImg")]
                [Validation(Required=false)]
                public string HeaderImg { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// openId
                /// </summary>
                [NameInMap("OpenId")]
                [Validation(Required=false)]
                public string OpenId { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

            [NameInMap("OccurredAt")]
            [Validation(Required=false)]
            public string OccurredAt { get; set; }

            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PresentDetail")]
            [Validation(Required=false)]
            public List<SyncCardInfoRequestBodyPresentDetail> PresentDetail { get; set; }
            public class SyncCardInfoRequestBodyPresentDetail : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public string SkuId { get; set; }

            }

            [NameInMap("ReceivedAt")]
            [Validation(Required=false)]
            public string ReceivedAt { get; set; }

            [NameInMap("Recipient")]
            [Validation(Required=false)]
            public SyncCardInfoRequestBodyRecipient Recipient { get; set; }
            public class SyncCardInfoRequestBodyRecipient : TeaModel {
                [NameInMap("HeaderImg")]
                [Validation(Required=false)]
                public string HeaderImg { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// openId
                /// </summary>
                [NameInMap("OpenId")]
                [Validation(Required=false)]
                public string OpenId { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Theme")]
            [Validation(Required=false)]
            public string Theme { get; set; }

            [NameInMap("TransferId")]
            [Validation(Required=false)]
            public string TransferId { get; set; }

            [NameInMap("TransferredAt")]
            [Validation(Required=false)]
            public string TransferredAt { get; set; }

        }

    }

}

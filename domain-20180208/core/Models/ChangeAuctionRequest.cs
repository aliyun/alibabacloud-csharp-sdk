// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class ChangeAuctionRequest : TeaModel {
        [NameInMap("AuctionList")]
        [Validation(Required=false)]
        public List<ChangeAuctionRequestAuctionList> AuctionList { get; set; }
        public class ChangeAuctionRequestAuctionList : TeaModel {
            [NameInMap("BidRecords")]
            [Validation(Required=false)]
            public List<ChangeAuctionRequestAuctionListBidRecords> BidRecords { get; set; }
            public class ChangeAuctionRequestAuctionListBidRecords : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public float? Price { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("IsReserve")]
            [Validation(Required=false)]
            public int? IsReserve { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public float? ReservePrice { get; set; }

            [NameInMap("ReserveRange")]
            [Validation(Required=false)]
            public string ReserveRange { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimeLeft")]
            [Validation(Required=false)]
            public long? TimeLeft { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Winner")]
            [Validation(Required=false)]
            public string Winner { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WinnerPrice")]
            [Validation(Required=false)]
            public float? WinnerPrice { get; set; }

        }

    }

}

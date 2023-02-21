// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcJusticeAuctionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcJusticeAuctionResponseBodyData> Data { get; set; }
        public class GetOcJusticeAuctionResponseBodyData : TeaModel {
            [NameInMap("AuctionDate")]
            [Validation(Required=false)]
            public string AuctionDate { get; set; }

            [NameInMap("AuctionName")]
            [Validation(Required=false)]
            public string AuctionName { get; set; }

            [NameInMap("Basis")]
            [Validation(Required=false)]
            public string Basis { get; set; }

            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            [NameInMap("Court")]
            [Validation(Required=false)]
            public string Court { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("EstPrice")]
            [Validation(Required=false)]
            public string EstPrice { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Restrict")]
            [Validation(Required=false)]
            public string Restrict { get; set; }

            [NameInMap("StartPrice")]
            [Validation(Required=false)]
            public string StartPrice { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}

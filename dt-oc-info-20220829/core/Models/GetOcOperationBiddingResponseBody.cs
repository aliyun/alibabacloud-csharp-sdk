// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcOperationBiddingResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcOperationBiddingResponseBodyData> Data { get; set; }
        public class GetOcOperationBiddingResponseBodyData : TeaModel {
            [NameInMap("AgentEntName")]
            [Validation(Required=false)]
            public string AgentEntName { get; set; }

            [NameInMap("BidIndustry")]
            [Validation(Required=false)]
            public string BidIndustry { get; set; }

            [NameInMap("BidTitle")]
            [Validation(Required=false)]
            public string BidTitle { get; set; }

            [NameInMap("BidType")]
            [Validation(Required=false)]
            public string BidType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("InfoType")]
            [Validation(Required=false)]
            public string InfoType { get; set; }

            [NameInMap("OpeningTime")]
            [Validation(Required=false)]
            public string OpeningTime { get; set; }

            [NameInMap("ProjectAmount")]
            [Validation(Required=false)]
            public string ProjectAmount { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("ProjectNum")]
            [Validation(Required=false)]
            public string ProjectNum { get; set; }

            [NameInMap("PublicDate")]
            [Validation(Required=false)]
            public string PublicDate { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("TenderEntName")]
            [Validation(Required=false)]
            public string TenderEntName { get; set; }

            [NameInMap("WinnerEntName")]
            [Validation(Required=false)]
            public string WinnerEntName { get; set; }

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

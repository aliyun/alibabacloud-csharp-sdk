// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIpTrademarkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcIpTrademarkResponseBodyData> Data { get; set; }
        public class GetOcIpTrademarkResponseBodyData : TeaModel {
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            [NameInMap("ApplyDate")]
            [Validation(Required=false)]
            public string ApplyDate { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("FirstPubDate")]
            [Validation(Required=false)]
            public string FirstPubDate { get; set; }

            [NameInMap("FirstPubNo")]
            [Validation(Required=false)]
            public string FirstPubNo { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("RegNum")]
            [Validation(Required=false)]
            public string RegNum { get; set; }

            [NameInMap("RegPubDate")]
            [Validation(Required=false)]
            public string RegPubDate { get; set; }

            [NameInMap("RegPubNo")]
            [Validation(Required=false)]
            public string RegPubNo { get; set; }

            [NameInMap("TrademarkForm")]
            [Validation(Required=false)]
            public string TrademarkForm { get; set; }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

            [NameInMap("TrademarkStatus")]
            [Validation(Required=false)]
            public string TrademarkStatus { get; set; }

            [NameInMap("TrademarkType")]
            [Validation(Required=false)]
            public string TrademarkType { get; set; }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

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

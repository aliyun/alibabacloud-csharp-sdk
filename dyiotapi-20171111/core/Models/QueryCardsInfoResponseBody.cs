// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryCardsInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CardsInfo")]
        [Validation(Required=false)]
        public List<QueryCardsInfoResponseBodyCardsInfo> CardsInfo { get; set; }
        public class QueryCardsInfoResponseBodyCardsInfo : TeaModel {
            [NameInMap("Imsi")]
            [Validation(Required=false)]
            public string Imsi { get; set; }

            [NameInMap("Msisdn")]
            [Validation(Required=false)]
            public string Msisdn { get; set; }

            [NameInMap("GprsStatus")]
            [Validation(Required=false)]
            public string GprsStatus { get; set; }

            [NameInMap("VoiceStatus")]
            [Validation(Required=false)]
            public string VoiceStatus { get; set; }

            [NameInMap("SmsStatus")]
            [Validation(Required=false)]
            public string SmsStatus { get; set; }

            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }

            [NameInMap("FirstActiveTime")]
            [Validation(Required=false)]
            public string FirstActiveTime { get; set; }

            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public string OpenTime { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}

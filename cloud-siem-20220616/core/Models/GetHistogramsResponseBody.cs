// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetHistogramsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistogramsResponseBodyData Data { get; set; }
        public class GetHistogramsResponseBodyData : TeaModel {
            [NameInMap("Histograms")]
            [Validation(Required=false)]
            public List<GetHistogramsResponseBodyDataHistograms> Histograms { get; set; }
            public class GetHistogramsResponseBodyDataHistograms : TeaModel {
                [NameInMap("CompletedOrNot")]
                [Validation(Required=false)]
                public bool? CompletedOrNot { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("From")]
                [Validation(Required=false)]
                public int? From { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public int? To { get; set; }

            }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

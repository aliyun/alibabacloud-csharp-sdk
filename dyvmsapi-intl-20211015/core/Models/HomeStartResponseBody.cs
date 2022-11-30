// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class HomeStartResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public HomeStartResponseBodyModel Model { get; set; }
        public class HomeStartResponseBodyModel : TeaModel {
            [NameInMap("CdrDrUrl")]
            [Validation(Required=false)]
            public string CdrDrUrl { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<HomeStartResponseBodyModelList> List { get; set; }
            public class HomeStartResponseBodyModelList : TeaModel {
                [NameInMap("CallFailed")]
                [Validation(Required=false)]
                public long? CallFailed { get; set; }

                [NameInMap("CallSuccess")]
                [Validation(Required=false)]
                public long? CallSuccess { get; set; }

                [NameInMap("CallTotal")]
                [Validation(Required=false)]
                public long? CallTotal { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("SuccessRate")]
                [Validation(Required=false)]
                public long? SuccessRate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

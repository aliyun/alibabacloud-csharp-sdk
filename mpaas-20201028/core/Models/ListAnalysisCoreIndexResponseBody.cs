// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListAnalysisCoreIndexResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListAnalysisCoreIndexResponseBodyResultContent ResultContent { get; set; }
        public class ListAnalysisCoreIndexResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListAnalysisCoreIndexResponseBodyResultContentData Data { get; set; }
            public class ListAnalysisCoreIndexResponseBodyResultContentData : TeaModel {
                [NameInMap("ArrivalNum")]
                [Validation(Required=false)]
                public string ArrivalNum { get; set; }

                [NameInMap("ArrivalRate")]
                [Validation(Required=false)]
                public string ArrivalRate { get; set; }

                [NameInMap("IgnoreNum")]
                [Validation(Required=false)]
                public string IgnoreNum { get; set; }

                [NameInMap("IgnoreRate")]
                [Validation(Required=false)]
                public string IgnoreRate { get; set; }

                [NameInMap("OpenNum")]
                [Validation(Required=false)]
                public string OpenNum { get; set; }

                [NameInMap("OpenRate")]
                [Validation(Required=false)]
                public string OpenRate { get; set; }

                [NameInMap("PushNum")]
                [Validation(Required=false)]
                public string PushNum { get; set; }

                [NameInMap("PushTotalNum")]
                [Validation(Required=false)]
                public string PushTotalNum { get; set; }

            }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

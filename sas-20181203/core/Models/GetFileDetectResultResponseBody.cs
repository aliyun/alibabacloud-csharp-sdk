// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<GetFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class GetFileDetectResultResponseBodyResultList : TeaModel {
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("VirusType")]
            [Validation(Required=false)]
            public string VirusType { get; set; }

        }

    }

}

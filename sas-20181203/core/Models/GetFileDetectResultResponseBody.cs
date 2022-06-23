// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<GetFileDetectResultResponseBodyResultList> ResultList { get; set; }
        public class GetFileDetectResultResponseBodyResultList : TeaModel {
            [NameInMap("Ext")]
            [Validation(Required=false)]
            public GetFileDetectResultResponseBodyResultListExt Ext { get; set; }
            public class GetFileDetectResultResponseBodyResultListExt : TeaModel {
                [NameInMap("VirusName")]
                [Validation(Required=false)]
                public string VirusName { get; set; }
            };

            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

    }

}

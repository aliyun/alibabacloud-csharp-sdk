// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotNotaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("FpShotNotaryList")]
        [Validation(Required=false)]
        public ListFpShotNotaryResponseBodyFpShotNotaryList FpShotNotaryList { get; set; }
        public class ListFpShotNotaryResponseBodyFpShotNotaryList : TeaModel {
            [NameInMap("FpShotNotary")]
            [Validation(Required=false)]
            public List<ListFpShotNotaryResponseBodyFpShotNotaryListFpShotNotary> FpShotNotary { get; set; }
            public class ListFpShotNotaryResponseBodyFpShotNotaryListFpShotNotary : TeaModel {
                public string TransactionId { get; set; }
                public string TxHash { get; set; }
                public string FpDBId { get; set; }
                public string JobId { get; set; }
                public string Detail { get; set; }
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
            }
        };

    }

}

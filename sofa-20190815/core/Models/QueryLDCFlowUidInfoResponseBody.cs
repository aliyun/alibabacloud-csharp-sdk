// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCFlowUidInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("UidInfoList")]
        [Validation(Required=false)]
        public List<QueryLDCFlowUidInfoResponseBodyUidInfoList> UidInfoList { get; set; }
        public class QueryLDCFlowUidInfoResponseBodyUidInfoList : TeaModel {
            [NameInMap("CurrentGroup")]
            [Validation(Required=false)]
            public string CurrentGroup { get; set; }

            [NameInMap("DefaultGroup")]
            [Validation(Required=false)]
            public string DefaultGroup { get; set; }

            [NameInMap("Elastic")]
            [Validation(Required=false)]
            public bool? Elastic { get; set; }

            [NameInMap("Gray")]
            [Validation(Required=false)]
            public bool? Gray { get; set; }

            [NameInMap("Press")]
            [Validation(Required=false)]
            public bool? Press { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

    }

}

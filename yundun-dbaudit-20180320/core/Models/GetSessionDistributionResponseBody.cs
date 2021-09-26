// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSessionDistributionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetSessionDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetSessionDistributionResponseBodyTimeList : TeaModel {
            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            [NameInMap("LoginSessionCount")]
            [Validation(Required=false)]
            public int? LoginSessionCount { get; set; }

            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("ErrorSessionCount")]
            [Validation(Required=false)]
            public int? ErrorSessionCount { get; set; }

        }

    }

}

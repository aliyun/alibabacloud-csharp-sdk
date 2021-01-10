// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeSmsSignStatusResponseBody : TeaModel {
        [NameInMap("SignStatuses")]
        [Validation(Required=false)]
        public List<DescribeSmsSignStatusResponseBodySignStatuses> SignStatuses { get; set; }
        public class DescribeSmsSignStatusResponseBodySignStatuses : TeaModel {
            [NameInMap("SignStatus")]
            [Validation(Required=false)]
            public int? SignStatus { get; set; }

            [NameInMap("SignId")]
            [Validation(Required=false)]
            public string SignId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

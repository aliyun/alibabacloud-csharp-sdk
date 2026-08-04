// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountTrueNameResponseBody : TeaModel {
        [NameInMap("ProfileInfo")]
        [Validation(Required=false)]
        public QueryAccountTrueNameResponseBodyProfileInfo ProfileInfo { get; set; }
        public class QueryAccountTrueNameResponseBodyProfileInfo : TeaModel {
            [NameInMap("TrueName")]
            [Validation(Required=false)]
            public string TrueName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        [NameInMap("AccountInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfo AccountInfo { get; set; }
        public class GetAccountInfoResponseBodyAccountInfo : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("MonthFreeCount")]
            [Validation(Required=false)]
            public int? MonthFreeCount { get; set; }

            [NameInMap("MonthHttpsResolveCount")]
            [Validation(Required=false)]
            public int? MonthHttpsResolveCount { get; set; }

            [NameInMap("MonthResolveCount")]
            [Validation(Required=false)]
            public int? MonthResolveCount { get; set; }

            [NameInMap("PackageCount")]
            [Validation(Required=false)]
            public int? PackageCount { get; set; }

            [NameInMap("SignSecret")]
            [Validation(Required=false)]
            public string SignSecret { get; set; }

            [NameInMap("SignedCount")]
            [Validation(Required=false)]
            public long? SignedCount { get; set; }

            [NameInMap("UnsignedCount")]
            [Validation(Required=false)]
            public long? UnsignedCount { get; set; }

            [NameInMap("UnsignedEnabled")]
            [Validation(Required=false)]
            public bool? UnsignedEnabled { get; set; }

            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public int? UserStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

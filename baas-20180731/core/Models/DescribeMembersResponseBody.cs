// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeMembersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeMembersResponseBodyResult Result { get; set; }
        public class DescribeMembersResponseBodyResult : TeaModel {
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<string> MemberList { get; set; }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeMembersResponseBodyResultPagination Pagination { get; set; }
            public class DescribeMembersResponseBodyResultPagination : TeaModel {
                [NameInMap("Current")]
                [Validation(Required=false)]
                public int? Current { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

    }

}

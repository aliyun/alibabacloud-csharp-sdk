// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListAliasesByKeyIdResponseBody : TeaModel {
        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public ListAliasesByKeyIdResponseBodyAliases Aliases { get; set; }
        public class ListAliasesByKeyIdResponseBodyAliases : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<ListAliasesByKeyIdResponseBodyAliasesAlias> Alias { get; set; }
            public class ListAliasesByKeyIdResponseBodyAliasesAlias : TeaModel {
                public string AliasArn { get; set; }
                public string AliasName { get; set; }
                public string KeyId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

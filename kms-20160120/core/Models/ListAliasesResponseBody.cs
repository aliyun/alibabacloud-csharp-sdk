// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListAliasesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Aliases")]
        [Validation(Required=false)]
        public ListAliasesResponseBodyAliases Aliases { get; set; }
        public class ListAliasesResponseBodyAliases : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<ListAliasesResponseBodyAliasesAlias> Alias { get; set; }
            public class ListAliasesResponseBodyAliasesAlias : TeaModel {
                public string AliasArn { get; set; }
                public string KeyId { get; set; }
                public string AliasName { get; set; }
            }
        };

    }

}

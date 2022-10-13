// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryAliasesResponseBody : TeaModel {
        [NameInMap("AliasInfos")]
        [Validation(Required=false)]
        public QueryAliasesResponseBodyAliasInfos AliasInfos { get; set; }
        public class QueryAliasesResponseBodyAliasInfos : TeaModel {
            [NameInMap("AliasInfo")]
            [Validation(Required=false)]
            public List<QueryAliasesResponseBodyAliasInfosAliasInfo> AliasInfo { get; set; }
            public class QueryAliasesResponseBodyAliasInfosAliasInfo : TeaModel {
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class CommonAgentQuery : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("querySceneEnumCode")]
        [Validation(Required=false)]
        public string QuerySceneEnumCode { get; set; }

        [NameInMap("searchModel")]
        [Validation(Required=false)]
        public string SearchModel { get; set; }

    }

}

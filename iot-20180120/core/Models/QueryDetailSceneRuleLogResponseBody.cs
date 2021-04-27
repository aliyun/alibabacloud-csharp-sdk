// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDetailSceneRuleLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDetailSceneRuleLogResponseBodyData Data { get; set; }
        public class QueryDetailSceneRuleLogResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("LogList")]
            [Validation(Required=false)]
            public List<QueryDetailSceneRuleLogResponseBodyDataLogList> LogList { get; set; }
            public class QueryDetailSceneRuleLogResponseBodyDataLogList : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string PkDn { get; set; }
            }
        };

    }

}

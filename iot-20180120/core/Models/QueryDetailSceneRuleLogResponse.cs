// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDetailSceneRuleLogResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDetailSceneRuleLogResponseData Data { get; set; }
        public class QueryDetailSceneRuleLogResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("LogList")]
            [Validation(Required=true)]
            public List<QueryDetailSceneRuleLogResponseDataLogList> LogList { get; set; }
            public class QueryDetailSceneRuleLogResponseDataLogList : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
                public string PkDn { get; set; }
            }
        };

    }

}

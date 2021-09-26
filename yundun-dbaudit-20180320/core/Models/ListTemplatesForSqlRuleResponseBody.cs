// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListTemplatesForSqlRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerData")]
        [Validation(Required=false)]
        public List<ListTemplatesForSqlRuleResponseBodyServerData> ServerData { get; set; }
        public class ListTemplatesForSqlRuleResponseBodyServerData : TeaModel {
            [NameInMap("CountTimely")]
            [Validation(Required=false)]
            public string CountTimely { get; set; }

            [NameInMap("BlackOrWhite")]
            [Validation(Required=false)]
            public int? BlackOrWhite { get; set; }

            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            [NameInMap("Sqltype1")]
            [Validation(Required=false)]
            public string Sqltype1 { get; set; }

            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

        }

    }

}

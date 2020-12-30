// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryChangeLogListResponseBody : TeaModel {
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryChangeLogListResponseBodyData Data { get; set; }
        public class QueryChangeLogListResponseBodyData : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<QueryChangeLogListResponseBodyDataChangeLog> ChangeLog { get; set; }
            public class QueryChangeLogListResponseBodyDataChangeLog : TeaModel {
                public string Operation { get; set; }
                public string Time { get; set; }
                public string Result { get; set; }
                public string DomainName { get; set; }
                public string OperationIPAddress { get; set; }
                public string Details { get; set; }
            }
        };

        [NameInMap("ResultLimit")]
        [Validation(Required=false)]
        public bool? ResultLimit { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryChangeLogListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryChangeLogListResponseBodyData Data { get; set; }
        public class QueryChangeLogListResponseBodyData : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<QueryChangeLogListResponseBodyDataChangeLog> ChangeLog { get; set; }
            public class QueryChangeLogListResponseBodyDataChangeLog : TeaModel {
                [NameInMap("Details")]
                [Validation(Required=false)]
                public string Details { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("OperationIPAddress")]
                [Validation(Required=false)]
                public string OperationIPAddress { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultLimit")]
        [Validation(Required=false)]
        public bool? ResultLimit { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}

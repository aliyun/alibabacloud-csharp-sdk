// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryCardSmsStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryCardSmsStatisticsResponseBodyModel Model { get; set; }
        public class QueryCardSmsStatisticsResponseBodyModel : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryCardSmsStatisticsResponseBodyModelRecords> Records { get; set; }
            public class QueryCardSmsStatisticsResponseBodyModelRecords : TeaModel {
                [NameInMap("RenderSuccessTotal")]
                [Validation(Required=false)]
                public long? RenderSuccessTotal { get; set; }

                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("TmpCode")]
                [Validation(Required=false)]
                public string TmpCode { get; set; }

                [NameInMap("TmpName")]
                [Validation(Required=false)]
                public string TmpName { get; set; }

                [NameInMap("UrlGenerateTotal")]
                [Validation(Required=false)]
                public long? UrlGenerateTotal { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

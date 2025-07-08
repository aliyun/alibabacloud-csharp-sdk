// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryCardSmsStatisticsSendResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryCardSmsStatisticsSendResponseBodyModel Model { get; set; }
        public class QueryCardSmsStatisticsSendResponseBodyModel : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryCardSmsStatisticsSendResponseBodyModelRecords> Records { get; set; }
            public class QueryCardSmsStatisticsSendResponseBodyModelRecords : TeaModel {
                [NameInMap("CustomTmpCode")]
                [Validation(Required=false)]
                public string CustomTmpCode { get; set; }

                [NameInMap("RenderSuccessRate")]
                [Validation(Required=false)]
                public double? RenderSuccessRate { get; set; }

                [NameInMap("RenderSuccessTotal")]
                [Validation(Required=false)]
                public long? RenderSuccessTotal { get; set; }

                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                [NameInMap("SendFailTotal")]
                [Validation(Required=false)]
                public long? SendFailTotal { get; set; }

                [NameInMap("SendProcessTotal")]
                [Validation(Required=false)]
                public long? SendProcessTotal { get; set; }

                [NameInMap("SendSuccessRate")]
                [Validation(Required=false)]
                public double? SendSuccessRate { get; set; }

                [NameInMap("SendSuccessTotal")]
                [Validation(Required=false)]
                public long? SendSuccessTotal { get; set; }

                [NameInMap("SendTotal")]
                [Validation(Required=false)]
                public long? SendTotal { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("SupportRate")]
                [Validation(Required=false)]
                public double? SupportRate { get; set; }

                [NameInMap("SupportTotal")]
                [Validation(Required=false)]
                public long? SupportTotal { get; set; }

                [NameInMap("TmpCode")]
                [Validation(Required=false)]
                public string TmpCode { get; set; }

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

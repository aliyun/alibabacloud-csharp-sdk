// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class QueryChildDivisionCodeByIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryChildDivisionCodeByIdResponseBodyModel Model { get; set; }
        public class QueryChildDivisionCodeByIdResponseBodyModel : TeaModel {
            [NameInMap("DivisionList")]
            [Validation(Required=false)]
            public List<QueryChildDivisionCodeByIdResponseBodyModelDivisionList> DivisionList { get; set; }
            public class QueryChildDivisionCodeByIdResponseBodyModelDivisionList : TeaModel {
                [NameInMap("DivisionCode")]
                [Validation(Required=false)]
                public long? DivisionCode { get; set; }

                [NameInMap("DivisionLevel")]
                [Validation(Required=false)]
                public long? DivisionLevel { get; set; }

                [NameInMap("DivisionName")]
                [Validation(Required=false)]
                public string DivisionName { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("Pinyin")]
                [Validation(Required=false)]
                public string Pinyin { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

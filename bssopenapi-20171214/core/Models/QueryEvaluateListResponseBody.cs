// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryEvaluateListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEvaluateListResponseBodyData Data { get; set; }
        public class QueryEvaluateListResponseBodyData : TeaModel {
            [NameInMap("EvaluateList")]
            [Validation(Required=false)]
            public QueryEvaluateListResponseBodyDataEvaluateList EvaluateList { get; set; }
            public class QueryEvaluateListResponseBodyDataEvaluateList : TeaModel {
                [NameInMap("Evaluate")]
                [Validation(Required=false)]
                public List<QueryEvaluateListResponseBodyDataEvaluateListEvaluate> Evaluate { get; set; }
                public class QueryEvaluateListResponseBodyDataEvaluateListEvaluate : TeaModel {
                    [NameInMap("BillCycle")]
                    [Validation(Required=false)]
                    public string BillCycle { get; set; }

                    [NameInMap("BillId")]
                    [Validation(Required=false)]
                    public long? BillId { get; set; }

                    [NameInMap("BizTime")]
                    [Validation(Required=false)]
                    public string BizTime { get; set; }

                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("CanInvoiceAmount")]
                    [Validation(Required=false)]
                    public long? CanInvoiceAmount { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InvoicedAmount")]
                    [Validation(Required=false)]
                    public long? InvoicedAmount { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OffsetAcceptAmount")]
                    [Validation(Required=false)]
                    public long? OffsetAcceptAmount { get; set; }

                    [NameInMap("OffsetCostAmount")]
                    [Validation(Required=false)]
                    public long? OffsetCostAmount { get; set; }

                    [NameInMap("OpId")]
                    [Validation(Required=false)]
                    public string OpId { get; set; }

                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public long? OriginalAmount { get; set; }

                    [NameInMap("OutBizId")]
                    [Validation(Required=false)]
                    public string OutBizId { get; set; }

                    [NameInMap("PresentAmount")]
                    [Validation(Required=false)]
                    public long? PresentAmount { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("TotalInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalInvoiceAmount { get; set; }
            [NameInMap("TotalUnAppliedInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalUnAppliedInvoiceAmount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

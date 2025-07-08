// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class ExportCardSmsHistoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public ExportCardSmsHistoryResponseBodyModel Model { get; set; }
        public class ExportCardSmsHistoryResponseBodyModel : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ExportCardSmsHistoryResponseBodyModelRecords> Records { get; set; }
            public class ExportCardSmsHistoryResponseBodyModelRecords : TeaModel {
                [NameInMap("AcceptDate")]
                [Validation(Required=false)]
                public long? AcceptDate { get; set; }

                [NameInMap("ApiSend")]
                [Validation(Required=false)]
                public long? ApiSend { get; set; }

                [NameInMap("CardTemplateType")]
                [Validation(Required=false)]
                public string CardTemplateType { get; set; }

                [NameInMap("CustomTmpCode")]
                [Validation(Required=false)]
                public string CustomTmpCode { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FuuId")]
                [Validation(Required=false)]
                public string FuuId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsSupport")]
                [Validation(Required=false)]
                public long? IsSupport { get; set; }

                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("Pid")]
                [Validation(Required=false)]
                public long? Pid { get; set; }

                [NameInMap("ReceiveState")]
                [Validation(Required=false)]
                public long? ReceiveState { get; set; }

                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("RenderDate")]
                [Validation(Required=false)]
                public long? RenderDate { get; set; }

                [NameInMap("RenderState")]
                [Validation(Required=false)]
                public long? RenderState { get; set; }

                [NameInMap("ShortUrl")]
                [Validation(Required=false)]
                public string ShortUrl { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("TmpCode")]
                [Validation(Required=false)]
                public string TmpCode { get; set; }

                [NameInMap("TmpId")]
                [Validation(Required=false)]
                public string TmpId { get; set; }

                [NameInMap("TmpType")]
                [Validation(Required=false)]
                public long? TmpType { get; set; }

                [NameInMap("TmpTypeName")]
                [Validation(Required=false)]
                public string TmpTypeName { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CustomerQuotaRecordListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CustomerQuotaRecordListResponseBodyData> Data { get; set; }
        public class CustomerQuotaRecordListResponseBodyData : TeaModel {
            [NameInMap("OperationSubmitType")]
            [Validation(Required=false)]
            public string OperationSubmitType { get; set; }

            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            [NameInMap("OperationTypeCode")]
            [Validation(Required=false)]
            public string OperationTypeCode { get; set; }

            [NameInMap("OperationTypeDesc")]
            [Validation(Required=false)]
            public string OperationTypeDesc { get; set; }

            [NameInMap("OperationUid")]
            [Validation(Required=false)]
            public string OperationUid { get; set; }

            [NameInMap("UpdateAfterAmount")]
            [Validation(Required=false)]
            public string UpdateAfterAmount { get; set; }

            [NameInMap("UpdateAmount")]
            [Validation(Required=false)]
            public string UpdateAmount { get; set; }

            [NameInMap("UpdateBeforeAmount")]
            [Validation(Required=false)]
            public string UpdateBeforeAmount { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

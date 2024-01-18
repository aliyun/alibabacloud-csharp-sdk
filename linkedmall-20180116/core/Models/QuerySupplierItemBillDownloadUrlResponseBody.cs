// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QuerySupplierItemBillDownloadUrlResponseBody : TeaModel {
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
        public QuerySupplierItemBillDownloadUrlResponseBodyModel Model { get; set; }
        public class QuerySupplierItemBillDownloadUrlResponseBodyModel : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QuerySupplierItemBillDownloadUrlResponseBodyModelData> Data { get; set; }
            public class QuerySupplierItemBillDownloadUrlResponseBodyModelData : TeaModel {
                [NameInMap("BillId")]
                [Validation(Required=false)]
                public string BillId { get; set; }

                [NameInMap("FileDownloadUrl")]
                [Validation(Required=false)]
                public string FileDownloadUrl { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeUserLogRequest : TeaModel {
        [NameInMap("EslBarCode")]
        [Validation(Required=false)]
        public string EslBarCode { get; set; }

        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("FromDate")]
        [Validation(Required=false)]
        public string FromDate { get; set; }

        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        [NameInMap("ItemShortTitle")]
        [Validation(Required=false)]
        public string ItemShortTitle { get; set; }

        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        [NameInMap("OperationStatus")]
        [Validation(Required=false)]
        public string OperationStatus { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("ToDate")]
        [Validation(Required=false)]
        public string ToDate { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

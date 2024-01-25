// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DescribeUserLogResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("UserLogs")]
        [Validation(Required=false)]
        public List<DescribeUserLogResponseBodyUserLogs> UserLogs { get; set; }
        public class DescribeUserLogResponseBodyUserLogs : TeaModel {
            [NameInMap("ActionPrice")]
            [Validation(Required=false)]
            public string ActionPrice { get; set; }

            [NameInMap("BePromotion")]
            [Validation(Required=false)]
            public bool? BePromotion { get; set; }

            [NameInMap("EslBarCode")]
            [Validation(Required=false)]
            public string EslBarCode { get; set; }

            [NameInMap("EslSignal")]
            [Validation(Required=false)]
            public int? EslSignal { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("I18nResultKey")]
            [Validation(Required=false)]
            public string I18nResultKey { get; set; }

            [NameInMap("ItemBarCode")]
            [Validation(Required=false)]
            public string ItemBarCode { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("ItemShortTitle")]
            [Validation(Required=false)]
            public string ItemShortTitle { get; set; }

            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            [NameInMap("OperationResponseTime")]
            [Validation(Required=false)]
            public string OperationResponseTime { get; set; }

            [NameInMap("OperationSendTime")]
            [Validation(Required=false)]
            public string OperationSendTime { get; set; }

            [NameInMap("OperationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("PriceUnit")]
            [Validation(Required=false)]
            public string PriceUnit { get; set; }

            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            [NameInMap("SpendTime")]
            [Validation(Required=false)]
            public string SpendTime { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
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
        public DescribeUserLogResponseBodyUserLogs UserLogs { get; set; }
        public class DescribeUserLogResponseBodyUserLogs : TeaModel {
            [NameInMap("UserLogInfo")]
            [Validation(Required=false)]
            public List<DescribeUserLogResponseBodyUserLogsUserLogInfo> UserLogInfo { get; set; }
            public class DescribeUserLogResponseBodyUserLogsUserLogInfo : TeaModel {
                [NameInMap("EslBarCode")]
                [Validation(Required=false)]
                public string EslBarCode { get; set; }

                [NameInMap("ItemActionPrice")]
                [Validation(Required=false)]
                public int? ItemActionPrice { get; set; }

                [NameInMap("ItemBarCode")]
                [Validation(Required=false)]
                public string ItemBarCode { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                [NameInMap("OperateStatus")]
                [Validation(Required=false)]
                public string OperateStatus { get; set; }

                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                [NameInMap("OperateUserId")]
                [Validation(Required=false)]
                public long? OperateUserId { get; set; }

                [NameInMap("ShelfCode")]
                [Validation(Required=false)]
                public string ShelfCode { get; set; }

                [NameInMap("StoreId")]
                [Validation(Required=false)]
                public string StoreId { get; set; }

            }

        }

    }

}

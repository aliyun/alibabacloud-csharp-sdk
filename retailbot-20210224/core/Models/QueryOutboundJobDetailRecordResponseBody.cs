// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobDetailRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryOutboundJobDetailRecordResponseBodyData> Data { get; set; }
        public class QueryOutboundJobDetailRecordResponseBodyData : TeaModel {
            [NameInMap("BatchNo")]
            [Validation(Required=false)]
            public string BatchNo { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("BizOrderId")]
            [Validation(Required=false)]
            public long? BizOrderId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public long? BuyerId { get; set; }

            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public string CallTime { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public string ExtraParams { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("MobileNo")]
            [Validation(Required=false)]
            public string MobileNo { get; set; }

            [NameInMap("PlayComplete")]
            [Validation(Required=false)]
            public int? PlayComplete { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

            [NameInMap("Reserve1")]
            [Validation(Required=false)]
            public int? Reserve1 { get; set; }

            [NameInMap("Reserve2")]
            [Validation(Required=false)]
            public long? Reserve2 { get; set; }

            [NameInMap("Reserve4")]
            [Validation(Required=false)]
            public string Reserve4 { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StoreName")]
            [Validation(Required=false)]
            public string StoreName { get; set; }

            [NameInMap("SubBizOrder")]
            [Validation(Required=false)]
            public long? SubBizOrder { get; set; }

            /// <summary>
            /// tenant Id
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("YunTaskId")]
            [Validation(Required=false)]
            public string YunTaskId { get; set; }

        }

        [NameInMap("ExtData")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtData { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}

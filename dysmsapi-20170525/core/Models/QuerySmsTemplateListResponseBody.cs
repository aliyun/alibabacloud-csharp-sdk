// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsTemplateListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmsTemplateList")]
        [Validation(Required=false)]
        public List<QuerySmsTemplateListResponseBodySmsTemplateList> SmsTemplateList { get; set; }
        public class QuerySmsTemplateListResponseBodySmsTemplateList : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("OuterTemplateType")]
            [Validation(Required=false)]
            public int? OuterTemplateType { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsTemplateListResponseBodySmsTemplateListReason Reason { get; set; }
            public class QuerySmsTemplateListResponseBodySmsTemplateListReason : TeaModel {
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }
            };

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

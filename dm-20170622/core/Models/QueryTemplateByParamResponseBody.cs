// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class QueryTemplateByParamResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTemplateByParamResponseBodyData Data { get; set; }
        public class QueryTemplateByParamResponseBodyData : TeaModel {
            [NameInMap("template")]
            [Validation(Required=false)]
            public List<QueryTemplateByParamResponseBodyDataTemplate> Template { get; set; }
            public class QueryTemplateByParamResponseBodyDataTemplate : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("SmsStatus")]
                [Validation(Required=false)]
                public int? SmsStatus { get; set; }

                [NameInMap("SmsTemplateCode")]
                [Validation(Required=false)]
                public int? SmsTemplateCode { get; set; }

                [NameInMap("Smsrejectinfo")]
                [Validation(Required=false)]
                public int? Smsrejectinfo { get; set; }

                [NameInMap("TemplateComment")]
                [Validation(Required=false)]
                public string TemplateComment { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("TemplateStatus")]
                [Validation(Required=false)]
                public string TemplateStatus { get; set; }

                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public int? TemplateType { get; set; }

                [NameInMap("UtcCreatetime")]
                [Validation(Required=false)]
                public long? UtcCreatetime { get; set; }

            }

        }

    }

}

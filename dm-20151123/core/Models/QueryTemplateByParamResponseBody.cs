// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTemplateByParamResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTemplateByParamResponseBodyData Data { get; set; }
        public class QueryTemplateByParamResponseBodyData : TeaModel {
            [NameInMap("template")]
            [Validation(Required=false)]
            public List<QueryTemplateByParamResponseBodyDataTemplate> Template { get; set; }
            public class QueryTemplateByParamResponseBodyDataTemplate : TeaModel {
                public string TemplateComment { get; set; }
                public long? UtcCreatetime { get; set; }
                public int? Smsrejectinfo { get; set; }
                public int? SmsTemplateCode { get; set; }
                public string CreateTime { get; set; }
                public string TemplateStatus { get; set; }
                public int? TemplateType { get; set; }
                public string TemplateName { get; set; }
                public int? SmsStatus { get; set; }
                public string TemplateId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsDetectListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QuerySmsDetectListNewResponseBodyList> List { get; set; }
        public class QuerySmsDetectListNewResponseBodyList : TeaModel {
            [NameInMap("DetectContent")]
            [Validation(Required=false)]
            public string DetectContent { get; set; }

            [NameInMap("DetectSignName")]
            [Validation(Required=false)]
            public string DetectSignName { get; set; }

            [NameInMap("DetectTime")]
            [Validation(Required=false)]
            public string DetectTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public string SuccessRate { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateParam")]
            [Validation(Required=false)]
            public string TemplateParam { get; set; }

        }

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
        public long? Total { get; set; }

    }

}

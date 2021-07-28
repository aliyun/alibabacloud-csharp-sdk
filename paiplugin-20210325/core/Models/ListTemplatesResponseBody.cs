// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20210325.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTemplatesResponseBodyData Data { get; set; }
        public class ListTemplatesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyDataTemplates> Templates { get; set; }
            public class ListTemplatesResponseBodyDataTemplates : TeaModel {
                public string Content { get; set; }
                public string CreatedTime { get; set; }
                public string ID { get; set; }
                public string Name { get; set; }
                public int? Status { get; set; }
                public string TemplateCode { get; set; }
                public string UpdatedTime { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMcuTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public QueryMcuTemplateResponseBodyTemplates Templates { get; set; }
        public class QueryMcuTemplateResponseBodyTemplates : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryMcuTemplateResponseBodyTemplatesJob> Job { get; set; }
            public class QueryMcuTemplateResponseBodyTemplatesJob : TeaModel {
                public string Template { get; set; }
                public string TemplateId { get; set; }
            }
        };

    }

}

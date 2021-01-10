// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMCTemplateListResponseBody : TeaModel {
        [NameInMap("NonExistTids")]
        [Validation(Required=false)]
        public QueryMCTemplateListResponseBodyNonExistTids NonExistTids { get; set; }
        public class QueryMCTemplateListResponseBodyNonExistTids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public QueryMCTemplateListResponseBodyTemplateList TemplateList { get; set; }
        public class QueryMCTemplateListResponseBodyTemplateList : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<QueryMCTemplateListResponseBodyTemplateListTemplate> Template { get; set; }
            public class QueryMCTemplateListResponseBodyTemplateListTemplate : TeaModel {
                public string Logo { get; set; }
                public string Abuse { get; set; }
                public string State { get; set; }
                public string Terrorism { get; set; }
                public string Politics { get; set; }
                public string Qrcode { get; set; }
                public string Live { get; set; }
                public string Spam { get; set; }
                public string Contraband { get; set; }
                public string Ad { get; set; }
                public string Porn { get; set; }
                public string Name { get; set; }
                public string TemplateId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

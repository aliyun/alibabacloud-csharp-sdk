// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateView : TeaModel {
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<TemplateViewFields> Fields { get; set; }
        public class TemplateViewFields : TeaModel {
            [NameInMap("DisplayOriImg")]
            [Validation(Required=false)]
            public bool? DisplayOriImg { get; set; }

            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("VisitInfo")]
            [Validation(Required=false)]
            public TemplateViewFieldsVisitInfo VisitInfo { get; set; }
            public class TemplateViewFieldsVisitInfo : TeaModel {
                [NameInMap("AftsConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> AftsConf { get; set; }

                [NameInMap("OssConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> OssConf { get; set; }

            }

        }

    }

}

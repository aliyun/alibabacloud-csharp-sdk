// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSystemTemplateResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 模板信息
        /// </summary>
        [NameInMap("SystemTemplate")]
        [Validation(Required=false)]
        public GetSystemTemplateResponseBodySystemTemplate SystemTemplate { get; set; }
        public class GetSystemTemplateResponseBodySystemTemplate : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public int? Subtype { get; set; }
            [NameInMap("SubtypeName")]
            [Validation(Required=false)]
            public string SubtypeName { get; set; }
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }
        };

    }

}

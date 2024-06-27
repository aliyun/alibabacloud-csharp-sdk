// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyTemplateStatusRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("fromTemplateSatus")]
        [Validation(Required=false)]
        public string FromTemplateSatus { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("toTemplateSatus")]
        [Validation(Required=false)]
        public string ToTemplateSatus { get; set; }

    }

}

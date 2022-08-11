// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateTemplateRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

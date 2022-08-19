// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public string ComponentsShrink { get; set; }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        [NameInMap("Example")]
        [Validation(Required=false)]
        public string ExampleShrink { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinktTemplateRequest : TeaModel {
        [NameInMap("DefaultContent")]
        [Validation(Required=false)]
        public string DefaultContent { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Stamp")]
        [Validation(Required=false)]
        public string Stamp { get; set; }

        [NameInMap("TemplateLabel")]
        [Validation(Required=false)]
        public string TemplateLabel { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}

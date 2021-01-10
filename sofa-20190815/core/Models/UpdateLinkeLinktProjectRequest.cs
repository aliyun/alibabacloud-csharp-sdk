// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinktProjectRequest : TeaModel {
        [NameInMap("Archive")]
        [Validation(Required=false)]
        public string Archive { get; set; }

        [NameInMap("AsPublic")]
        [Validation(Required=false)]
        public string AsPublic { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        [NameInMap("ParentSign")]
        [Validation(Required=false)]
        public string ParentSign { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktProjectRequest : TeaModel {
        [NameInMap("AsPublic")]
        [Validation(Required=false)]
        public bool? AsPublic { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParentSign")]
        [Validation(Required=false)]
        public string ParentSign { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RemoveEntityTagsShrinkRequest : TeaModel {
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

    }

}

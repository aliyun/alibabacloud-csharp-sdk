// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Transform : TeaModel {
        [NameInMap("castType")]
        [Validation(Required=false)]
        public FullDataType CastType { get; set; }

        [NameInMap("fieldRef")]
        [Validation(Required=false)]
        public FieldRef FieldRef { get; set; }

        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<TransformInput> Inputs { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CssInstanceComponent : TeaModel {
        [NameInMap("componentCode")]
        [Validation(Required=false)]
        public string ComponentCode { get; set; }

        [NameInMap("componentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("globalKey")]
        [Validation(Required=false)]
        public string GlobalKey { get; set; }

        [NameInMap("instanceProperty")]
        [Validation(Required=false)]
        public List<CssInstanceProperty> InstanceProperty { get; set; }

        [NameInMap("moduleAttrStatus")]
        [Validation(Required=false)]
        public long? ModuleAttrStatus { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}

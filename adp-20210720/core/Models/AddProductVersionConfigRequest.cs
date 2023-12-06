// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class AddProductVersionConfigRequest : TeaModel {
        [NameInMap("componentReleaseName")]
        [Validation(Required=false)]
        public string ComponentReleaseName { get; set; }

        [NameInMap("componentVersionUID")]
        [Validation(Required=false)]
        public string ComponentVersionUID { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parentComponentReleaseName")]
        [Validation(Required=false)]
        public string ParentComponentReleaseName { get; set; }

        [NameInMap("parentComponentVersionUID")]
        [Validation(Required=false)]
        public string ParentComponentVersionUID { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class PutProductInstanceConfigRequest : TeaModel {
        [NameInMap("componentUID")]
        [Validation(Required=false)]
        public string ComponentUID { get; set; }

        [NameInMap("componentVersionUID")]
        [Validation(Required=false)]
        public string ComponentVersionUID { get; set; }

        [NameInMap("configUID")]
        [Validation(Required=false)]
        public string ConfigUID { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("environmentUID")]
        [Validation(Required=false)]
        public string EnvironmentUID { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parentComponentName")]
        [Validation(Required=false)]
        public string ParentComponentName { get; set; }

        [NameInMap("parentComponentVersionUID")]
        [Validation(Required=false)]
        public string ParentComponentVersionUID { get; set; }

        [NameInMap("productVersionUID")]
        [Validation(Required=false)]
        public string ProductVersionUID { get; set; }

        [NameInMap("releaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public List<string> Scope { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}

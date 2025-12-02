// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class FieldInputConfig : TeaModel {
        [NameInMap("Arrayed")]
        [Validation(Required=false)]
        public bool? Arrayed { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("FieldCheckRegex")]
        [Validation(Required=false)]
        public string FieldCheckRegex { get; set; }

        [NameInMap("FieldClass")]
        [Validation(Required=false)]
        public string FieldClass { get; set; }

        [NameInMap("FieldConfigs")]
        [Validation(Required=false)]
        public List<FieldInputConfig> FieldConfigs { get; set; }

        [NameInMap("FieldDescription")]
        [Validation(Required=false)]
        public string FieldDescription { get; set; }

        [NameInMap("FieldExample")]
        [Validation(Required=false)]
        public string FieldExample { get; set; }

        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("FieldPath")]
        [Validation(Required=false)]
        public string FieldPath { get; set; }

        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

    }

}

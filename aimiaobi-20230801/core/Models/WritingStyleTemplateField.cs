// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class WritingStyleTemplateField : TeaModel {
        [NameInMap("BuildIn")]
        [Validation(Required=false)]
        public bool? BuildIn { get; set; }

        [NameInMap("CascadingFields")]
        [Validation(Required=false)]
        public List<WritingStyleTemplateField> CascadingFields { get; set; }

        [NameInMap("Enums")]
        [Validation(Required=false)]
        public List<WritingStyleTemplateFieldEnums> Enums { get; set; }
        public class WritingStyleTemplateFieldEnums : TeaModel {
            [NameInMap("CascadingFields")]
            [Validation(Required=false)]
            public List<string> CascadingFields { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("InitialValue")]
        [Validation(Required=false)]
        public string InitialValue { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        [NameInMap("MaxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        [NameInMap("MaxItemLength")]
        [Validation(Required=false)]
        public int? MaxItemLength { get; set; }

        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        [NameInMap("Min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        [NameInMap("MinItemLength")]
        [Validation(Required=false)]
        public int? MinItemLength { get; set; }

        [NameInMap("MinLength")]
        [Validation(Required=false)]
        public int? MinLength { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public WritingStyleTemplateFieldStyle Style { get; set; }
        public class WritingStyleTemplateFieldStyle : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            [NameInMap("ShowTime")]
            [Validation(Required=false)]
            public bool? ShowTime { get; set; }

            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktCustomfieldRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FieldFormat")]
        [Validation(Required=false)]
        public string FieldFormat { get; set; }

        [NameInMap("FieldLabel")]
        [Validation(Required=false)]
        public string FieldLabel { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectSign")]
        [Validation(Required=false)]
        public string ProjectSign { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("PossibleValuesRepeatList")]
        [Validation(Required=false)]
        public List<string> PossibleValuesRepeatList { get; set; }

    }

}

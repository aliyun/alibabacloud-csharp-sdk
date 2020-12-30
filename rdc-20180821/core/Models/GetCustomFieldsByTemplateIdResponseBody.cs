// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetCustomFieldsByTemplateIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCustomFieldsByTemplateIdResponseBodyData> Data { get; set; }
        public class GetCustomFieldsByTemplateIdResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Editable")]
            [Validation(Required=false)]
            public bool? Editable { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("IsRemember")]
            [Validation(Required=false)]
            public bool? IsRemember { get; set; }

            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public bool? IsDelete { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            [NameInMap("FieldFormat")]
            [Validation(Required=false)]
            public string FieldFormat { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            [NameInMap("IsRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            [NameInMap("NameI18N")]
            [Validation(Required=false)]
            public string NameI18N { get; set; }

            [NameInMap("PossibleValues")]
            [Validation(Required=false)]
            public string PossibleValues { get; set; }

            [NameInMap("MinLength")]
            [Validation(Required=false)]
            public int? MinLength { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Other")]
            [Validation(Required=false)]
            public string Other { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

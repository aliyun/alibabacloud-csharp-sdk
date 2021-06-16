// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListProjectCustomFieldsResponseBody : TeaModel {
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<ListProjectCustomFieldsResponseBodyObject> Object { get; set; }
        public class ListProjectCustomFieldsResponseBodyObject : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("CustomFieldId")]
            [Validation(Required=false)]
            public string CustomFieldId { get; set; }

            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public string Subtype { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListProjectCustomFieldsResponseBodyObjectValues> Values { get; set; }
            public class ListProjectCustomFieldsResponseBodyObjectValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

        }

    }

}

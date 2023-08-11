// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectFieldRequest : TeaModel {
        [NameInMap("statusIdentifier")]
        [Validation(Required=false)]
        public string StatusIdentifier { get; set; }

        [NameInMap("updateBasicFieldRequestList")]
        [Validation(Required=false)]
        public List<UpdateProjectFieldRequestUpdateBasicFieldRequestList> UpdateBasicFieldRequestList { get; set; }
        public class UpdateProjectFieldRequestUpdateBasicFieldRequestList : TeaModel {
            [NameInMap("propertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            [NameInMap("propertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

        }

        [NameInMap("updateForOpenApiList")]
        [Validation(Required=false)]
        public List<UpdateProjectFieldRequestUpdateForOpenApiList> UpdateForOpenApiList { get; set; }
        public class UpdateProjectFieldRequestUpdateForOpenApiList : TeaModel {
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

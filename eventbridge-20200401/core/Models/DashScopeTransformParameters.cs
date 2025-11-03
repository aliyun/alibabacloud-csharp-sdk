// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DashScopeTransformParameters : TeaModel {
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<DashScopeTransformParametersMessages> Messages { get; set; }
        public class DashScopeTransformParametersMessages : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("RequestPerMinute")]
        [Validation(Required=false)]
        public long? RequestPerMinute { get; set; }

        [NameInMap("StructuredOutputJsonSchema")]
        [Validation(Required=false)]
        public string StructuredOutputJsonSchema { get; set; }

        [NameInMap("TokenPerMinute")]
        [Validation(Required=false)]
        public long? TokenPerMinute { get; set; }

    }

}

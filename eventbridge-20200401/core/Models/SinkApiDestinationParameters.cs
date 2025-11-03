// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkApiDestinationParameters : TeaModel {
        [NameInMap("BodyParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersBodyParameters BodyParameters { get; set; }
        public class SinkApiDestinationParametersBodyParameters : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("HeaderParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersHeaderParameters HeaderParameters { get; set; }
        public class SinkApiDestinationParametersHeaderParameters : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("QueryStringParameters")]
        [Validation(Required=false)]
        public SinkApiDestinationParametersQueryStringParameters QueryStringParameters { get; set; }
        public class SinkApiDestinationParametersQueryStringParameters : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

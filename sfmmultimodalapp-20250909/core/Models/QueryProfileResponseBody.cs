// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class QueryProfileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProfileResponseBodyData Data { get; set; }
        public class QueryProfileResponseBodyData : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<QueryProfileResponseBodyDataAttributes> Attributes { get; set; }
            public class QueryProfileResponseBodyDataAttributes : TeaModel {
                [NameInMap("AttributeId")]
                [Validation(Required=false)]
                public string AttributeId { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Immutable")]
                [Validation(Required=false)]
                public string Immutable { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

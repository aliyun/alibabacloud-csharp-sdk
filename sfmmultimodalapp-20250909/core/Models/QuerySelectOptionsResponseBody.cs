// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class QuerySelectOptionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SelectOptions")]
        [Validation(Required=false)]
        public List<QuerySelectOptionsResponseBodySelectOptions> SelectOptions { get; set; }
        public class QuerySelectOptionsResponseBodySelectOptions : TeaModel {
            [NameInMap("BizConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> BizConfig { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<QuerySelectOptionsResponseBodySelectOptionsChildren> Children { get; set; }
            public class QuerySelectOptionsResponseBodySelectOptionsChildren : TeaModel {
                [NameInMap("BizConfig")]
                [Validation(Required=false)]
                public Dictionary<string, object> BizConfig { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

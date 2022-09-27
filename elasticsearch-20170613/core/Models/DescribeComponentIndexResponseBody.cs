// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeComponentIndexResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeComponentIndexResponseBodyResult Result { get; set; }
        public class DescribeComponentIndexResponseBodyResult : TeaModel {
            [NameInMap("_meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public DescribeComponentIndexResponseBodyResultTemplate Template { get; set; }
            public class DescribeComponentIndexResponseBodyResultTemplate : TeaModel {
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public Dictionary<string, object> Aliases { get; set; }

                [NameInMap("mappings")]
                [Validation(Required=false)]
                public Dictionary<string, object> Mappings { get; set; }

                [NameInMap("settings")]
                [Validation(Required=false)]
                public Dictionary<string, object> Settings { get; set; }

            }

        }

    }

}

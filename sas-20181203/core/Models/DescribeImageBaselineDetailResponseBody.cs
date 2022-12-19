// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailResponseBody : TeaModel {
        [NameInMap("BaselineDetail")]
        [Validation(Required=false)]
        public DescribeImageBaselineDetailResponseBodyBaselineDetail BaselineDetail { get; set; }
        public class DescribeImageBaselineDetailResponseBodyBaselineDetail : TeaModel {
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

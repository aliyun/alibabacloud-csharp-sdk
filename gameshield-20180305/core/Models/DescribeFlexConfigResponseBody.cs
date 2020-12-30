// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFlexConfigResponseBody : TeaModel {
        [NameInMap("FlexConfig")]
        [Validation(Required=false)]
        public DescribeFlexConfigResponseBodyFlexConfig FlexConfig { get; set; }
        public class DescribeFlexConfigResponseBodyFlexConfig : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("LinkType")]
            [Validation(Required=false)]
            public int? LinkType { get; set; }
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}

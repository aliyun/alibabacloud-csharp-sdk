// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigResponseBody : TeaModel {
        [NameInMap("OverallConfig")]
        [Validation(Required=false)]
        public DescribeCommonOverallConfigResponseBodyOverallConfig OverallConfig { get; set; }
        public class DescribeCommonOverallConfigResponseBodyOverallConfig : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

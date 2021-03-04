// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeServiceResponseBody : TeaModel {
        [NameInMap("ProtectionLevels")]
        [Validation(Required=false)]
        public DescribeServiceResponseBodyProtectionLevels ProtectionLevels { get; set; }
        public class DescribeServiceResponseBodyProtectionLevels : TeaModel {
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public List<DescribeServiceResponseBodyProtectionLevelsProtectionLevel> ProtectionLevel { get; set; }
            public class DescribeServiceResponseBodyProtectionLevelsProtectionLevel : TeaModel {
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("KeySpecs")]
        [Validation(Required=false)]
        public DescribeServiceResponseBodyKeySpecs KeySpecs { get; set; }
        public class DescribeServiceResponseBodyKeySpecs : TeaModel {
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public List<DescribeServiceResponseBodyKeySpecsKeySpec> KeySpec { get; set; }
            public class DescribeServiceResponseBodyKeySpecsKeySpec : TeaModel {
                [NameInMap("SupportedProtectionLevel")]
                [Validation(Required=false)]
                public List<string> SupportedProtectionLevel { get; set; }

            }
        };

    }

}

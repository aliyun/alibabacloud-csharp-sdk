// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeSecretKeysResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretKeys")]
        [Validation(Required=false)]
        public DescribeSecretKeysResponseBodySecretKeys SecretKeys { get; set; }
        public class DescribeSecretKeysResponseBodySecretKeys : TeaModel {
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public List<DescribeSecretKeysResponseBodySecretKeysSecretKey> SecretKey { get; set; }
            public class DescribeSecretKeysResponseBodySecretKeysSecretKey : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                [NameInMap("SecretKeyId")]
                [Validation(Required=false)]
                public string SecretKeyId { get; set; }

                [NameInMap("SecretKeyName")]
                [Validation(Required=false)]
                public string SecretKeyName { get; set; }

                [NameInMap("SecretKeyValue")]
                [Validation(Required=false)]
                public string SecretKeyValue { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

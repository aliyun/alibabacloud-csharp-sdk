// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserConfigsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeUserConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeUserConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("OssLogConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsOssLogConfig OssLogConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsOssLogConfig : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

            }

            [NameInMap("WafConfig")]
            [Validation(Required=false)]
            public DescribeUserConfigsResponseBodyConfigsWafConfig WafConfig { get; set; }
            public class DescribeUserConfigsResponseBodyConfigsWafConfig : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public string Enable { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

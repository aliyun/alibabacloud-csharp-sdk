// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterServiceConfigHistoryResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeClusterServiceConfigHistoryResponseBodyConfig Config { get; set; }
        public class DescribeClusterServiceConfigHistoryResponseBodyConfig : TeaModel {
            [NameInMap("Applied")]
            [Validation(Required=false)]
            public bool? Applied { get; set; }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("ConfigValueList")]
            [Validation(Required=false)]
            public DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueList ConfigValueList { get; set; }
            public class DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueList : TeaModel {
                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValue> ConfigValue { get; set; }
                public class DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValue : TeaModel {
                    [NameInMap("ConfigItemValueList")]
                    [Validation(Required=false)]
                    public DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValueConfigItemValueList ConfigItemValueList { get; set; }
                    public class DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValueConfigItemValueList : TeaModel {
                        [NameInMap("ConfigItemValue")]
                        [Validation(Required=false)]
                        public List<DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValueConfigItemValueListConfigItemValue> ConfigItemValue { get; set; }
                        public class DescribeClusterServiceConfigHistoryResponseBodyConfigConfigValueListConfigValueConfigItemValueListConfigItemValue : TeaModel {
                            public string ChangeType { get; set; }
                            public string ItemName { get; set; }
                            public string OldValue { get; set; }
                            public string Value { get; set; }
                        }
                    };

                    [NameInMap("ConfigName")]
                    [Validation(Required=false)]
                    public string ConfigName { get; set; }

                }

            }
            [NameInMap("ConfigVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

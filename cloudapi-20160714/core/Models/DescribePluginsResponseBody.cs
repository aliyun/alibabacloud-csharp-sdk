// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsResponseBodyPluginsPluginAttribute : TeaModel {
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string ModifiedTime { get; set; }
                public string PluginData { get; set; }
                public string PluginId { get; set; }
                public string PluginName { get; set; }
                public string PluginType { get; set; }
                public string RegionId { get; set; }
                public DescribePluginsResponseBodyPluginsPluginAttributeTags Tags { get; set; }
                public class DescribePluginsResponseBodyPluginsPluginAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribePluginsResponseBodyPluginsPluginAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribePluginsResponseBodyPluginsPluginAttributeTagsTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsByApiResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsByApiResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsByApiResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsByApiResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsByApiResponseBodyPluginsPluginAttribute : TeaModel {
                public string PluginId { get; set; }
                public string ModifiedTime { get; set; }
                public string PluginData { get; set; }
                public string Description { get; set; }
                public string PluginName { get; set; }
                public string CreatedTime { get; set; }
                public string PluginType { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}

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

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsByApiResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsByApiResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsByApiResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsByApiResponseBodyPluginsPluginAttribute : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("PluginData")]
                [Validation(Required=false)]
                public string PluginData { get; set; }

                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

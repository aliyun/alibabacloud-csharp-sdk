// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsByApiResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The plug-in information. The information is an array that consists of PluginAttribute data.
        /// </summary>
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsByApiResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsByApiResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsByApiResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsByApiResponseBodyPluginsPluginAttribute : TeaModel {
                /// <summary>
                /// The time when the plug-in was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The plug-in description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the plug-in was last modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The definition statement of the plug-in.
                /// </summary>
                [NameInMap("PluginData")]
                [Validation(Required=false)]
                public string PluginData { get; set; }

                /// <summary>
                /// The plug-in ID.
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// The plug-in name.
                /// </summary>
                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                /// <summary>
                /// The plug-in type.
                /// </summary>
                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// The region where the plug-in resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsByGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination parameter: current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Pagination parameter: number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsByGroupResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsByGroupResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsByGroupResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsByGroupResponseBodyPluginsPluginAttribute : TeaModel {
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

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F5574BA-F22B-563D-841E-C817964F517F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of results returned</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

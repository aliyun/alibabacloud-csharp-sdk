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

        /// <summary>
        /// <para>Returns information about the plugins</para>
        /// </summary>
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public DescribePluginsByGroupResponseBodyPlugins Plugins { get; set; }
        public class DescribePluginsByGroupResponseBodyPlugins : TeaModel {
            [NameInMap("PluginAttribute")]
            [Validation(Required=false)]
            public List<DescribePluginsByGroupResponseBodyPluginsPluginAttribute> PluginAttribute { get; set; }
            public class DescribePluginsByGroupResponseBodyPluginsPluginAttribute : TeaModel {
                /// <summary>
                /// <para>Creation time, in GMT</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-20T02:05:57Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>Plugin description</para>
                /// 
                /// <b>Example:</b>
                /// <para>traffic controll</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Last modified time, in GMT</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-15T02:30:18Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>Plugin definition statement</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;unit\&quot;:\&quot;MINUTE\&quot;,\&quot;apiDefault\&quot;:20}</para>
                /// </summary>
                [NameInMap("PluginData")]
                [Validation(Required=false)]
                public string PluginData { get; set; }

                /// <summary>
                /// <para>Plugin ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>5e204eeb4aa94c919a49f471ad3fc716</para>
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>Plugin name</para>
                /// 
                /// <b>Example:</b>
                /// <para>firstPlugin</para>
                /// </summary>
                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                /// <summary>
                /// <para>Plugin type</para>
                /// 
                /// <b>Example:</b>
                /// <para>trafficControl</para>
                /// </summary>
                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// <para>插件所在Region</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
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

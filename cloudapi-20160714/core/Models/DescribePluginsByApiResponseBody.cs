// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginsByApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plug-in information. The information is an array that consists of PluginAttribute data.</para>
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
                /// <para>The time when the plug-in was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-11T09:29:58Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The plug-in description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Traffic throttling</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the plug-in was last modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-11T09:29:58Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The definition statement of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;unit\&quot;:\&quot;MINUTE\&quot;,\&quot;apiDefault\&quot;:20}</para>
                /// </summary>
                [NameInMap("PluginData")]
                [Validation(Required=false)]
                public string PluginData { get; set; }

                /// <summary>
                /// <para>The plug-in ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9a3f1a5279434f2ba74ccd91c295af9f</para>
                /// </summary>
                [NameInMap("PluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

                /// <summary>
                /// <para>The plug-in name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>firstPlugin</para>
                /// </summary>
                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                /// <summary>
                /// <para>The plug-in type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trafficControl</para>
                /// </summary>
                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

                /// <summary>
                /// <para>The region where the plug-in resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46373DC4-19F1-4DC8-8C31-1107289BB5E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

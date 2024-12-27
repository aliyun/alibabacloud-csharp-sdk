// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateLocationDateClusteringTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The date configurations for clustering.</para>
        /// <remarks>
        /// <para> Adjusting these configurations affects existing spatiotemporal clusters for the dataset.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DateOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestDateOptions DateOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestDateOptions : TeaModel {
            /// <summary>
            /// <para>The maximum number of days allowed in a gap for a single spatiotemporal cluster. Valid values: 0 to 99999.</para>
            /// <para>For example, if travel photos were produced on March 4, 5, and 7, 2024, but not on Marh 6, 2024, and you set the parameter to 1, IMM considers the travel spanning the date range from March 4, 2024 to March 7, 2024 and includes photos within the data range in the same cluster.````</para>
            /// <para>We recommend that you set the parameter to a value within the range from 0 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GapDays")]
            [Validation(Required=false)]
            public long? GapDays { get; set; }

            /// <summary>
            /// <para>The maximum number of days that a single spatiotemporal cluster can span. Valid values: 1 to 99999. IMM does not create a cluster that spans more than the maximum number of days.</para>
            /// <para>For example, if you want to create travel photo clusters, you may want to exclude photos that were taken within 15 consecutive days in the same city, because it is likely that these photos were not taken during a travel. In this case, you can set the parameter to 15 to exclude this time range and location from the clustering task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("MaxDays")]
            [Validation(Required=false)]
            public long? MaxDays { get; set; }

            /// <summary>
            /// <para>The minimum number of days that a single spatiotemporal cluster can span. Valid values: 1 to 99999. IMM does not create a cluster that spans less than the minimum number of days.</para>
            /// <para>For example, if you do not want a one-day tour cluster, you can set the parameter to 2.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinDays")]
            [Validation(Required=false)]
            public long? MinDays { get; set; }

        }

        /// <summary>
        /// <para>The geolocation configurations for clustering.</para>
        /// <remarks>
        /// <para> Adjusting these configurations affects existing spatiotemporal clusters for the dataset.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LocationOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestLocationOptions LocationOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestLocationOptions : TeaModel {
            /// <summary>
            /// <para>The administrative division levels. You can specify multiple administrative division levels.</para>
            /// <para>For example, you uploaded photos that were taken from March 3, 2024 to March 5, 2024 in Hangzhou and photos that were taken from March 6, 2024 to March 8, 2024 in Jiaxing. When you call the operation and set the parameter to <c>[&quot;city&quot;, &quot;province&quot;]</c>, the following spatiotemporal clusters are created from these photos:</para>
            /// <list type="bullet">
            /// <item><description>March 3, 2024 to March 5, 2024, Hangzhou</description></item>
            /// <item><description>March 6, 2024 to March 8, 2024, Jiaxing</description></item>
            /// <item><description>March 3, 2024 to March 8, 2024, Zhejiang</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LocationDateClusterLevels")]
            [Validation(Required=false)]
            public List<string> LocationDateClusterLevels { get; set; }

        }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The custom tags. You can search for or filter asynchronous tasks by custom tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;User&quot;: &quot;Jane&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned in an asynchronous notification and facilitates notification management. The maximum length of the value is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

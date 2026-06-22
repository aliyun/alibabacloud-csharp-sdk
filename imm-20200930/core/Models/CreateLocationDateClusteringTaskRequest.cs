// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateLocationDateClusteringTaskRequest : TeaModel {
        /// <summary>
        /// <para>The dataset name. For more information, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The date clustering settings.</para>
        /// <remarks>
        /// <para>Notice: Modifying this setting also affects existing spatio-temporal clusters in your <c>Dataset</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DateOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestDateOptions DateOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestDateOptions : TeaModel {
            /// <summary>
            /// <para>The maximum number of gap days allowed in a single spatio-temporal group. The value must be in the range of 0 to 99,999.</para>
            /// <para>For example, a user has photos from March 4–5 and March 7, but not from March 6. If you assume that the photos from March 4–7 belong to the same trip, set this parameter to <c>1 day</c>. This allows the gap of <c>1 day</c> on March 6 to be included in the same spatio-temporal cluster.</para>
            /// <para>Set this parameter to a value from 0 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GapDays")]
            [Validation(Required=false)]
            public long? GapDays { get; set; }

            /// <summary>
            /// <para>The maximum number of days in a single spatio-temporal group. The value must be in the range of 1 to 99,999. Clusters with more days than this value are not detected or stored.</para>
            /// <para>For example, if a user takes photos in the same location for more than 15 consecutive days, this location might be their residence rather than a travel destination. If you want to exclude this time period and location from the spatio-temporal clusters, set this parameter to 15.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("MaxDays")]
            [Validation(Required=false)]
            public long? MaxDays { get; set; }

            /// <summary>
            /// <para>The minimum number of days in a single spatio-temporal group. The value must be in the range of 1 to 99,999. Clusters with fewer days than this value are not detected or stored.</para>
            /// <para>For example, if you do not want to include one-day trips in the generated groups, set this parameter to 2.</para>
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
        /// <para>The location clustering settings.</para>
        /// <remarks>
        /// <para>Notice: Modifying this setting also affects existing spatio-temporal clusters in your <c>Dataset</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LocationOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestLocationOptions LocationOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestLocationOptions : TeaModel {
            /// <summary>
            /// <para>A list of administrative levels for grouping. You can select multiple levels.</para>
            /// <para>For example, a user uploads photos taken in Hangzhou from March 3 to March 5 and photos taken in Jiaxing from March 6 to March 8. If you set this parameter to <c>[&quot;city&quot;, &quot;province&quot;]</c>, the following spatio-temporal clusters are generated:</para>
            /// <list type="bullet">
            /// <item><description><para>March 3 to March 5, Hangzhou</para>
            /// </description></item>
            /// <item><description><para>March 6 to March 8, Jiaxing</para>
            /// </description></item>
            /// <item><description><para>March 3 to March 8, Zhejiang</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LocationDateClusterLevels")]
            [Validation(Required=false)]
            public List<string> LocationDateClusterLevels { get; set; }

        }

        /// <summary>
        /// <para>The message notification configuration. For more information, see Notification. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The project name. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Custom tags used to search for and filter asynchronous tasks.</para>
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
        /// <para>Custom information that is returned in the asynchronous notification message. This helps you associate the notification message with your system. The maximum length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}

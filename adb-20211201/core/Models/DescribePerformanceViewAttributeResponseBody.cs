// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePerformanceViewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// <remarks>
        /// <para> This parameter is returned only if Resource Access Management (RAM) permission verification failed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The type of the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp198m028ih55xxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to populate the names of the metrics in the original monitoring view when you view the monitoring view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FillOriginViewKeys")]
        [Validation(Required=false)]
        public bool? FillOriginViewKeys { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E031AABF-BD56-5966-A063-4283EF18DB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the monitoring view.</para>
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public DescribePerformanceViewAttributeResponseBodyViewDetail ViewDetail { get; set; }
        public class DescribePerformanceViewAttributeResponseBodyViewDetail : TeaModel {
            /// <summary>
            /// <para>The metric category.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategories> Categories { get; set; }
            public class DescribePerformanceViewAttributeResponseBodyViewDetailCategories : TeaModel {
                /// <summary>
                /// <para>The name of the metric category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Node</b></description></item>
                /// <item><description><b>DiskData</b></description></item>
                /// <item><description><b>WorkLoad</b></description></item>
                /// <item><description><b>ResourceGroup</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The metrics.</para>
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys> Keys { get; set; }
                public class DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys : TeaModel {
                    [NameInMap("EnableAutoMc")]
                    [Validation(Required=false)]
                    public bool? EnableAutoMc { get; set; }

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public List<string> Engine { get; set; }

                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public List<string> GroupType { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AnalyticDB_CPU</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to select the metric. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies whether to enable the filter interaction feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChartLinked")]
            [Validation(Required=false)]
            public bool? ChartLinked { get; set; }

            /// <summary>
            /// <para>The number of charts to display in each row.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        /// <summary>
        /// <para>The name of the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}

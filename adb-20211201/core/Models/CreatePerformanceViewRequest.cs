// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreatePerformanceViewRequest : TeaModel {
        /// <summary>
        /// <para>The type of the original monitoring dashboard from which the current monitoring dashboard is copied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: basic dashboard.</description></item>
        /// <item><description><b>Advanced</b>: advanced dashboard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the cluster ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to populate the keys from the original monitoring dashboard when viewing the monitoring dashboard. Valid values:</para>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the supported regions and zones, including region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The details of the monitoring dashboard.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public CreatePerformanceViewRequestViewDetail ViewDetail { get; set; }
        public class CreatePerformanceViewRequestViewDetail : TeaModel {
            /// <summary>
            /// <para>The list of metric categories.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<CreatePerformanceViewRequestViewDetailCategories> Categories { get; set; }
            public class CreatePerformanceViewRequestViewDetailCategories : TeaModel {
                /// <summary>
                /// <para>The name of the metric category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Node</b>: node resource metrics.</description></item>
                /// <item><description><b>DiskData</b>: disk metrics.</description></item>
                /// <item><description><b>WorkLoad</b>: workload metrics.</description></item>
                /// <item><description><b>ResourceGroup</b>: resource group metrics.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The list of metrics.</para>
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<CreatePerformanceViewRequestViewDetailCategoriesKeys> Keys { get; set; }
                public class CreatePerformanceViewRequestViewDetailCategoriesKeys : TeaModel {
                    /// <summary>
                    /// <para>The key of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AnalyticDB_CPU</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the metric is selected. Valid values:</para>
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
            /// <para>Indicates whether the linkage chart is enabled. Valid values:</para>
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
            /// <para>The number of charts displayed per row.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        /// <summary>
        /// <para>The name of the monitoring dashboard.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom-All metrics-2 columns-Linked</para>
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}

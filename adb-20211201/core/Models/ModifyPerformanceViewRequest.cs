// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyPerformanceViewRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The new information about the monitoring view.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public ModifyPerformanceViewRequestViewDetail ViewDetail { get; set; }
        public class ModifyPerformanceViewRequestViewDetail : TeaModel {
            /// <summary>
            /// <para>The metric categories.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ModifyPerformanceViewRequestViewDetailCategories> Categories { get; set; }
            public class ModifyPerformanceViewRequestViewDetailCategories : TeaModel {
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
                public List<ModifyPerformanceViewRequestViewDetailCategoriesKeys> Keys { get; set; }
                public class ModifyPerformanceViewRequestViewDetailCategoriesKeys : TeaModel {
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
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
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
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        /// <summary>
        /// <para>The name of the monitoring view.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}

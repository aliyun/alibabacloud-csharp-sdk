// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyPerformanceViewRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/612397.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
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
        /// The region ID.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/143074.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// The new information about the monitoring view.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public ModifyPerformanceViewRequestViewDetail ViewDetail { get; set; }
        public class ModifyPerformanceViewRequestViewDetail : TeaModel {
            /// <summary>
            /// The metric categories.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ModifyPerformanceViewRequestViewDetailCategories> Categories { get; set; }
            public class ModifyPerformanceViewRequestViewDetailCategories : TeaModel {
                /// <summary>
                /// The name of the metric category. Valid values:
                /// 
                /// *   **Node**
                /// *   **DiskData**
                /// *   **WorkLoad**
                /// *   **ResourceGroup**
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The metrics.
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<ModifyPerformanceViewRequestViewDetailCategoriesKeys> Keys { get; set; }
                public class ModifyPerformanceViewRequestViewDetailCategoriesKeys : TeaModel {
                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// Specifies whether to select the metric. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// Specifies whether to enable the filter interaction feature. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ChartLinked")]
            [Validation(Required=false)]
            public bool? ChartLinked { get; set; }

            /// <summary>
            /// The number of charts to display in each row.
            /// </summary>
            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        /// <summary>
        /// The name of the monitoring view.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}

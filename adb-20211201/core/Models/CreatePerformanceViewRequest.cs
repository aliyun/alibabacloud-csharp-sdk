// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreatePerformanceViewRequest : TeaModel {
        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/612397.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to populate the names of the metrics in the original monitoring view when you view the monitoring view. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
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
        /// The information about the monitoring view.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public CreatePerformanceViewRequestViewDetail ViewDetail { get; set; }
        public class CreatePerformanceViewRequestViewDetail : TeaModel {
            /// <summary>
            /// The metric categories.
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<CreatePerformanceViewRequestViewDetailCategories> Categories { get; set; }
            public class CreatePerformanceViewRequestViewDetailCategories : TeaModel {
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
                public List<CreatePerformanceViewRequestViewDetailCategoriesKeys> Keys { get; set; }
                public class CreatePerformanceViewRequestViewDetailCategoriesKeys : TeaModel {
                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// Specifies whether to select the metric. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// Specifies whether to enable the filter interaction feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}

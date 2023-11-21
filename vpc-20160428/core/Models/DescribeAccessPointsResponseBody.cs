// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// The information about the access point.
        /// </summary>
        [NameInMap("AccessPointSet")]
        [Validation(Required=false)]
        public DescribeAccessPointsResponseBodyAccessPointSet AccessPointSet { get; set; }
        public class DescribeAccessPointsResponseBodyAccessPointSet : TeaModel {
            [NameInMap("AccessPointType")]
            [Validation(Required=false)]
            public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointType> AccessPointType { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointType : TeaModel {
                /// <summary>
                /// The feature model of the access point.
                /// </summary>
                [NameInMap("AccessPointFeatureModels")]
                [Validation(Required=false)]
                public DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels AccessPointFeatureModels { get; set; }
                public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels : TeaModel {
                    [NameInMap("AccessPointFeatureModel")]
                    [Validation(Required=false)]
                    public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel> AccessPointFeatureModel { get; set; }
                    public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel : TeaModel {
                        /// <summary>
                        /// The feature of the access point.
                        /// </summary>
                        [NameInMap("FeatureKey")]
                        [Validation(Required=false)]
                        public string FeatureKey { get; set; }

                        /// <summary>
                        /// The feature value of the access point.
                        /// </summary>
                        [NameInMap("FeatureValue")]
                        [Validation(Required=false)]
                        public string FeatureValue { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the access point.
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// The region ID of the access point.
                /// </summary>
                [NameInMap("AttachedRegionNo")]
                [Validation(Required=false)]
                public string AttachedRegionNo { get; set; }

                /// <summary>
                /// The description of the access point.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The Internet service provider (ISP) of the access point. Valid values:
                /// </summary>
                [NameInMap("HostOperator")]
                [Validation(Required=false)]
                public string HostOperator { get; set; }

                /// <summary>
                /// The location of the access point.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the access point.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the access point. Valid values:
                /// 
                /// *   **recommended**: The access point is ready for use.
                /// *   **hot**: A large number of Express Connect circuits are connected to the access point.
                /// *   **full**: The number of Express Connect circuits connected to the access point has reached the upper limit.
                /// *   **disabled**: The access point is unavailable.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The network type of the Express Connect circuit. Default value: **VPC**.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeAccessPointsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("AccessPointSet")]
        [Validation(Required=true)]
        public DescribeAccessPointsResponseAccessPointSet AccessPointSet { get; set; }
        public class DescribeAccessPointsResponseAccessPointSet : TeaModel {
            [NameInMap("AccessPointType")]
            [Validation(Required=true)]
            public List<DescribeAccessPointsResponseAccessPointSetAccessPointType> AccessPointType { get; set; }
            public class DescribeAccessPointsResponseAccessPointSetAccessPointType : TeaModel {
                public string AccessPointId { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public string AttachedRegionNo { get; set; }
                public string Location { get; set; }
                public string HostOperator { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public DescribeAccessPointsResponseAccessPointSetAccessPointTypeAccessPointFeatureModels AccessPointFeatureModels { get; set; }
                public class DescribeAccessPointsResponseAccessPointSetAccessPointTypeAccessPointFeatureModels : TeaModel {
                    [NameInMap("AccessPointFeatureModel")]
                    [Validation(Required=true)]
                    public List<DescribeAccessPointsResponseAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel> AccessPointFeatureModel { get; set; }
                    public class DescribeAccessPointsResponseAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel : TeaModel {
                        [NameInMap("FeatureKey")]
                        [Validation(Required=true)]
                        public string FeatureKey { get; set; }

                        [NameInMap("FeatureValue")]
                        [Validation(Required=true)]
                        public string FeatureValue { get; set; }

                    }

                }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        [NameInMap("AccessPointSet")]
        [Validation(Required=false)]
        public DescribeAccessPointsResponseBodyAccessPointSet AccessPointSet { get; set; }
        public class DescribeAccessPointsResponseBodyAccessPointSet : TeaModel {
            [NameInMap("AccessPointType")]
            [Validation(Required=false)]
            public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointType> AccessPointType { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointType : TeaModel {
                public string Status { get; set; }
                public string Type { get; set; }
                public string HostOperator { get; set; }
                public string Description { get; set; }
                public string AttachedRegionNo { get; set; }
                public DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels AccessPointFeatureModels { get; set; }
                public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels : TeaModel {
                    [NameInMap("AccessPointFeatureModel")]
                    [Validation(Required=false)]
                    public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel> AccessPointFeatureModel { get; set; }
                    public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel : TeaModel {
                        [NameInMap("FeatureValue")]
                        [Validation(Required=false)]
                        public string FeatureValue { get; set; }

                        [NameInMap("FeatureKey")]
                        [Validation(Required=false)]
                        public string FeatureKey { get; set; }

                    }

                }
                public string Name { get; set; }
                public string AccessPointId { get; set; }
                public string Location { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

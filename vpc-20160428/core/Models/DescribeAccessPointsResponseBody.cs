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
                [NameInMap("AccessPointFeatureModels")]
                [Validation(Required=false)]
                public DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels AccessPointFeatureModels { get; set; }
                public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModels : TeaModel {
                    [NameInMap("AccessPointFeatureModel")]
                    [Validation(Required=false)]
                    public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel> AccessPointFeatureModel { get; set; }
                    public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointTypeAccessPointFeatureModelsAccessPointFeatureModel : TeaModel {
                        [NameInMap("FeatureKey")]
                        [Validation(Required=false)]
                        public string FeatureKey { get; set; }

                        [NameInMap("FeatureValue")]
                        [Validation(Required=false)]
                        public string FeatureValue { get; set; }

                    }

                }

                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("AttachedRegionNo")]
                [Validation(Required=false)]
                public string AttachedRegionNo { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HostOperator")]
                [Validation(Required=false)]
                public string HostOperator { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E85D803-C7CF-4BCD-9CFE-6DBA1DFFA027</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access point.</para>
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
                /// <para>The feature model of the access point.</para>
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
                        /// <para>The feature of the access point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AP_Support_VbrBandwidthLimit</para>
                        /// </summary>
                        [NameInMap("FeatureKey")]
                        [Validation(Required=false)]
                        public string FeatureKey { get; set; }

                        /// <summary>
                        /// <para>The feature value of the access point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("FeatureValue")]
                        [Validation(Required=false)]
                        public string FeatureValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-cn-hangzhou-****</para>
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// <para>The region ID of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("AttachedRegionNo")]
                [Validation(Required=false)]
                public string AttachedRegionNo { get; set; }

                /// <summary>
                /// <para>The description of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the access point.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The Internet service provider (ISP) of the access point. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Telehouse</para>
                /// </summary>
                [NameInMap("HostOperator")]
                [Validation(Required=false)]
                public string HostOperator { get; set; }

                /// <summary>
                /// <para>The location of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the access point. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>recommended</b>: The access point is ready for use.</description></item>
                /// <item><description><b>hot</b>: A large number of Express Connect circuits are connected to the access point.</description></item>
                /// <item><description><b>full</b>: The number of Express Connect circuits connected to the access point has reached the upper limit.</description></item>
                /// <item><description><b>disabled</b>: The access point is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>recommended</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The network type of the Express Connect circuit. Default value: <b>VPC</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
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

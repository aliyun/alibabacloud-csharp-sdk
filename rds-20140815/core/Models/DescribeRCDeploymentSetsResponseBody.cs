// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCDeploymentSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the deployment set.</para>
        /// </summary>
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public DescribeRCDeploymentSetsResponseBodyDeploymentSets DeploymentSets { get; set; }
        public class DescribeRCDeploymentSetsResponseBodyDeploymentSets : TeaModel {
            [NameInMap("DeploymentSet")]
            [Validation(Required=false)]
            public List<DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSet> DeploymentSet { get; set; }
            public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSet : TeaModel {
                /// <summary>
                /// <para>The details of the capacities of the deployment set. This parameter is valid only when the deployment set contains existing RDS Custom instances. The value contains the details of the capacities of the deployment set in different zones.</para>
                /// </summary>
                [NameInMap("Capacities")]
                [Validation(Required=false)]
                public DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities Capacities { get; set; }
                public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities : TeaModel {
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public List<DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity> Capacity { get; set; }
                    public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity : TeaModel {
                        /// <summary>
                        /// <para>The number of RDS Custom instances that reside in the zone and can be added to the deployment set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>18</para>
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// <para>The number of RDS Custom instances that reside in the zone in the deployment set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        /// <summary>
                        /// <para>The zone ID. Only the IDs of the zones to which the existing RDS Custom instances in the deployment set belong are returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-j</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the deployment set was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-19T07:15:44Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The deployment set description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DeploymentSetDescription")]
                [Validation(Required=false)]
                public string DeploymentSetDescription { get; set; }

                /// <summary>
                /// <para>The deployment set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-ob5n4rbgy****</para>
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// <para>The deployment set name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deployment_test</para>
                /// </summary>
                [NameInMap("DeploymentSetName")]
                [Validation(Required=false)]
                public string DeploymentSetName { get; set; }

                /// <summary>
                /// <para>The deployment strategy. The return value of this parameter is the value of the <c>Strategy</c> request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Availability</para>
                /// </summary>
                [NameInMap("DeploymentStrategy")]
                [Validation(Required=false)]
                public string DeploymentStrategy { get; set; }

                /// <summary>
                /// <para>The deployment domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The deployment granularity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>The number of groups in the deployment set.</para>
                /// <remarks>
                /// <para> This parameter is valid only when the Strategy request parameter is set to AvailabilityGroup.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                /// <summary>
                /// <para>The number of RDS Custom instances in the deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                /// <summary>
                /// <para>The ID of the RDS Custom instance in the deployment set.</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds InstanceIds { get; set; }
                public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The deployment strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LooseDispersion</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

                [NameInMap("TagResources")]
                [Validation(Required=false)]
                public DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetTagResources TagResources { get; set; }
                public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetTagResources : TeaModel {
                    [NameInMap("TagResources")]
                    [Validation(Required=false)]
                    public List<DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetTagResourcesTagResources> TagResources { get; set; }
                    public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetTagResourcesTagResources : TeaModel {
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39265F46-EC77-4036-8AC4-F035F32F6BE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

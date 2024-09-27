// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDeploymentSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the deployment sets.</para>
        /// </summary>
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public DescribeDeploymentSetsResponseBodyDeploymentSets DeploymentSets { get; set; }
        public class DescribeDeploymentSetsResponseBodyDeploymentSets : TeaModel {
            [NameInMap("DeploymentSet")]
            [Validation(Required=false)]
            public List<DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSet> DeploymentSet { get; set; }
            public class DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSet : TeaModel {
                /// <summary>
                /// <para>Details of the capacities of the deployment set. This parameter is valid only when the deployment set contains ECS instances. The value contains information about the capacities of the deployment set in different zones.</para>
                /// </summary>
                [NameInMap("Capacities")]
                [Validation(Required=false)]
                public DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities Capacities { get; set; }
                public class DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities : TeaModel {
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public List<DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity> Capacity { get; set; }
                    public class DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity : TeaModel {
                        /// <summary>
                        /// <para>The number of ECS instances that can be added to the deployment set within the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>18</para>
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// <para>The number of ECS instances that reside in the zone in the deployment set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        /// <summary>
                        /// <para>The ID of the zone. Only the zone IDs of existing ECS instances in the deployment set are returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-i</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the deployment set was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-07T06:01:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDeploymentSetDescription</para>
                /// </summary>
                [NameInMap("DeploymentSetDescription")]
                [Validation(Required=false)]
                public string DeploymentSetDescription { get; set; }

                /// <summary>
                /// <para>The ID of the deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// <para>The name of the deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDeploymentSetName</para>
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
                /// <para>host</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>The number of deployment set groups in the deployment set.</para>
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
                /// <para>The number of instances in the deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                /// <summary>
                /// <para>The IDs of the Elastic Compute Service (ECS) instances in the deployment set.</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds InstanceIds { get; set; }
                public class DescribeDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds : TeaModel {
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried deployment sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

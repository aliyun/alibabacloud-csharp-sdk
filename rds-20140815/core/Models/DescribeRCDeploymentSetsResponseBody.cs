// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCDeploymentSetsResponseBody : TeaModel {
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public DescribeRCDeploymentSetsResponseBodyDeploymentSets DeploymentSets { get; set; }
        public class DescribeRCDeploymentSetsResponseBodyDeploymentSets : TeaModel {
            [NameInMap("DeploymentSet")]
            [Validation(Required=false)]
            public List<DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSet> DeploymentSet { get; set; }
            public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSet : TeaModel {
                [NameInMap("Capacities")]
                [Validation(Required=false)]
                public DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities Capacities { get; set; }
                public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacities : TeaModel {
                    [NameInMap("Capacity")]
                    [Validation(Required=false)]
                    public List<DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity> Capacity { get; set; }
                    public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetCapacitiesCapacity : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>18</para>
                        /// </summary>
                        [NameInMap("AvailableAmount")]
                        [Validation(Required=false)]
                        public int? AvailableAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UsedAmount")]
                        [Validation(Required=false)]
                        public int? UsedAmount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-j</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-06-19T07:15:44Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DeploymentSetDescription")]
                [Validation(Required=false)]
                public string DeploymentSetDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ds-ob5n4rbgy****</para>
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deployment_test</para>
                /// </summary>
                [NameInMap("DeploymentSetName")]
                [Validation(Required=false)]
                public string DeploymentSetName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Availability</para>
                /// </summary>
                [NameInMap("DeploymentStrategy")]
                [Validation(Required=false)]
                public string DeploymentStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("GroupCount")]
                [Validation(Required=false)]
                public int? GroupCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds InstanceIds { get; set; }
                public class DescribeRCDeploymentSetsResponseBodyDeploymentSetsDeploymentSetInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LooseDispersion</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39265F46-EC77-4036-8AC4-F035F32F6BE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

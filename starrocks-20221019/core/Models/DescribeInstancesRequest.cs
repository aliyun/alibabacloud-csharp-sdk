// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-a0cb1c8ad6d35XXX</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>starrocks_1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance status. You can specify multiple statuses separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>unpaid: Unpaid.</description></item>
        /// <item><description>paid: Paid.</description></item>
        /// <item><description>creating: Starting.</description></item>
        /// <item><description>running: Running.</description></item>
        /// <item><description>updating: Upgrading.</description></item>
        /// <item><description>disable: Unavailable.</description></item>
        /// <item><description>deleting: Releasing.</description></item>
        /// <item><description>scaling_out: Scaling out.</description></item>
        /// <item><description>scaling_in: Scaling in.</description></item>
        /// <item><description>scaling_up: Scaling up.</description></item>
        /// <item><description>scaling_down: Scaling down.</description></item>
        /// <item><description>upgrading: Upgrading the version.</description></item>
        /// <item><description>modifying_config: Updating configurations.</description></item>
        /// <item><description>enable_public_network: Enabling the public network.</description></item>
        /// <item><description>disable_public_network: Disabling the public network.</description></item>
        /// <item><description>convert_from_trial_to_official: Upgrading the instance edition.</description></item>
        /// <item><description>restarting: Restarting the cluster.</description></item>
        /// <item><description>migration_cluster_to_serverless: Migrating the cluster.</description></item>
        /// <item><description>actively_disabled: Stopped.</description></item>
        /// <item><description>enabling: Recovering.</description></item>
        /// <item><description>agent_creating: Creating the agent.</description></item>
        /// <item><description>agent_scaling_up: Scaling up the agent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running,creating</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

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
        /// <para>The number of entries per page for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmygmtrcenXXX</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

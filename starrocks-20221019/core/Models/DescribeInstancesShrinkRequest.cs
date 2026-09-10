// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstancesShrinkRequest : TeaModel {
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
        /// <para>Retrieves instances by instance status. Separate multiple instance statuses with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>unpaid: Pending payment.</description></item>
        /// <item><description>paid: Paid.</description></item>
        /// <item><description>creating: Being created.</description></item>
        /// <item><description>running: Running.</description></item>
        /// <item><description>updating: Being upgraded.</description></item>
        /// <item><description>disable: Unavailable.</description></item>
        /// <item><description>deleting: Being deleted.</description></item>
        /// <item><description>scaling_out: Scaling out.</description></item>
        /// <item><description>scaling_in: Scaling in.</description></item>
        /// <item><description>scaling_up: Specifications are being upgraded.</description></item>
        /// <item><description>scaling_down: Specifications are being used to decrease the quota.</description></item>
        /// <item><description>upgrading: Version is being upgraded.</description></item>
        /// <item><description>modifying_config: Configuration is being updated.</description></item>
        /// <item><description>enable_public_network: Public network access is being enabled.</description></item>
        /// <item><description>disable_public_network: Public network access is being shutdown.</description></item>
        /// <item><description>convert_from_trial_to_official: The instance edition is being upgraded.</description></item>
        /// <item><description>restarting: The cluster is restarting.</description></item>
        /// <item><description>migration_cluster_to_serverless: The cluster is being migrated.</description></item>
        /// <item><description>actively_disabled: The instance is stopped.</description></item>
        /// <item><description>enabling: The instance is being recovered.</description></item>
        /// <item><description>agent_creating: The agent is being created.</description></item>
        /// <item><description>agent_scaling_up: The agent specifications are being upgraded.</description></item>
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
        /// <para>The number of entries per page for a paged query.</para>
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
        public string TagShrink { get; set; }

    }

}

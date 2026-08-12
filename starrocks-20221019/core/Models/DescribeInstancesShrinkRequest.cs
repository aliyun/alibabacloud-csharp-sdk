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
        /// <para>The instance status to filter by. You can specify multiple statuses, separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>unpaid</para>
        /// </description></item>
        /// <item><description><para>paid</para>
        /// </description></item>
        /// <item><description><para>creating</para>
        /// </description></item>
        /// <item><description><para>running</para>
        /// </description></item>
        /// <item><description><para>updating</para>
        /// </description></item>
        /// <item><description><para>disable</para>
        /// </description></item>
        /// <item><description><para>deleting</para>
        /// </description></item>
        /// <item><description><para>scaling_out</para>
        /// </description></item>
        /// <item><description><para>scaling_in</para>
        /// </description></item>
        /// <item><description><para>scaling_up</para>
        /// </description></item>
        /// <item><description><para>scaling_down</para>
        /// </description></item>
        /// <item><description><para>upgrading</para>
        /// </description></item>
        /// <item><description><para>modifying_config</para>
        /// </description></item>
        /// <item><description><para>enable_public_network</para>
        /// </description></item>
        /// <item><description><para>disable_public_network</para>
        /// </description></item>
        /// <item><description><para>convert_from_trial_to_official</para>
        /// </description></item>
        /// <item><description><para>restarting</para>
        /// </description></item>
        /// <item><description><para>migration_cluster_to_serverless</para>
        /// </description></item>
        /// <item><description><para>actively_disabled</para>
        /// </description></item>
        /// <item><description><para>enabling</para>
        /// </description></item>
        /// <item><description><para>agent_creating</para>
        /// </description></item>
        /// <item><description><para>agent_scaling_up</para>
        /// </description></item>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}

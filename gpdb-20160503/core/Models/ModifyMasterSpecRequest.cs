// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyMasterSpecRequest : TeaModel {
        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the instance IDs of all AnalyticDB for PostgreSQL instances in a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective period of the specification change. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): The change takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The change takes effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>If you want to change the master node to a MasterAI node, specify this parameter.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter and MasterCU cannot be specified at the same time.</description></item>
        /// <item><description>Only specific regions and zones support changing the master node to a MasterAI node.</description></item>
        /// <item><description>Only AnalyticDB for PostgreSQL V7.0 Basic Edition instances support MasterAI nodes.</description></item>
        /// <item><description>You can view all valid values of this parameter on the specification change page for the master node.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ADB.AIMedium.2</para>
        /// </summary>
        [NameInMap("MasterAISpec")]
        [Validation(Required=false)]
        public string MasterAISpec { get; set; }

        /// <summary>
        /// <para>The master resources. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>2 CU </description></item>
        /// <item><description>4 CU </description></item>
        /// <item><description>8 CU </description></item>
        /// <item><description>16 CU </description></item>
        /// <item><description>32 CU <remarks>
        /// <para>Master resources greater than 8 CU incur additional fees.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8 CU</para>
        /// </summary>
        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For information about how to obtain the resource group ID, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

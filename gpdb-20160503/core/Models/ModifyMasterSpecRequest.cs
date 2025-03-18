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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a region.</para>
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
        /// <para>This parameter must be specified if you want to change coordinator nodes to AI coordinator nodes.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You cannot specify the MasterAISpec and MasterCU parameters at the same time.</description></item>
        /// <item><description>You can change coordinator nodes to AI coordinator nodes only in specific regions and zones.</description></item>
        /// <item><description>Only AnalyticDB for PostgreSQL V7.0 instances of Basic Edition support AI coordinator nodes.</description></item>
        /// <item><description>You can view the valid values of this parameter on the configuration change page of coordinator nodes.</description></item>
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
        /// <para>The specifications of coordinator node resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2 CU</description></item>
        /// <item><description>4 CU</description></item>
        /// <item><description>8 CU</description></item>
        /// <item><description>16 CU</description></item>
        /// <item><description>32 CU</description></item>
        /// </list>
        /// <remarks>
        /// <para> You are charged for coordinator node resources of more than 8 compute units (CUs).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8 CU</para>
        /// </summary>
        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For information about how to obtain the ID of a resource group, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

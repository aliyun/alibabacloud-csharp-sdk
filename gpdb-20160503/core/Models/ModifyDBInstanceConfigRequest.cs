// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the instance IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The wait period for the instance that has no traffic to become idle. Minimum value: 60. Default value: 600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("IdleTime")]
        [Validation(Required=false)]
        public int? IdleTime { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For more information about how to obtain the ID of a resource group, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The threshold of computing resources. Valid values: 8 to 32. Unit: AnalyticDB Compute Units (ACUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public int? ServerlessResource { get; set; }

    }

}

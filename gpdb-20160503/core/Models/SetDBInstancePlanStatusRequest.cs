// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class SetDBInstancePlanStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the plan.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/449398.html">DescribeDBInstancePlans</a> operation to query the details of plans, including plan IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>disable</b>: disables the plan.</description></item>
        /// <item><description><b>enable</b>: enables the plan.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("PlanStatus")]
        [Validation(Required=false)]
        public string PlanStatus { get; set; }

    }

}

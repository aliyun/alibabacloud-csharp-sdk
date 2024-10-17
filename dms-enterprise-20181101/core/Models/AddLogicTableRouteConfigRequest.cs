// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLogicTableRouteConfigRequest : TeaModel {
        /// <summary>
        /// <para>The routing algorithm expression. For more information about how to configure a routing algorithm expression, see <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/configure-a-routing-algorithm">Configure a routing algorithm</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#id#%16</para>
        /// </summary>
        [NameInMap("RouteExpr")]
        [Validation(Required=false)]
        public string RouteExpr { get; set; }

        /// <summary>
        /// <para>The unique key of the routing algorithm. </para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can create a custom unique key for the routing algorithm. No requirements are imposed on custom unique keys.</description></item>
        /// <item><description>The unique key of the routing algorithm in the same logical table must be unique.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-hash-mod16</para>
        /// </summary>
        [NameInMap("RouteKey")]
        [Validation(Required=false)]
        public string RouteKey { get; set; }

        /// <summary>
        /// <para>The ID of the logical table. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listlogictables">ListLogicTables</a> operation to query the ID of the logical table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4****</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

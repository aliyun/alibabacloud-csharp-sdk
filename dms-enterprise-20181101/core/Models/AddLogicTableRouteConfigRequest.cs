// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLogicTableRouteConfigRequest : TeaModel {
        /// <summary>
        /// The routing algorithm expression. For more information about how to configure a routing algorithm expression, see [Configure a routing algorithm](https://www.alibabacloud.com/help/en/data-management-service/latest/configure-a-routing-algorithm).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteExpr")]
        [Validation(Required=false)]
        public string RouteExpr { get; set; }

        /// <summary>
        /// The unique key of the routing algorithm. 
        /// 
        /// > - You can create a custom unique key for the routing algorithm. No requirements are imposed on custom unique keys.
        /// > - The unique key of the routing algorithm in the same logical table must be unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteKey")]
        [Validation(Required=false)]
        public string RouteKey { get; set; }

        /// <summary>
        /// The ID of the logical table. You can call the [ListLogicTables](https://www.alibabacloud.com/help/en/data-management-service/latest/listlogictables) operation to query the ID of the logical table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLogicTableRouteConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RouteExpr")]
        [Validation(Required=false)]
        public string RouteExpr { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("RouteKey")]
        [Validation(Required=false)]
        public string RouteKey { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant) operation to query the tenant ID.
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// Adds a routing algorithm to a logical table.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteLogicTableRouteConfigRequest : TeaModel {
        /// <summary>
        /// <para>The unique key of the routing algorithm. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listlogictablerouteconfig">ListLogicTableRouteConfig</a> operation to query the unique key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-hash-mod15</para>
        /// </summary>
        [NameInMap("RouteKey")]
        [Validation(Required=false)]
        public string RouteKey { get; set; }

        /// <summary>
        /// <para>The ID of the logical table. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listlogictables">ListLogicTables</a> operation to query the ID of the logical table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

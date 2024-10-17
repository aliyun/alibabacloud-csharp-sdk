// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxyAccessesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the secure access proxy. </para>
        /// <remarks>
        /// <para> You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listproxies">ListProxies</a> operation to query the ID of the secure access proxy.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("ProxyId")]
        [Validation(Required=false)]
        public long? ProxyId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. </para>
        /// <remarks>
        /// <para> You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant">GetUserActiveTenant</a> operation to query the ID of the tenant.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class InspectProxyAccessSecretRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security protection authorization. After the security protection agent authorizes the target user, the system automatically generates a security protection authorization ID. The ID is globally unique. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listproxyaccesses">ListProxyAccesses</a> operation to obtain this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProxyAccessId")]
        [Validation(Required=false)]
        public long? ProxyAccessId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant">GetUserActiveTenant</a> or <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listusertenants">ListUserTenants</a> operation to obtain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

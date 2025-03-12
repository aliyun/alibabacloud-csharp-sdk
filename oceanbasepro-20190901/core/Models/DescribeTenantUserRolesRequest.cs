// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantUserRolesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. If you specify the ID of a tenant in MySQL mode, the privilege configuration of the regular user in MySQL mode is returned. If you specify the ID of a tenant in Oracle mode, the privilege configuration of the regular user in Oracle mode is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t4pnum****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

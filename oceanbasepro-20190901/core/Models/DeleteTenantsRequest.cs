// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteTenantsRequest : TeaModel {
        /// <summary>
        /// <para>You can call this operation to delete one or more tenants from an OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DeleteTenants
        /// &amp;TenantIds=[&quot;ob2mr3oae0****&quot;, &quot;ob2mr3oae1****&quot;]
        /// &amp;InstanceId=ob317v4uif****
        /// &amp;Common request parameters
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ob2mr3oae0****&quot;, &quot;ob2mr3oae1****&quot;]</para>
        /// </summary>
        [NameInMap("TenantIds")]
        [Validation(Required=false)]
        public string TenantIds { get; set; }

    }

}

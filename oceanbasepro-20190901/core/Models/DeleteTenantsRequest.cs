// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteTenantsRequest : TeaModel {
        /// <summary>
        /// You can call this operation to delete one or more tenants from an OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=DeleteTenants
        /// &TenantIds=["ob2mr3oae0****", "ob2mr3oae1****"]
        /// &InstanceId=ob317v4uif****
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("TenantIds")]
        [Validation(Required=false)]
        public string TenantIds { get; set; }

    }

}

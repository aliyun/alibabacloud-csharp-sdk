// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteTenantsRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The list of tenant IDs.   
        /// It is a JSON array. Each object in the array is a tenant name string.
        /// </summary>
        [NameInMap("TenantIds")]
        [Validation(Required=false)]
        public string TenantIds { get; set; }

    }

}

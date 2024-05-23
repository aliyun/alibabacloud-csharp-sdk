// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantZonesReadRequest : TeaModel {
        /// <summary>
        /// The zone information of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The return result of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

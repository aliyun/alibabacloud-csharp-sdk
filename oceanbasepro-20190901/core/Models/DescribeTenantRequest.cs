// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantRequest : TeaModel {
        /// <summary>
        /// The status of the Internet address for accessing the tenant. Valid values:   
        /// - CLOSED: The address is disabled.   
        /// - ALLOCATING_INTERNET_ADDRESS: An address is being applied for.   
        /// - PENDING_OFFLINE_INTERNET_ADDRESS: The address is being disabled.   
        /// - ONLINE: The address is in service.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Indicates whether to enable transaction splitting.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

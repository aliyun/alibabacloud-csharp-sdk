// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DeleteTenantSecurityIpGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The group name of the whitelist group of IP addresses.
        /// 
        /// It starts with lowercase letters and ends with lowercase letters or numbers. It can only contain lowercase letters, numbers, and underscores, and should be 2~32 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

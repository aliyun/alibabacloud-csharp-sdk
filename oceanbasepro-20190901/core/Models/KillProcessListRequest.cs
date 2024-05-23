// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class KillProcessListRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The list of the sessions that need to be closed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SessionList")]
        [Validation(Required=false)]
        public string SessionList { get; set; }

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

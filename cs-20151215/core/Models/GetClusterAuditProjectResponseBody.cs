// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAuditProjectResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the cluster auditing feature is enabled for the cluster. `true`: The cluster auditing feature is enabled for the cluster. `false`: The cluster auditing feature is disabled for the cluster.
        /// </summary>
        [NameInMap("audit_enabled")]
        [Validation(Required=false)]
        public bool? AuditEnabled { get; set; }

        /// <summary>
        /// The SLS project in which the audit logs of the API server are stored.
        /// </summary>
        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}

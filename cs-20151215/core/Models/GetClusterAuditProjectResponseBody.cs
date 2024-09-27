// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAuditProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the cluster auditing feature is enabled for the cluster. <c>true</c>: The cluster auditing feature is enabled for the cluster. <c>false</c>: The cluster auditing feature is disabled for the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("audit_enabled")]
        [Validation(Required=false)]
        public bool? AuditEnabled { get; set; }

        /// <summary>
        /// <para>The SLS project in which the audit logs of the API server are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-cad1230511cbb4db4a488e58518******</para>
        /// </summary>
        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}

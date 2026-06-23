// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAuditProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the API server audit feature is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Not enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("audit_enabled")]
        [Validation(Required=false)]
        public bool? AuditEnabled { get; set; }

        /// <summary>
        /// <para>The SLS project that stores the API server audit logs of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-cad1230511cbb4db4a488e58518******</para>
        /// </summary>
        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}

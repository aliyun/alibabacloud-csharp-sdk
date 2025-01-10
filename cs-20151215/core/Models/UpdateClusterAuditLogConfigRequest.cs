// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateClusterAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Enable or disable audit logging.</para>
        /// <list type="bullet">
        /// <item><description>false: enables audit logging or updates the audit logging configurations.</description></item>
        /// <item><description>true: disables audit logging.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">Simple Log Service project</a> to which the <a href="https://help.aliyun.com/document_detail/48873.html">Logstore</a> that stores the cluster audit logs belongs.</para>
        /// <list type="bullet">
        /// <item><description>Default value: k8s-log-{clusterid}.</description></item>
        /// <item><description>After the cluster audit log feature is enabled, a Logstore is created in the specified SLS project to store the cluster audit logs.</description></item>
        /// <item><description>If you want to change the project after audit logging is enabled for the cluster, you can use this parameter to specify another project. You can perform this operation only in ACK managed clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-log-c82e6987e2961451182edacd74faf****</para>
        /// </summary>
        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateClusterAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the cluster audit log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: enables the audit log feature or updates the audit log configuration.</para>
        /// </description></item>
        /// <item><description><para>true: disables the audit log feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS Project</a> that contains the <a href="https://help.aliyun.com/document_detail/48874.html">Logstore</a> for cluster audit logs.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: k8s-log-{clusterid}.</para>
        /// </description></item>
        /// <item><description><para>After you enable the cluster audit log feature, a Logstore for cluster audit logs is created in the specified SLS Project.</para>
        /// </description></item>
        /// <item><description><para>If you need to change the SLS Project after enabling the cluster audit log feature, use this parameter to specify a new SLS Project. Only ACK managed clusters support changing the SLS Project.</para>
        /// </description></item>
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

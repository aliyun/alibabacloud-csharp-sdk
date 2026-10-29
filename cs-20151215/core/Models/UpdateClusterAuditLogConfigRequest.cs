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
        /// <item><description>false: enables the audit log feature or updates the audit log configurations.</description></item>
        /// <item><description>true: disables the audit log feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/48873.html">SLS project</a> where the <a href="https://help.aliyun.com/document_detail/48874.html">Logstore</a> for cluster audit logs is located.</para>
        /// <list type="bullet">
        /// <item><description><para>The default value is k8s-log-{clusterid}.</para>
        /// </description></item>
        /// <item><description><para>After you enable the cluster audit log feature, a Logstore for cluster audit logs is created in the specified SLS project.</para>
        /// </description></item>
        /// <item><description><para>If you need to change the SLS project after enabling the cluster audit log feature, you can use this parameter to specify a new SLS project. Only ACK managed clusters support changing the SLS project.</para>
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

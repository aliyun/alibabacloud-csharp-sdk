// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateClusterAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Enable or disable the audit log feature.</para>
        /// <list type="bullet">
        /// <item><description>false: enables the audit log feature or updates the audit log configuration.</description></item>
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
        /// <para>The <a href="https://help.aliyun.com/zh/sls/product-overview/project?spm=a2c4g.11186623.0.i3">SLS project</a> to which the <a href="https://help.aliyun.com/zh/sls/product-overview/logstore?spm=a2c4g.11186623.0.0.48287ce0jAUWWM">Logstore</a> belongs.</para>
        /// <list type="bullet">
        /// <item><description>Default value: k8s-log-{clusterid}.</description></item>
        /// <item><description>After the cluster audit log feature is enabled, a Logstore is created in the specified SLS project to store the cluster audit logs.</description></item>
        /// <item><description>If you want to change the project after the cluster audit log feature is enabled, you can use this parameter to specify another SLS project. You can perform this operation only in ACK managed clusters.</description></item>
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

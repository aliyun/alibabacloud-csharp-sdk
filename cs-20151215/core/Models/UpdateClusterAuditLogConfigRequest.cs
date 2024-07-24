// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateClusterAuditLogConfigRequest : TeaModel {
        /// <summary>
        /// Enable or disable the audit log feature.
        /// 
        /// *   false: enables the audit log feature or updates the audit log configuration.
        /// *   true: disables the audit log feature.
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public bool? Disable { get; set; }

        /// <summary>
        /// The [SLS project](https://help.aliyun.com/zh/sls/product-overview/project?spm=a2c4g.11186623.0.i3) to which the [Logstore](https://help.aliyun.com/zh/sls/product-overview/logstore?spm=a2c4g.11186623.0.0.48287ce0jAUWWM) belongs.
        /// 
        /// *   Default value: k8s-log-{clusterid}.
        /// *   After the cluster audit log feature is enabled, a Logstore is created in the specified SLS project to store the cluster audit logs.
        /// *   If you want to change the project after the cluster audit log feature is enabled, you can use this parameter to specify another SLS project. You can perform this operation only in ACK managed clusters.
        /// </summary>
        [NameInMap("sls_project_name")]
        [Validation(Required=false)]
        public string SlsProjectName { get; set; }

    }

}

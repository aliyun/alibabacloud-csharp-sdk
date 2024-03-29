// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionResponseBody : TeaModel {
        /// <summary>
        /// The latest version of the database engine.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The release note of the kernel version.
        /// </summary>
        [NameInMap("DBLatestVersion")]
        [Validation(Required=false)]
        public string DBLatestVersion { get; set; }

        /// <summary>
        /// The versions to which the cluster can be upgraded.
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// The version of PolarProxy.
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// The minor version of the database engine.
        /// 
        /// *   If `DBVersion` is **8.0**, the valid values of this parameter are:
        /// 
        ///     *   **8.0.2**
        ///     *   **8.0.1**
        /// 
        /// *   If `DBVersion` is **5.7**, set the value of this parameter to **5.7.28**.
        /// 
        /// *   If `DBVersion` is **5.6**, the value of this parameter is **5.6.16**.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The latest version of PolarProxy.
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// The status of the minor version. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// 
        /// > For more information about how to upgrade the minor version, see [Upgrade versions](~~158572~~).
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public string IsProxyLatestVersion { get; set; }

        /// <summary>
        /// The revision version of the database engine.
        /// </summary>
        [NameInMap("ProxyLatestVersion")]
        [Validation(Required=false)]
        public string ProxyLatestVersion { get; set; }

        /// <summary>
        /// The release status of the kernel version. Valid values:
        /// 
        /// *   **Stable**: The kernel version is stable.
        /// *   **Old**: The kernel version is old. We recommend that you do not upgrade the cluster to this version returned for this parameter.
        /// *   **HighRisk**: The kernel version has critical defects. We recommend that you do not upgrade the cluster to this version returned for this parameter.
        /// </summary>
        [NameInMap("ProxyRevisionVersion")]
        [Validation(Required=false)]
        public string ProxyRevisionVersion { get; set; }

        /// <summary>
        /// The code of the revision version of the database engine to which the cluster can be upgraded.
        /// </summary>
        [NameInMap("ProxyVersionStatus")]
        [Validation(Required=false)]
        public string ProxyVersionStatus { get; set; }

        /// <summary>
        /// The status of PolarProxy. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// *   **Beta**: The minor version is a beta version.
        /// 
        /// > For more information about how to upgrade the PolarProxy version, see [Upgrade versions](~~158572~~).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

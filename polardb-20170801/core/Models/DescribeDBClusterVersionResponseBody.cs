// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The latest version of the database engine.
        /// </summary>
        [NameInMap("DBLatestVersion")]
        [Validation(Required=false)]
        public string DBLatestVersion { get; set; }

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
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// The revision version of the database engine.
        /// 
        /// > For a cluster of the PolarDB for MySQL 5.6, the `DBRevisionVersion` parameter returns the revision version information only if the revision version is released later than August 31, 2020. Otherwise, this parameter returns an empty value. For more information about the kernel version of a cluster that runs the PolarDB for MySQL, see [PolarDB for MySQL](~~423884~~).
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        /// <summary>
        /// 可升级的版本信息列表。
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// 版本发布说明。
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// 数据库版本发布状态。取值范围如下：
            /// * **Stable**：当前版本状态稳定。
            /// * **Old**：当前版本过旧，不建议升级到该版本。
            /// * **HighRisk**：当前版本有严重缺陷，不建议升级到该版本。
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// 数据库引擎的修订版本Code，用于指定升级到该目标版本。
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// 数据库引擎的修订版本号。
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// The major version of the database engine. Valid values:
        /// 
        /// *   **8.0**
        /// *   **5.7**
        /// *   **5.6**
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The status of the minor version. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// 
        /// > For more information about how to upgrade the minor version, see [Upgrade versions](~~158572~~).
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// Indicates whether the kernel version is the latest version. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// Indicates whether PolarProxy is the latest version. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public string IsProxyLatestVersion { get; set; }

        /// <summary>
        /// The latest version of PolarProxy.
        /// </summary>
        [NameInMap("ProxyLatestVersion")]
        [Validation(Required=false)]
        public string ProxyLatestVersion { get; set; }

        /// <summary>
        /// The version of PolarProxy.
        /// </summary>
        [NameInMap("ProxyRevisionVersion")]
        [Validation(Required=false)]
        public string ProxyRevisionVersion { get; set; }

        /// <summary>
        /// The status of PolarProxy. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// 
        /// > For more information about how to upgrade the PolarProxy version, see [Upgrade versions](~~158572~~).
        /// </summary>
        [NameInMap("ProxyVersionStatus")]
        [Validation(Required=false)]
        public string ProxyVersionStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

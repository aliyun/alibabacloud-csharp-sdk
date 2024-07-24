// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionResponseBody : TeaModel {
        /// <summary>
        /// The ID of cluster.
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
        /// - If DBVersion is 8.0, the valid values of this parameter are:
        ///   - 8.0.2
        ///   - 8.0.1
        /// - If DBVersion is 5.7, set the value of this parameter to 5.7.28.
        /// - If DBVersion is 5.6, the value of this parameter is 5.6.16.
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// The revision version of the database engine.
        /// >For a cluster of the PolarDB for MySQL 5.6, the DBRevisionVersion parameter returns the revision version information only if the Revision Version is released later than August 31, 2020. Otherwise, this parameter returns an empty value.
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// The release notes for the database engine revision version.
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The release status of the database engine revision version. Valid values:
            /// 
            /// *   **Stable**: The database engine revision version is stable.
            /// *   **Old**: The database engine revision version is outdated. We recommend that you do not update the database engine to this revision version.
            /// *   **HighRisk**: The database engine revision version has critical defects. We recommend that you do not update the database engine to this revision version.
            /// *   **Beta**: The database engine revision version is a Beta version.
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// The code of the database engine revision version. You can use the code to specify the database engine revision version.
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// The database engine revision version number.
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// - 5.6
        /// - 5.7
        /// - 8.0
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// The status of the minor version. Valid values:
        /// 
        /// *   **Stable**: The minor version is stable.
        /// *   **Old**: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// *   **HighRisk**: The minor version has critical defects. We recommend that you immediately update the cluster to the latest minor version.
        /// 
        /// >  For more information about how to update the minor version, see [Minor version update](https://help.aliyun.com/document_detail/158572.html).
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// Indicates whether the kernel is of the latest version. Valid values:
        /// 
        /// - true
        /// - false
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// Indicates whether PolarProxy uses the latest version. Valid values:
        /// 
        /// - true
        /// - false
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
        /// The revision version of the database engine.
        /// </summary>
        [NameInMap("ProxyRevisionVersion")]
        [Validation(Required=false)]
        public string ProxyRevisionVersion { get; set; }

        /// <summary>
        /// The release status of the PolarProxy version. Valid values:
        /// 
        /// *   **Stable**: The PolarProxy revision version is stable.
        /// *   **Old**: The PolarProxy revision version is outdated. We recommend that you do not update the PolarProxy to this revision version.
        /// *   **HighRisk**: The PolarProxy revision version has critical defects. We recommend that you do not update the PolarProxy to this revision version.
        /// *   **Beta**: The PolarProxy revision version is a Beta version.
        /// </summary>
        [NameInMap("ProxyRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyProxyRevisionVersionList> ProxyRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyProxyRevisionVersionList : TeaModel {
            /// <summary>
            /// The release notes for the PolarProxy revision version.
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// The release type. Valid values:
            /// 
            /// *   **LTS**: a long-term version
            /// *   **BETA**: a preview version
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// The PolarProxy revision version code. You can use this code to specify the PolarProxy revision version.
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// The PolarProxy revision version number.
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// The status of PolarProxy. Valid values:
        /// 
        /// - Stable: The minor version is stable.
        /// - Old: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.
        /// - HighRisk: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.
        /// - Beta: The minor version is a beta version.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// An array that consists of details of the minor engine version.
        /// </summary>
        [NameInMap("MinorVersionItems")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems> MinorVersionItems { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems : TeaModel {
            /// <summary>
            /// The PostgreSQL version to which the minor engine version corresponds. For more information, see [Release notes for AliPG](~~126002~~).
            /// 
            /// > This parameter is valid only when the instance runs **PostgreSQL**.
            /// </summary>
            [NameInMap("CommunityMinorVersion")]
            [Validation(Required=false)]
            public string CommunityMinorVersion { get; set; }

            /// <summary>
            /// The database engine that corresponds to the minor engine version.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version that corresponds to the minor engine version.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// 内核版本过期状态。返回值如下：
            /// 
            /// - **vaild**：有效
            /// - **expired**：过期
            /// 
            /// > 下线状态为Offline时，表示版本已下线，此时忽略过期状态。下线状态为Online时，过期状态为expired，表示版本已超过生命周期；过期状态为vaild，表示版本仍在生命周期内。
            /// </summary>
            [NameInMap("ExpireStatus")]
            [Validation(Required=false)]
            public string ExpireStatus { get; set; }

            /// <summary>
            /// An internal parameter. You do not need to specify this parameter.
            /// </summary>
            [NameInMap("IsHotfixVersion")]
            [Validation(Required=false)]
            public bool? IsHotfixVersion { get; set; }

            /// <summary>
            /// The minor engine version.
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// The RDS edition of the instance that runs the minor engine version. Valid values:
            /// 
            /// *   **Basic**: RDS Basic Edition
            /// *   **HighAvailability**: RDS High-availability Edition
            /// *   **Finance**: RDS Enterprise Edition
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// The URL of the release notes for the minor engine version.
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
            /// The status of the minor engine version.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The tag that corresponds to the minor engine version. Valid values:
            /// 
            /// *   **pgsql_docker_image**: tag of the common instance
            /// *   **pgsql_babelfish_image**: tag of the instance for which Babelfish is enabled
            /// 
            /// > This parameter is valid only when the instance runs **PostgreSQL**.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

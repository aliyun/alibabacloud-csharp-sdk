// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        [NameInMap("DBLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyDBLatestMinorVersion DBLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyDBLatestMinorVersion : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease : TeaModel {
                [NameInMap("ReleaseInfo")]
                [Validation(Required=false)]
                public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfo ReleaseInfo { get; set; }
                public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfo : TeaModel {
                    [NameInMap("ReleaseInfoList")]
                    [Validation(Required=false)]
                    public List<DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList> ReleaseInfoList { get; set; }
                    public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList : TeaModel {
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                [NameInMap("VersionChangesLevel")]
                [Validation(Required=false)]
                public string VersionChangesLevel { get; set; }

            }

        }

        /// <summary>
        /// The release notes for the minor version of the instance, including the release date, minor version number, release type such as new feature, and description.
        /// </summary>
        [NameInMap("DBVersionRelease")]
        [Validation(Required=false)]
        public string DBVersionRelease { get; set; }

        /// <summary>
        /// Indicates whether the instance major version can be upgraded. Valid values:
        /// 
        /// *   **true**: The major version can be upgraded.
        /// *   **false**: The major version is the latest version and cannot be upgraded.
        /// 
        /// > To upgrade the major version, call the [ModifyInstanceMajorVersion](~~95259~~) operation.
        /// </summary>
        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        /// <summary>
        /// Indicates whether the instance minor version can be updated. Valid values:
        /// 
        /// *   **true**: The minor version can be updated.
        /// *   **false**: The minor version is the latest version and cannot be updated.
        /// 
        /// > To update the minor version, call the [ModifyInstanceMinorVersion](~~129381~~) operation.
        /// </summary>
        [NameInMap("EnableUpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMinorVersion { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values: **redis** and **memcache**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IsAutoUpgradeOpen")]
        [Validation(Required=false)]
        public string IsAutoUpgradeOpen { get; set; }

        /// <summary>
        /// Indicates whether the instance uses the latest minor version. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Indicates whether the instance supports the new SSL encryption feature.
        /// </summary>
        [NameInMap("IsNewSSLMode")]
        [Validation(Required=false)]
        public string IsNewSSLMode { get; set; }

        /// <summary>
        /// Indicates whether the instance runs a Redis version.
        /// </summary>
        [NameInMap("IsRedisCompatibleVersion")]
        [Validation(Required=false)]
        public string IsRedisCompatibleVersion { get; set; }

        /// <summary>
        /// Indicate whether the instance has the SSL encryption feature enabled.
        /// </summary>
        [NameInMap("IsSSLEnable")]
        [Validation(Required=false)]
        public string IsSSLEnable { get; set; }

        /// <summary>
        /// The major version of the instance.
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// The minor version of the instance.
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        [NameInMap("ProxyLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyProxyLatestMinorVersion ProxyLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyProxyLatestMinorVersion : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease : TeaModel {
                [NameInMap("ReleaseInfo")]
                [Validation(Required=false)]
                public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfo ReleaseInfo { get; set; }
                public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfo : TeaModel {
                    [NameInMap("ReleaseInfoList")]
                    [Validation(Required=false)]
                    public List<DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList> ReleaseInfoList { get; set; }
                    public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList : TeaModel {
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                [NameInMap("VersionChangesLevel")]
                [Validation(Required=false)]
                public string VersionChangesLevel { get; set; }

            }

        }

        /// <summary>
        /// The minor version of proxy nodes.
        /// 
        /// > This parameter is returned only for cluster and read/write splitting instances.
        /// </summary>
        [NameInMap("ProxyMinorVersion")]
        [Validation(Required=false)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// The release notes for the minor version of proxy nodes. The release notes include the release date, minor version number, release type such as new feature, and description.
        /// 
        /// > This parameter is returned only for cluster and read/write splitting instances.
        /// </summary>
        [NameInMap("ProxyVersionRelease")]
        [Validation(Required=false)]
        public string ProxyVersionRelease { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// 该实例当前可升级至最新的小版本信息。
        /// </summary>
        [NameInMap("DBLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyDBLatestMinorVersion DBLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyDBLatestMinorVersion : TeaModel {
            /// <summary>
            /// 版本变更的重要性，取值：
            /// * **0**：一般重要
            /// * **1**：比较重要
            /// * **2**：非常重要
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// 版本号。
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// 从实例当前小版本到最新小版本的版本演进路线，与版本文档一致，可以直接至版本说明文档查看更详细的信息。
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// 小版本信息。
                /// </summary>
                [NameInMap("ReleaseInfo")]
                [Validation(Required=false)]
                public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfo ReleaseInfo { get; set; }
                public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfo : TeaModel {
                    [NameInMap("ReleaseInfoList")]
                    [Validation(Required=false)]
                    public List<DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList> ReleaseInfoList { get; set; }
                    public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList : TeaModel {
                        /// <summary>
                        /// 实例的创建时间。
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// 重要等级。
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// 版本发布说明。
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// 可升级的版本英文描述。
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// EMR发行版。
                        /// </summary>
                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                /// <summary>
                /// 版本升级的重要性（推荐升级程度），取值：
                /// * 0：一般重要
                /// * 1：比较重要
                /// * 2：非常重要
                /// </summary>
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
        /// Indicates whether the major version can be upgraded for the instance. Valid values:
        /// 
        /// *   **true**: The major version can be upgraded.
        /// *   **false**: The major version is the latest version and cannot be upgraded.
        /// 
        /// >  To upgrade the major version, call the [ModifyInstanceMajorVersion](https://help.aliyun.com/document_detail/95259.html) operation.
        /// </summary>
        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        /// <summary>
        /// Indicates whether the minor version can be updated for the instance. Valid values:
        /// 
        /// *   **true**: The minor version can be updated.
        /// *   **false**: The minor version is the latest version and cannot be updated.
        /// 
        /// >  To update the minor version, call the [ModifyInstanceMinorVersion](https://help.aliyun.com/document_detail/129381.html) operation.
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

        /// <summary>
        /// 是否打开了小版本升级。
        /// </summary>
        [NameInMap("IsAutoUpgradeOpen")]
        [Validation(Required=false)]
        public string IsAutoUpgradeOpen { get; set; }

        /// <summary>
        /// Indicates whether the instance minor version is the latest version. Valid values:
        /// 
        /// *   **true**: The instance minor version is the latest version.
        /// *   **false**: The instance minor version is not the latest version.
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// 是否支持新版 ssl。
        /// </summary>
        [NameInMap("IsNewSSLMode")]
        [Validation(Required=false)]
        public string IsNewSSLMode { get; set; }

        [NameInMap("IsOpenNGLB")]
        [Validation(Required=false)]
        public string IsOpenNGLB { get; set; }

        /// <summary>
        /// Indicates whether the instance supports the new SSL encryption feature.
        /// </summary>
        [NameInMap("IsRedisCompatibleVersion")]
        [Validation(Required=false)]
        public string IsRedisCompatibleVersion { get; set; }

        /// <summary>
        /// 是否打开了小版本升级。
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

        /// <summary>
        /// 该Proxy节点当前可升级至最新的小版本信息。
        /// </summary>
        [NameInMap("ProxyLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyProxyLatestMinorVersion ProxyLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyProxyLatestMinorVersion : TeaModel {
            /// <summary>
            /// 版本变更的重要性，取值：
            /// * **0**：一般重要
            /// * **1**：比较重要
            /// * **2**：非常重要
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// 版本号。
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// 从实例当前小版本到最新小版本的版本演进路线，与版本文档一致，可以直接至版本说明文档查看更详细的信息。
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// 小版本信息。
                /// </summary>
                [NameInMap("ReleaseInfo")]
                [Validation(Required=false)]
                public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfo ReleaseInfo { get; set; }
                public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfo : TeaModel {
                    [NameInMap("ReleaseInfoList")]
                    [Validation(Required=false)]
                    public List<DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList> ReleaseInfoList { get; set; }
                    public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionReleaseReleaseInfoReleaseInfoList : TeaModel {
                        /// <summary>
                        /// 版本的发布时间。
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// 版本变更的重要性，取值：
                        /// * **0**：一般重要
                        /// * **1**：比较重要
                        /// * **2**：非常重要
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// 版本的变更说明。
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// 可升级的版本英文描述。
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// EMR发行版。
                        /// </summary>
                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                /// <summary>
                /// 版本升级的重要性（推荐升级程度），取值：
                /// * 0：一般重要
                /// * 1：比较重要
                /// * 2：非常重要
                /// </summary>
                [NameInMap("VersionChangesLevel")]
                [Validation(Required=false)]
                public string VersionChangesLevel { get; set; }

            }

        }

        /// <summary>
        /// The minor version of proxy nodes.
        /// 
        /// >  This parameter is returned only for cluster and read/write splitting instances.
        /// </summary>
        [NameInMap("ProxyMinorVersion")]
        [Validation(Required=false)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// The release notes for the minor version of proxy nodes. The release notes include the release date, minor version number, release type such as new feature, and description.
        /// 
        /// >  This parameter is returned only for cluster and read/write splitting instances.
        /// </summary>
        [NameInMap("ProxyVersionRelease")]
        [Validation(Required=false)]
        public string ProxyVersionRelease { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

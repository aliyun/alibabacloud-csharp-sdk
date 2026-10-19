// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the latest minor version to which the instance can be upgraded.</para>
        /// </summary>
        [NameInMap("DBLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyDBLatestMinorVersion DBLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyDBLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>The importance level of the version change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Normal.</description></item>
            /// <item><description><b>1</b>: Important.</description></item>
            /// <item><description><b>2</b>: Critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.1.4</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The version evolution path from the current minor version of the instance to the latest minor version. This is consistent with the version documentation. You can refer to the version release notes for more detailed information.</para>
            /// </summary>
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

                /// <summary>
                /// <para>The importance level of the version upgrade (recommended upgrade level). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Normal.</description></item>
                /// <item><description>1: Important.</description></item>
                /// <item><description>2: Critical.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VersionChangesLevel")]
                [Validation(Required=false)]
                public string VersionChangesLevel { get; set; }

            }

        }

        /// <summary>
        /// <para>The update notes for the minor version of the instance, including the release time, minor version number, type (such as new feature), and detailed description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;releaseInfo\&quot;:{\&quot;createTime\&quot;:\&quot;2021-07-27\&quot;,\&quot;level\&quot;:1,\&quot;releaseVersion\&quot;:\&quot;0.5.4\&quot;,\&quot;releaseNote\&quot;:\&quot;Feature update: Enhanced stability.\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
        /// </summary>
        [NameInMap("DBVersionRelease")]
        [Validation(Required=false)]
        public string DBVersionRelease { get; set; }

        /// <summary>
        /// <para>Indicates whether the major version of the instance can be upgraded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The major version can be upgraded.</description></item>
        /// <item><description><b>false</b>: The major version cannot be upgraded, usually because it is already the latest version.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To upgrade the major version, call the <a href="https://help.aliyun.com/document_detail/473776.html">ModifyInstanceMajorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the minor version of the instance can be upgraded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The minor version can be upgraded.</description></item>
        /// <item><description><b>false</b>: The minor version is already the latest and cannot be upgraded.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To upgrade the minor version, call the <a href="https://help.aliyun.com/document_detail/473777.html">ModifyInstanceMinorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values: <b>redis</b> and <b>memcache</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic minor version upgrade is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAutoUpgradeOpen")]
        [Validation(Required=false)]
        public string IsAutoUpgradeOpen { get; set; }

        /// <summary>
        /// <para>Indicates whether the minor version of the instance is the latest. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the new TLS version is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsNewSSLMode")]
        [Validation(Required=false)]
        public string IsNewSSLMode { get; set; }

        /// <summary>
        /// <para>Indicates whether NGLB mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOpenNGLB")]
        [Validation(Required=false)]
        public string IsOpenNGLB { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a Redis-compatible version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsRedisCompatibleVersion")]
        [Validation(Required=false)]
        public string IsRedisCompatibleVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsSSLEnable")]
        [Validation(Required=false)]
        public string IsSSLEnable { get; set; }

        /// <summary>
        /// <para>The major version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <para>The current minor version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis-5.0_0.5.0</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// <para>The information about the latest minor version to which the proxy node can be upgraded.</para>
        /// </summary>
        [NameInMap("ProxyLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyProxyLatestMinorVersion ProxyLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyProxyLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>The importance level of the version change. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Normal.</description></item>
            /// <item><description><b>1</b>: Important.</description></item>
            /// <item><description><b>2</b>: Critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.6</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The version evolution path from the current minor version of the instance to the latest minor version. This is consistent with the version documentation. You can refer to the version release notes for more detailed information.</para>
            /// </summary>
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

                /// <summary>
                /// <para>The importance level of the version upgrade (recommended upgrade level). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Normal.</description></item>
                /// <item><description>1: Important.</description></item>
                /// <item><description>2: Critical.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VersionChangesLevel")]
                [Validation(Required=false)]
                public string VersionChangesLevel { get; set; }

            }

        }

        /// <summary>
        /// <para>The current minor version of the proxy node.</para>
        /// <remarks>
        /// <para>This parameter is returned only for instances of the cluster or read/write splitting architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6.6.0</para>
        /// </summary>
        [NameInMap("ProxyMinorVersion")]
        [Validation(Required=false)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// <para>The update notes for the minor version of the proxy node, including the release time, minor version number, type (such as new feature), and detailed description.</para>
        /// <remarks>
        /// <para>This parameter is returned only for instances of the cluster or read/write splitting architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;releaseInfo\&quot;:[{\&quot;createTime\&quot;:\&quot;2021-06-08\&quot;,\&quot;level\&quot;:0,\&quot;releaseVersion\&quot;:\&quot;6.6.2\&quot;,\&quot;releaseNote\&quot;:\&quot;New feature: Added support for some internal commands.\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
        /// </summary>
        [NameInMap("ProxyVersionRelease")]
        [Validation(Required=false)]
        public string ProxyVersionRelease { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A52974D1-9D57-4805-86CC-92E6EDE8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

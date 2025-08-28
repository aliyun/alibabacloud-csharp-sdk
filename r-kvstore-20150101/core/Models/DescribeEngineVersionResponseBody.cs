// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The latest minor version to which the instance can be updated.</para>
        /// </summary>
        [NameInMap("DBLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyDBLatestMinorVersion DBLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyDBLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>The version update level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: regular</description></item>
            /// <item><description><b>1</b>: recommended</description></item>
            /// <item><description><b>2</b>: critical</description></item>
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
            /// <para>The version update path from the current minor version to the latest minor version of the instance, which is consistent with the version documentation. For more detailed information, you can directly refer to the release notes.</para>
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// <para>The information about the minor versions.</para>
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
                        /// <para>The creation time of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-11-21T13:28Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>The importance level.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The release notes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>netbank1022</para>
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// <para>The description of the minor versions to which the instance can be updated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ReleaseNoteEn</para>
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// <para>The release version of EMR.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EMR-5.7.0</para>
                        /// </summary>
                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                /// <summary>
                /// <para>The version update level, which indicates how strongly the update is recommended. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: regular</description></item>
                /// <item><description>1: recommended</description></item>
                /// <item><description>2: critical</description></item>
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
        /// <para>The release notes for the minor version of the instance, including the release date, minor version number, release type such as new feature, and description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;releaseInfo\&quot;:{\&quot;createTime\&quot;:\&quot;2021-07-27\&quot;,\&quot;level\&quot;:1,\&quot;releaseVersion\&quot;:\&quot;0.5.4\&quot;,\&quot;releaseNote\&quot;:\&quot;Feature optimization: The stability is improved.\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
        /// </summary>
        [NameInMap("DBVersionRelease")]
        [Validation(Required=false)]
        public string DBVersionRelease { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance major version can be upgraded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The major version can be upgraded.</description></item>
        /// <item><description><b>false</b>: The major version is the latest version and cannot be upgraded.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To upgrade the major version, call the <a href="https://help.aliyun.com/document_detail/473776.html">ModifyInstanceMajorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance minor version can be updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The minor version can be updated.</description></item>
        /// <item><description><b>false</b>: The minor version is the latest version and cannot be updated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To update the minor version, call the <a href="https://help.aliyun.com/document_detail/473777.html">ModifyInstanceMinorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values: <b>redis</b> and <b>memcache</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic minor version update is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Automatic minor version update is disabled.</description></item>
        /// <item><description><b>1</b>: Automatic minor version update is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAutoUpgradeOpen")]
        [Validation(Required=false)]
        public string IsAutoUpgradeOpen { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance uses the latest minor version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether Transport Layer Security (TLS) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: TLS is enabled.</description></item>
        /// <item><description><b>0</b>: TLS is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsNewSSLMode")]
        [Validation(Required=false)]
        public string IsNewSSLMode { get; set; }

        /// <summary>
        /// <para>Indicates whether the NGLB mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The NGLB mode is disabled.</description></item>
        /// <item><description><b>1</b>: The NGLB mode is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOpenNGLB")]
        [Validation(Required=false)]
        public string IsOpenNGLB { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance runs a Redis version.</para>
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
        /// <item><description><b>1</b>: SSL is enabled.</description></item>
        /// <item><description><b>0</b>: TLS is disabled.</description></item>
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
        /// <para>The latest minor version to which the proxy node can be updated.</para>
        /// </summary>
        [NameInMap("ProxyLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyProxyLatestMinorVersion ProxyLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyProxyLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>The version update level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: regular</description></item>
            /// <item><description><b>1</b>: recommended</description></item>
            /// <item><description><b>2</b>: critical</description></item>
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
            /// <para>The version update path from the current minor version to the latest minor version of the instance, which is consistent with the version documentation. For more detailed information, you can directly refer to the release notes.</para>
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// <para>The information about the minor versions.</para>
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
                        /// <para>The time when the version was released.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-08-23T14:26:20Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>The version update level. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: regular</description></item>
                        /// <item><description><b>1</b>: recommended</description></item>
                        /// <item><description><b>2</b>: critical</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The release notes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>x x x x</para>
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// <para>The description of the minor versions to which the instance can be updated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ReleaseNoteEn</para>
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// <para>The release version of EMR.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EMR-5.9.1</para>
                        /// </summary>
                        [NameInMap("ReleaseVersion")]
                        [Validation(Required=false)]
                        public string ReleaseVersion { get; set; }

                    }

                }

                /// <summary>
                /// <para>The version update level, which indicates how strongly the update is recommended. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: regular</description></item>
                /// <item><description>1: recommended</description></item>
                /// <item><description>2: critical</description></item>
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
        /// <para> This parameter is returned only for cluster and read/write splitting instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6.6.0</para>
        /// </summary>
        [NameInMap("ProxyMinorVersion")]
        [Validation(Required=false)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// <para>The release notes for the minor version of proxy nodes. The release notes include the release date, minor version number, release type such as new feature, and description.</para>
        /// <remarks>
        /// <para> This parameter is returned only for cluster and read/write splitting instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;releaseInfo\&quot;:[{\&quot;createTime\&quot;:\&quot;2021-06-08\&quot;,\&quot;level\&quot;:0,\&quot;releaseVersion\&quot;:\&quot;6.6.2\&quot;,\&quot;releaseNote\&quot;:\&quot;New feature: Some internal commands are supported.\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
        /// </summary>
        [NameInMap("ProxyVersionRelease")]
        [Validation(Required=false)]
        public string ProxyVersionRelease { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A52974D1-9D57-4805-86CC-92E6EDE8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

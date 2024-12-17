// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>该实例当前可升级至最新的小版本信息。</para>
        /// </summary>
        [NameInMap("DBLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyDBLatestMinorVersion DBLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyDBLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>版本变更的重要性，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：一般重要</description></item>
            /// <item><description><b>1</b>：比较重要</description></item>
            /// <item><description><b>2</b>：非常重要</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>版本号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.1.4</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>从实例当前小版本到最新小版本的版本演进路线，与版本文档一致，可以直接至版本说明文档查看更详细的信息。</para>
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyDBLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// <para>小版本信息。</para>
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
                        /// <para>实例的创建时间。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-11-21T13:28Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>重要等级。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>版本发布说明。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>发布说明</para>
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// <para>可升级的版本英文描述。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>版本升级英文描述</para>
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// <para>EMR发行版。</para>
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
                /// <para>版本升级的重要性（推荐升级程度），取值：</para>
                /// <list type="bullet">
                /// <item><description>0：一般重要</description></item>
                /// <item><description>1：比较重要</description></item>
                /// <item><description>2：非常重要</description></item>
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
        /// <para>{\&quot;releaseInfo\&quot;:{\&quot;createTime\&quot;:\&quot;2021-07-27\&quot;,\&quot;level\&quot;:1,\&quot;releaseVersion\&quot;:\&quot;0.5.4\&quot;,\&quot;releaseNote\&quot;:\&quot;功能更新：增强稳定性。\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
        /// </summary>
        [NameInMap("DBVersionRelease")]
        [Validation(Required=false)]
        public string DBVersionRelease { get; set; }

        /// <summary>
        /// <para>Indicates whether the major version can be upgraded for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The major version can be upgraded.</description></item>
        /// <item><description><b>false</b>: The major version is the latest version and cannot be upgraded.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To upgrade the major version, call the <a href="https://help.aliyun.com/document_detail/95259.html">ModifyInstanceMajorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the minor version can be updated for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The minor version can be updated.</description></item>
        /// <item><description><b>false</b>: The minor version is the latest version and cannot be updated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To update the minor version, call the <a href="https://help.aliyun.com/document_detail/129381.html">ModifyInstanceMinorVersion</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Valid values: <b>redis</b> and <b>memcache</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>是否打开了小版本升级。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAutoUpgradeOpen")]
        [Validation(Required=false)]
        public string IsAutoUpgradeOpen { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance minor version is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance minor version is the latest version.</description></item>
        /// <item><description><b>false</b>: The instance minor version is not the latest version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>是否支持新版 ssl。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsNewSSLMode")]
        [Validation(Required=false)]
        public string IsNewSSLMode { get; set; }

        [NameInMap("IsOpenNGLB")]
        [Validation(Required=false)]
        public string IsOpenNGLB { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance supports the new SSL encryption feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsRedisCompatibleVersion")]
        [Validation(Required=false)]
        public string IsRedisCompatibleVersion { get; set; }

        /// <summary>
        /// <para>是否打开了小版本升级。</para>
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
        /// <para>The minor version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis-5.0_0.5.0</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// <para>该Proxy节点当前可升级至最新的小版本信息。</para>
        /// </summary>
        [NameInMap("ProxyLatestMinorVersion")]
        [Validation(Required=false)]
        public DescribeEngineVersionResponseBodyProxyLatestMinorVersion ProxyLatestMinorVersion { get; set; }
        public class DescribeEngineVersionResponseBodyProxyLatestMinorVersion : TeaModel {
            /// <summary>
            /// <para>版本变更的重要性，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：一般重要</description></item>
            /// <item><description><b>1</b>：比较重要</description></item>
            /// <item><description><b>2</b>：非常重要</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>版本号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.0.6</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>从实例当前小版本到最新小版本的版本演进路线，与版本文档一致，可以直接至版本说明文档查看更详细的信息。</para>
            /// </summary>
            [NameInMap("VersionRelease")]
            [Validation(Required=false)]
            public DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease VersionRelease { get; set; }
            public class DescribeEngineVersionResponseBodyProxyLatestMinorVersionVersionRelease : TeaModel {
                /// <summary>
                /// <para>小版本信息。</para>
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
                        /// <para>版本的发布时间。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-08-23T14:26:20Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>版本变更的重要性，取值：</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>：一般重要</description></item>
                        /// <item><description><b>1</b>：比较重要</description></item>
                        /// <item><description><b>2</b>：非常重要</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>版本的变更说明。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>版本变更说明</para>
                        /// </summary>
                        [NameInMap("ReleaseNote")]
                        [Validation(Required=false)]
                        public string ReleaseNote { get; set; }

                        /// <summary>
                        /// <para>可升级的版本英文描述。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>版本升级英文描述</para>
                        /// </summary>
                        [NameInMap("ReleaseNoteEn")]
                        [Validation(Required=false)]
                        public string ReleaseNoteEn { get; set; }

                        /// <summary>
                        /// <para>EMR发行版。</para>
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
                /// <para>版本升级的重要性（推荐升级程度），取值：</para>
                /// <list type="bullet">
                /// <item><description>0：一般重要</description></item>
                /// <item><description>1：比较重要</description></item>
                /// <item><description>2：非常重要</description></item>
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
        /// <para>The minor version of proxy nodes.</para>
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
        /// <para>{\&quot;releaseInfo\&quot;:[{\&quot;createTime\&quot;:\&quot;2021-06-08\&quot;,\&quot;level\&quot;:0,\&quot;releaseVersion\&quot;:\&quot;6.6.2\&quot;,\&quot;releaseNote\&quot;:\&quot;新特性：增加对部分内部命令的支持。\&quot;}],\&quot;versionChangesLevel\&quot;:2}</para>
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

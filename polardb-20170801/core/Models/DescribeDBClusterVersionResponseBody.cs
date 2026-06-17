// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0.16.13.14.0</para>
        /// </summary>
        [NameInMap("DBLatestStableVersion")]
        [Validation(Required=false)]
        public string DBLatestStableVersion { get; set; }

        /// <summary>
        /// <para>The latest version of the database kernel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.16</para>
        /// </summary>
        [NameInMap("DBLatestVersion")]
        [Validation(Required=false)]
        public string DBLatestVersion { get; set; }

        /// <summary>
        /// <para>The minor version of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>DBVersion</c> is <b>8.0</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0.2</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0.1</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>DBVersion</c> is <b>5.7</b>, the value is <b>5.7.28</b>.</para>
        /// </description></item>
        /// <item><description><para>If <c>DBVersion</c> is <b>5.6</b>, the value is <b>5.6.16</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1</para>
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// <para>The revision version of the database engine.</para>
        /// <remarks>
        /// <para>For a PolarDB for MySQL 5.6 cluster, this parameter is returned only when the release date of the revision version is later than 20200831. Otherwise, this parameter is empty. For more information about the kernel version of a PolarDB for MySQL cluster, see <a href="https://help.aliyun.com/document_detail/423884.html">Kernel release notes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.7</para>
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        /// <summary>
        /// <para>A list of upgradable versions.</para>
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReleaseNote</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The release status of the database version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Stable</b>: The current version is stable.</para>
            /// </description></item>
            /// <item><description><para><b>Old</b>: The current version is outdated. Do not upgrade to this version.</para>
            /// </description></item>
            /// <item><description><para><b>HighRisk</b>: The current version has critical bugs. Do not upgrade to this version.</para>
            /// </description></item>
            /// <item><description><para><b>Beta</b>: The current version is a beta version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The revision version code of the database engine. You can use this code to specify the target version for an upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The revision version of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0.1.1.35.1</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The major version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the current minor version of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Stable</b>: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para><b>Old</b>: The current version is outdated. Upgrade to the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>HighRisk</b>: The current version has critical bugs. Upgrade to the latest version immediately.</para>
        /// </description></item>
        /// <item><description><para><b>Beta</b>: The current version is a beta version.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about how to upgrade the minor version of a database, see <a href="https://help.aliyun.com/document_detail/158572.html">Upgrade versions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestStableVersion")]
        [Validation(Required=false)]
        public string IsLatestStableVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the current database kernel version is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the current database proxy version is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public string IsProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The latest version of the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4.17</para>
        /// </summary>
        [NameInMap("ProxyLatestVersion")]
        [Validation(Required=false)]
        public string ProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The version of the database proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4.15</para>
        /// </summary>
        [NameInMap("ProxyRevisionVersion")]
        [Validation(Required=false)]
        public string ProxyRevisionVersion { get; set; }

        /// <summary>
        /// <para>A list of upgradable proxy versions.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Stable</b>: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para><b>Old</b>: This version is outdated and not recommended for upgrades.</para>
        /// </description></item>
        /// <item><description><para><b>HighRisk</b>: This version has critical bugs and is not recommended for upgrades.</para>
        /// </description></item>
        /// <item><description><para><b>Beta</b>: This is a beta version.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProxyRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyProxyRevisionVersionList> ProxyRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyProxyRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReleaseNote</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The release type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>LTS</b>: long-term support version.</para>
            /// </description></item>
            /// <item><description><para><b>BETA</b>: preview version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LTS</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The revision version code of the database proxy engine. You can use this code to specify the target version for an upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The revision version of the database proxy engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.24</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The status of the database proxy version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Stable</b>: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para><b>Old</b>: The current version is outdated. Upgrade to the latest version.</para>
        /// </description></item>
        /// <item><description><para><b>HighRisk</b>: The current version has critical bugs. Upgrade to the latest version immediately.</para>
        /// </description></item>
        /// <item><description><para><b>Beta</b>: The current version is a beta version.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about how to upgrade the database proxy version, see <a href="https://help.aliyun.com/document_detail/158572.html">Upgrade versions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("ProxyVersionStatus")]
        [Validation(Required=false)]
        public string ProxyVersionStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47921222-0D37-4133-8C0D-017DC3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

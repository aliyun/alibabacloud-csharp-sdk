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
        /// <para>The latest stable version of PolarDB for PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.16.13.14.0</para>
        /// </summary>
        [NameInMap("DBLatestStableVersion")]
        [Validation(Required=false)]
        public string DBLatestStableVersion { get; set; }

        /// <summary>
        /// <para>The latest version of the database kernel engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.16</para>
        /// </summary>
        [NameInMap("DBLatestVersion")]
        [Validation(Required=false)]
        public string DBLatestVersion { get; set; }

        /// <summary>
        /// <para>The minor version number of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>DBVersion</c> is <b>8.0</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8.0.2</b></description></item>
        /// <item><description><b>8.0.1</b></description></item>
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
        /// <para>The Milvus version number of the database engine.</para>
        /// <remarks>
        /// <para>For PolarDB for MySQL 5.6 clusters, only the <c>Milvus version</c> information with a release date later than August 31, 2020 is returned. Otherwise, this parameter is empty. For more information about the minor engine versions of PolarDB for MySQL clusters, see <a href="https://help.aliyun.com/document_detail/423884.html">Release notes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.7</para>
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        /// <summary>
        /// <para>The list of available upgrade version information.</para>
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes for the version.</para>
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
            /// <item><description><b>Stable</b>: The current version is stable.</description></item>
            /// <item><description><b>Old</b>: The current version is outdated. Upgrading to this version is not recommended.</description></item>
            /// <item><description><b>HighRisk</b>: The current version has critical bugs. Upgrading to this version is not recommended.</description></item>
            /// <item><description><b>Beta</b>: The current version is a beta version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The revision version code of the database engine, which is used to specify the target version for the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The revision version number of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0.1.1.35.1</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The major version number of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8.0</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>5.6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the current database minor version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The current version is stable.</description></item>
        /// <item><description><b>Old</b>: The current version is outdated. Upgrade to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The current version has critical bugs. Upgrade to the latest version immediately.</description></item>
        /// <item><description><b>Beta</b>: The current version is a beta version.<remarks>
        /// <para>For more information about how to upgrade the database minor version, see <a href="https://help.aliyun.com/document_detail/158572.html">Version upgrade</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the current version is the latest stable version of PolarDB for PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestStableVersion")]
        [Validation(Required=false)]
        public string IsLatestStableVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the current database kernel DPI engine version is the latest database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the current PolarProxy version is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsProxyLatestVersion")]
        [Validation(Required=false)]
        public string IsProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The latest version of PolarProxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4.17</para>
        /// </summary>
        [NameInMap("ProxyLatestVersion")]
        [Validation(Required=false)]
        public string ProxyLatestVersion { get; set; }

        /// <summary>
        /// <para>The version of PolarProxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4.15</para>
        /// </summary>
        [NameInMap("ProxyRevisionVersion")]
        [Validation(Required=false)]
        public string ProxyRevisionVersion { get; set; }

        /// <summary>
        /// <para>The release status of the PolarProxy version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The current version is stable.</description></item>
        /// <item><description><b>Old</b>: The current version is outdated. Upgrading to this version is not recommended.</description></item>
        /// <item><description><b>HighRisk</b>: The current version has critical bugs. Upgrading to this version is not recommended.</description></item>
        /// <item><description><b>Beta</b>: The current version is a beta version.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProxyRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyProxyRevisionVersionList> ProxyRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyProxyRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes for the version.</para>
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
            /// <item><description><b>LTS</b>: Long-term support version.</description></item>
            /// <item><description><b>BETA</b>: Preview version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LTS</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The revision version code of the PolarProxy engine, which is used to specify the target version for the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The revision version number of the PolarProxy engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.24</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The version status of PolarProxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The current version is stable.</description></item>
        /// <item><description><b>Old</b>: The current version is outdated. Upgrade to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The current version has critical bugs. Upgrade to the latest version immediately.</description></item>
        /// <item><description><b>Beta</b>: The current version is a beta version.<remarks>
        /// <para>For more information about how to upgrade the PolarProxy version, see <a href="https://help.aliyun.com/document_detail/158572.html">Version upgrade</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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

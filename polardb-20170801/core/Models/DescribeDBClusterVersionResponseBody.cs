// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The latest version of the database engine.</para>
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
        /// <item><description>If DBVersion is 8.0, the valid values of this parameter are:<list type="bullet">
        /// <item><description>8.0.2</description></item>
        /// <item><description>8.0.1</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If DBVersion is 5.7, set the value of this parameter to 5.7.28.</description></item>
        /// <item><description>If DBVersion is 5.6, the value of this parameter is 5.6.16.</description></item>
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
        /// <para>For a cluster of the PolarDB for MySQL 5.6, the DBRevisionVersion parameter returns the revision version information only if the Revision Version is released later than August 31, 2020. Otherwise, this parameter returns an empty value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.7</para>
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        /// <summary>
        /// <para>The versions to which the cluster can be upgraded.</para>
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes for the database engine revision version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReleaseNote</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The release status of the database engine revision version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Stable</b>: The database engine revision version is stable.</description></item>
            /// <item><description><b>Old</b>: The database engine revision version is outdated. We recommend that you do not update the database engine to this revision version.</description></item>
            /// <item><description><b>HighRisk</b>: The database engine revision version has critical defects. We recommend that you do not update the database engine to this revision version.</description></item>
            /// <item><description><b>Beta</b>: The database engine revision version is a Beta version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The code of the database engine revision version. You can use the code to specify the database engine revision version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The database engine revision version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0.1.1.35.1</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5.6</description></item>
        /// <item><description>5.7</description></item>
        /// <item><description>8.0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the minor version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Stable</b>: The minor version is stable.</description></item>
        /// <item><description><b>Old</b>: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.</description></item>
        /// <item><description><b>HighRisk</b>: The minor version has critical defects. We recommend that you immediately update the cluster to the latest minor version.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about how to update the minor version, see <a href="https://help.aliyun.com/document_detail/158572.html">Minor version update</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("DBVersionStatus")]
        [Validation(Required=false)]
        public string DBVersionStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the kernel is of the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public string IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether PolarProxy uses the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
        /// <para>The revision version of the database engine.</para>
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
        /// <item><description><b>Stable</b>: The PolarProxy revision version is stable.</description></item>
        /// <item><description><b>Old</b>: The PolarProxy revision version is outdated. We recommend that you do not update the PolarProxy to this revision version.</description></item>
        /// <item><description><b>HighRisk</b>: The PolarProxy revision version has critical defects. We recommend that you do not update the PolarProxy to this revision version.</description></item>
        /// <item><description><b>Beta</b>: The PolarProxy revision version is a Beta version.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProxyRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionResponseBodyProxyRevisionVersionList> ProxyRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionResponseBodyProxyRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes for the PolarProxy revision version.</para>
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
            /// <item><description><b>LTS</b>: a long-term version</description></item>
            /// <item><description><b>BETA</b>: a preview version</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LTS</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The PolarProxy revision version code. You can use this code to specify the PolarProxy revision version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The PolarProxy revision version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.8.24</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The status of PolarProxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Stable: The minor version is stable.</description></item>
        /// <item><description>Old: The minor version is outdated. We recommend that you upgrade the cluster to the latest version.</description></item>
        /// <item><description>HighRisk: The minor version has critical defects. We recommend that you immediately upgrade the cluster to the latest version.</description></item>
        /// <item><description>Beta: The minor version is a beta version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stable</para>
        /// </summary>
        [NameInMap("ProxyVersionStatus")]
        [Validation(Required=false)]
        public string ProxyVersionStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47921222-0D37-4133-8C0D-017DC3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

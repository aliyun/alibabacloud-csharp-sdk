// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterVersionZonalResponseBody : TeaModel {
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
        /// <item><description><para>If <c>DBVersion</c> is <b>8.0</b>, the valid values are:</para>
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
        /// <para>The patch version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1.1.7</para>
        /// </summary>
        [NameInMap("DBRevisionVersion")]
        [Validation(Required=false)]
        public string DBRevisionVersion { get; set; }

        /// <summary>
        /// <para>The list of upgradable versions.</para>
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionZonalResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionZonalResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes.</para>
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
            /// <para>The code of the patch version for the database engine. Use this code to specify the target version for an upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The patch version of the database engine.</para>
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
        /// <item><description><para>8.0</para>
        /// </description></item>
        /// <item><description><para>5.7</para>
        /// </description></item>
        /// <item><description><para>5.6</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The status of the current minor version of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Stable: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para>Old: The current version is outdated. Upgrade to the latest version.</para>
        /// </description></item>
        /// <item><description><para>HighRisk: The current version has critical bugs. Upgrade to the latest version immediately.</para>
        /// </description></item>
        /// <item><description><para>Beta: The current version is a beta version.</para>
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
        /// <para>Indicates whether the current database kernel version is the latest version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <para>The list of upgradable database proxy versions.</para>
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
        /// </summary>
        [NameInMap("ProxyRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterVersionZonalResponseBodyProxyRevisionVersionList> ProxyRevisionVersionList { get; set; }
        public class DescribeDBClusterVersionZonalResponseBodyProxyRevisionVersionList : TeaModel {
            /// <summary>
            /// <para>The release notes.</para>
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
            /// <item><description><para><b>LTS</b>: Long-Term Support (LTS) version.</para>
            /// </description></item>
            /// <item><description><para><b>BETA</b>: Preview version.</para>
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
            /// <para>The code of the patch version for the database proxy. Use this code to specify the target version for an upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The patch version of the database proxy.</para>
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
        /// <item><description><para>Stable: The current version is stable.</para>
        /// </description></item>
        /// <item><description><para>Old: The current version is outdated. Upgrade to the latest version.</para>
        /// </description></item>
        /// <item><description><para>HighRisk: The current version has critical bugs. Upgrade to the latest version immediately.</para>
        /// </description></item>
        /// <item><description><para>Beta: The current version is a beta version.</para>
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

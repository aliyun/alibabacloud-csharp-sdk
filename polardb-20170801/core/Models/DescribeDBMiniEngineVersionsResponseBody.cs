// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBMiniEngineVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of information about the versions available for an upgrade.</para>
        /// </summary>
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyDBRevisionVersionList : TeaModel {
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
            /// <para>The release state of the database version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Stable</b>: The version is stable.</para>
            /// </description></item>
            /// <item><description><para><b>Old</b>: The version is outdated. Upgrading to this version is not recommended.</para>
            /// </description></item>
            /// <item><description><para><b>HighRisk</b>: The version has a critical bug. Upgrading to this version is not recommended.</para>
            /// </description></item>
            /// <item><description><para><b>Beta</b>: The version is a beta version.</para>
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
            /// <para>The code of the database engine revision version. Use this code to specify the target version for an upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <para>The number of the database engine revision version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0.1.1.35.1</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

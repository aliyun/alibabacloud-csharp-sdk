// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationAvailableVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.2</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<DescribeApplicationAvailableVersionResponseBodyVersions> Versions { get; set; }
        public class DescribeApplicationAvailableVersionResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The release date in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            /// <summary>
            /// <para>The release notes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The release type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.2</para>
            /// </summary>
            [NameInMap("VersionDescription")]
            [Validation(Required=false)]
            public string VersionDescription { get; set; }

        }

    }

}

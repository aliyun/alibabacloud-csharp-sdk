// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBMiniEngineVersionsResponseBody : TeaModel {
        [NameInMap("DBRevisionVersionList")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyDBRevisionVersionList> DBRevisionVersionList { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyDBRevisionVersionList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ReleaseNote</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20230707</para>
            /// </summary>
            [NameInMap("RevisionVersionCode")]
            [Validation(Required=false)]
            public string RevisionVersionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.0.1.1.35.1</para>
            /// </summary>
            [NameInMap("RevisionVersionName")]
            [Validation(Required=false)]
            public string RevisionVersionName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

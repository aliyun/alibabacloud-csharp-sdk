// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The versions.
        /// </summary>
        [NameInMap("releaseVersions")]
        [Validation(Required=false)]
        public List<ListReleaseVersionsResponseBodyReleaseVersions> ReleaseVersions { get; set; }
        public class ListReleaseVersionsResponseBodyReleaseVersions : TeaModel {
            /// <summary>
            /// The version number of open source Spark.
            /// </summary>
            [NameInMap("communityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

            /// <summary>
            /// The CPU architectures.
            /// </summary>
            [NameInMap("cpuArchitectures")]
            [Validation(Required=false)]
            public List<string> CpuArchitectures { get; set; }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// Indicates whether the Fusion engine is used for acceleration.
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The type of the Infrastructure as a Service (IaaS) layer.
            /// </summary>
            [NameInMap("iaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// The version of Scala.
            /// </summary>
            [NameInMap("scalaVersion")]
            [Validation(Required=false)]
            public string ScalaVersion { get; set; }

            /// <summary>
            /// The status of the version.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The type of the version.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

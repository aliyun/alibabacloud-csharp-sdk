// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The versions.</para>
        /// </summary>
        [NameInMap("releaseVersions")]
        [Validation(Required=false)]
        public List<ListReleaseVersionsResponseBodyReleaseVersions> ReleaseVersions { get; set; }
        public class ListReleaseVersionsResponseBodyReleaseVersions : TeaModel {
            /// <summary>
            /// <para>The version number of open source Spark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Spark 3.3.1</para>
            /// </summary>
            [NameInMap("communityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

            /// <summary>
            /// <para>The CPU architectures.</para>
            /// </summary>
            [NameInMap("cpuArchitectures")]
            [Validation(Required=false)]
            public List<string> CpuArchitectures { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-2.1 (Spark 3.3.1, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the Fusion engine is used for acceleration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716215854101</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The type of the Infrastructure as a Service (IaaS) layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASI</para>
            /// </summary>
            [NameInMap("iaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-2.1 (Spark 3.3.1, Scala 2.12, Java Runtime)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The version of Scala.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.12</para>
            /// </summary>
            [NameInMap("scalaVersion")]
            [Validation(Required=false)]
            public string ScalaVersion { get; set; }

            /// <summary>
            /// <para>The status of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The type of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stable</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

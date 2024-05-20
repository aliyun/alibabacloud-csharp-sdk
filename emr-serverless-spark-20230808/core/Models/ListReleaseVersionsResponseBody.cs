// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsResponseBody : TeaModel {
        /// <summary>
        /// 一次获取的最大记录数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 下一页TOKEN。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("releaseVersions")]
        [Validation(Required=false)]
        public List<ListReleaseVersionsResponseBodyReleaseVersions> ReleaseVersions { get; set; }
        public class ListReleaseVersionsResponseBodyReleaseVersions : TeaModel {
            [NameInMap("communityVersion")]
            [Validation(Required=false)]
            public string CommunityVersion { get; set; }

            [NameInMap("cpuArchitectures")]
            [Validation(Required=false)]
            public List<string> CpuArchitectures { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("iaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            [NameInMap("scalaVersion")]
            [Validation(Required=false)]
            public string ScalaVersion { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 记录总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

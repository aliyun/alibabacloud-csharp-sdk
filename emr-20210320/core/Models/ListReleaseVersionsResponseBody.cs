// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListReleaseVersionsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Returns the location of the data that was read.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ReleaseVersions")]
        [Validation(Required=false)]
        public List<ListReleaseVersionsResponseBodyReleaseVersions> ReleaseVersions { get; set; }
        public class ListReleaseVersionsResponseBodyReleaseVersions : TeaModel {
            /// <summary>
            /// IaaS类型。取值范围：
            /// - ECS：基于ECS构建。
            /// - K8S：基于K8S构建。
            /// </summary>
            [NameInMap("IaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            /// <summary>
            /// EMR发行版。
            /// </summary>
            [NameInMap("ReleaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// 版本序列。
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

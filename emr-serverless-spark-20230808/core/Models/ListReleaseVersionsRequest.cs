// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the version.
        /// 
        /// Valid values:
        /// 
        /// *   stable
        /// *   Beta
        /// </summary>
        [NameInMap("releaseType")]
        [Validation(Required=false)]
        public string ReleaseType { get; set; }

        /// <summary>
        /// The version of EMR Serverless Spark.
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// The status of the version.
        /// 
        /// Valid values:
        /// 
        /// *   ONLINE
        /// *   OFFLINE
        /// </summary>
        [NameInMap("releaseVersionStatus")]
        [Validation(Required=false)]
        public string ReleaseVersionStatus { get; set; }

        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

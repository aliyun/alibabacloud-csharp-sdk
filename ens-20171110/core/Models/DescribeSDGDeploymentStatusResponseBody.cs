// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGDeploymentStatusResponseBody : TeaModel {
        /// <summary>
        /// The deployment information of the SDG.
        /// </summary>
        [NameInMap("DeploymentStatus")]
        [Validation(Required=false)]
        public List<DescribeSDGDeploymentStatusResponseBodyDeploymentStatus> DeploymentStatus { get; set; }
        public class DescribeSDGDeploymentStatusResponseBodyDeploymentStatus : TeaModel {
            /// <summary>
            /// The ID of the AIC instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The deployment type.
            /// 
            /// Valid values:
            /// 
            /// *   overlay: read/write splitting.
            /// *   common: common deployment.
            /// </summary>
            [NameInMap("MountType")]
            [Validation(Required=false)]
            public string MountType { get; set; }

            /// <summary>
            /// The ID of the edge node.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// the deployment status of the shared data group SDG.
            /// 
            /// Valid values:
            /// 
            /// *   sdg_deploying
            /// *   success
            /// *   failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the status was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of queried deployment records.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

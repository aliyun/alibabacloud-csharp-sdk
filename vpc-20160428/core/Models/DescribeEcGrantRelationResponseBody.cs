// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEcGrantRelationResponseBody : TeaModel {
        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The query results.
        /// </summary>
        [NameInMap("EcGrantRelations")]
        [Validation(Required=false)]
        public List<DescribeEcGrantRelationResponseBodyEcGrantRelations> EcGrantRelations { get; set; }
        public class DescribeEcGrantRelationResponseBodyEcGrantRelations : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the VPC belongs.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The time when permissions on the VPC were granted to the VBR.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The VBRs that have permissions on the VPC. Valid values:
            /// 
            /// *   **All**: VBRs that reside in the specified region and belong to the specified Alibaba Cloud account all have permissions on the VPC.
            /// *   **Specify**: Only the specified VBR has permissions on the VPC.
            /// </summary>
            [NameInMap("GrantType")]
            [Validation(Required=false)]
            public string GrantType { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the vRouter.
            /// </summary>
            [NameInMap("InstanceRouterId")]
            [Validation(Required=false)]
            public string InstanceRouterId { get; set; }

            /// <summary>
            /// The ID of the region where the VPC is deployed.
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// The query result. Valid values:
            /// 
            /// *   **Created**: The VBR has permissions on the VPC.
            /// *   **Deleted**: The VBR does not have permissions on the VPC.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the VBR.
            /// </summary>
            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the VBR belongs.
            /// </summary>
            [NameInMap("VbrOwnerUid")]
            [Validation(Required=false)]
            public long? VbrOwnerUid { get; set; }

            /// <summary>
            /// The ID of the region where the VBR is deployed.
            /// </summary>
            [NameInMap("VbrRegionNo")]
            [Validation(Required=false)]
            public string VbrRegionNo { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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

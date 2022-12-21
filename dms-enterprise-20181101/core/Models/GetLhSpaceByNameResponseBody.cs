// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLhSpaceByNameResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The workspace for data warehouse development.
        /// </summary>
        [NameInMap("LakehouseSpace")]
        [Validation(Required=false)]
        public GetLhSpaceByNameResponseBodyLakehouseSpace LakehouseSpace { get; set; }
        public class GetLhSpaceByNameResponseBodyLakehouseSpace : TeaModel {
            /// <summary>
            /// The ID of the user who creates the workspace.
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// The description of the workspace.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the development database.
            /// </summary>
            [NameInMap("DevDbId")]
            [Validation(Required=false)]
            public int? DevDbId { get; set; }

            /// <summary>
            /// The type of the database. Valid values:
            /// 
            /// *   **14**: AnalyticDB for MySQL
            /// *   **18**: AnalyticDB for PostgreSQL
            /// </summary>
            [NameInMap("DwDbType")]
            [Validation(Required=false)]
            public string DwDbType { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the workspace is deleted. Valid values:
            /// 
            /// *   **true**: The workspace is deleted.
            /// *   **false**: The workspace is not deleted.
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// The mode in which the workspace runs. Valid values:
            /// 
            /// *   **0**: basic mode
            /// *   **1**: standard mode
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// The ID of the production database.
            /// </summary>
            [NameInMap("ProdDbId")]
            [Validation(Required=false)]
            public int? ProdDbId { get; set; }

            /// <summary>
            /// The configuration of the workspace. Valid values:
            /// 
            /// *   **skipManualRunCheck**: No security rule check is required in the trial run phase.
            /// *   **skipPublishApprove**: No approval is required for publishing and O\&M.
            /// </summary>
            [NameInMap("SpaceConfig")]
            [Validation(Required=false)]
            public string SpaceConfig { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("SpaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// The ID of the tenant to which the workspace belongs.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

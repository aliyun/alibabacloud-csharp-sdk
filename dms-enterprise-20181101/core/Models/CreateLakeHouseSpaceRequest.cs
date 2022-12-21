// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateLakeHouseSpaceRequest : TeaModel {
        /// <summary>
        /// The description of the workspace.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the development database. You can call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("DevDbId")]
        [Validation(Required=false)]
        public string DevDbId { get; set; }

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
        /// The mode in which the workspace runs. Valid values:
        /// 
        /// *   **0**: basic mode. This mode is unavailable.
        /// *   **1**: standard mode.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The ID of the production database. You can call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ProdDbId")]
        [Validation(Required=false)]
        public string ProdDbId { get; set; }

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
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

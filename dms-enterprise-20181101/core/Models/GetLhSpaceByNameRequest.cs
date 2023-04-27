// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLhSpaceByNameRequest : TeaModel {
        /// <summary>
        /// Indicates whether the workspace is deleted. Valid values:
        /// 
        /// *   **true**: The workspace is deleted.
        /// *   **false**: The workspace is not deleted.
        /// </summary>
        [NameInMap("SpaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// The type of the database. Valid values:
        /// 
        /// *   **14**: AnalyticDB for MySQL
        /// *   **18**: AnalyticDB for PostgreSQL
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

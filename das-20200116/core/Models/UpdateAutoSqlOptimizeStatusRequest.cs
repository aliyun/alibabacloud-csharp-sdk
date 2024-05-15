// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoSqlOptimizeStatusRequest : TeaModel {
        /// <summary>
        /// The database instance IDs. Separate multiple IDs with commas (,).
        /// 
        /// >  You can specify up to 50 instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// The status of the automatic SQL optimization feature. Valid values:
        /// 
        /// *   **0**: The automatic SQL optimization feature is disabled.
        /// *   **1**: **SQL diagnosis and automatic index creation** is specified.
        /// *   **3**: **SQL diagnosis only** is specified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}

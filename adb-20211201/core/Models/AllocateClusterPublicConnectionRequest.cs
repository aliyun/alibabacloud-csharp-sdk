// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AllocateClusterPublicConnectionRequest : TeaModel {
        /// <summary>
        /// The prefix of the public endpoint.
        /// 
        /// *   The prefix can contain lowercase letters, digits, and hyphens (-). It must start with a lowercase letter.
        /// *   The prefix can be up to 30 characters in length.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The database engine of the cluster. Valid values:
        /// 
        /// *   **AnalyticDB** (default): the AnalyticDB for MySQL engine.
        /// *   **Clickhouse**: the wide table engine.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

    }

}

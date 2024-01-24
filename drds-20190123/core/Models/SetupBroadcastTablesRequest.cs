// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupBroadcastTablesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to activate a broadcast table for the database.
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The name of the database for which you want to configure a broadcast table.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the PolarDB-X 1.0 instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public List<string> TableName { get; set; }

    }

}

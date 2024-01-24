// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupTableRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable full table scan.
        /// </summary>
        [NameInMap("AllowFullTableScan")]
        [Validation(Required=false)]
        public bool? AllowFullTableScan { get; set; }

        /// <summary>
        /// The name of the database in which the table resides.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the streaming domain resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public List<string> TableName { get; set; }

    }

}

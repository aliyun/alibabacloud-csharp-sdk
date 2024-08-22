// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementRequest : TeaModel {
        /// <summary>
        /// The SQL code. You can specify one or more SQL statements.
        /// </summary>
        [NameInMap("codeContent")]
        [Validation(Required=false)]
        public string CodeContent { get; set; }

        /// <summary>
        /// The default Data Lake Formation (DLF) catalog ID.
        /// </summary>
        [NameInMap("defaultCatalog")]
        [Validation(Required=false)]
        public string DefaultCatalog { get; set; }

        /// <summary>
        /// The name of the default database.
        /// </summary>
        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Valid values: 1 to 10000.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The SQL compute ID. You can create an SQL compute in the workspace created in EMR Serverless Spark.
        /// </summary>
        [NameInMap("sqlComputeId")]
        [Validation(Required=false)]
        public string SqlComputeId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

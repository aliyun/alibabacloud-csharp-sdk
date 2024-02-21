// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSynDbsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        /// The information about data synchronization between the ApsaraDB for ClickHouse cluster and an ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("SynDbs")]
        [Validation(Required=false)]
        public List<DescribeSynDbsResponseBodySynDbs> SynDbs { get; set; }
        public class DescribeSynDbsResponseBodySynDbs : TeaModel {
            /// <summary>
            /// *   When the value **true** is returned for the **SynStatus** parameter, the system does not return the ErrorMsg parameter.
            /// *   When the value **false** is returned for the **SynStatus** parameter, the system returns for the ErrorMsg parameter the cause why the data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// The ID of the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            /// <summary>
            /// The database account that is used to log on to the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("RdsUserName")]
            [Validation(Required=false)]
            public string RdsUserName { get; set; }

            /// <summary>
            /// The internal endpoint of the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("RdsVpcUrl")]
            [Validation(Required=false)]
            public string RdsVpcUrl { get; set; }

            /// <summary>
            /// The name of the database in the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("SynDb")]
            [Validation(Required=false)]
            public string SynDb { get; set; }

            /// <summary>
            /// Indicates whether the data synchronization succeeded. Valid values:
            /// 
            /// *   **true**: The data synchronization succeeded.
            /// *   **false**: The data synchronization failed.
            /// </summary>
            [NameInMap("SynStatus")]
            [Validation(Required=false)]
            public bool? SynStatus { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

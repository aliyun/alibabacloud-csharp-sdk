// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRequestDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRequestDiagnosisResultResponseBodyData Data { get; set; }
        public class GetRequestDiagnosisResultResponseBodyData : TeaModel {
            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("dbSchema")]
            [Validation(Required=false)]
            public string DbSchema { get; set; }

            /// <summary>
            /// The database engine. Valid values:
            /// 
            /// *   **MySQL**
            /// *   **PostgreSQL**
            /// *   **SQLServer**
            /// *   **PolarDBMySQL**
            /// *   **PolarDBOracle**
            /// *   **MongoDB**
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The time when the SQL diagnostics task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the SQL diagnostics task was modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The unique ID of the diagnostics task.
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// The result of the SQL diagnostics task. The result includes the following information:
            /// 
            /// *   **endTime**: the end time of the SQL diagnostics task.
            /// 
            /// *   **errorCode**: the error code.
            /// 
            ///     *   **0001**: The SQL diagnostics task is complete.
            ///     *   **0003**: The SQL diagnostics task failed.
            /// 
            /// *   **errorMessage**: the error message.
            /// 
            /// *   **estimateCost**: the estimated cost.
            /// 
            ///     *   **cpu**: the estimated CPU utilization of the index.
            ///     *   **io**: the estimated I/O usage of the index.
            ///     *   **rows**: the estimated values of the rows returned for the index.
            /// 
            /// *   **improvement**: the performance improvement ratio.
            /// 
            /// *   **indexAdvices**: the index recommendations, which include the following information:
            /// 
            ///     *   **columns**: the index columns.
            ///     *   **ddlAddIndex**: the DDL statement for the index.
            ///     *   **indexName**: the name of the index.
            ///     *   **schemaName**: the name of the database.
            ///     *   **tableName**: the name of the table.
            ///     *   **unique**: indicates whether the index is unique.
            /// 
            /// *   **ip**: the IP address of the instance.
            /// 
            /// *   **messageId**: the ID of the diagnostics task.
            /// 
            /// *   **port**: the port used to connect to the instance.
            /// 
            /// *   **sqlTag**: the SQL tag.
            /// 
            /// *   **startTime**: the start time of the SQL diagnostics task.
            /// 
            /// *   **success**: indicates whether the request was successful.
            /// 
            /// *   **support**: indicates whether the SQL statement can be diagnosed. Valid values:
            /// 
            ///     *   **true**
            ///     *   **false**
            /// 
            /// *   **tuningAdvices** : the SQL rewrite suggestions.
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The SQL template ID.
            /// </summary>
            [NameInMap("sqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// The state of the diagnostics task. Valid values:
            /// 
            /// *   **0**: The diagnostics task is in progress.
            /// *   **1**: A diagnostics error occurred.
            /// *   **2**: The diagnostics task is complete.
            /// *   **3**: An SQL error occurred.
            /// *   **4**: An engine error occurred.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// The unique ID of the diagnostics instance.
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

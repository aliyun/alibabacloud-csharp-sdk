// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataSourceMetaResponseBody : TeaModel {
        /// <summary>
        /// The information about the query operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataSourceMetaResponseBodyData Data { get; set; }
        public class GetDataSourceMetaResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the metadata of the data source failed to be retrieved. If the metadata of the data source was retrieved, this parameter is left empty.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The returned metadata of the data source. The returned metadata is in the JSON format.
            /// 
            /// `{"dbTables":[{"dbName":"testdb","schema":[{"tableInfos":[{"dbName":"testdb","enable":true,"table":"table1","tableName":"table1"}]},{"tableInfos":[{"dbName":"testdb","enable":true,"table":"table2","tableName":"table2"}]}]}]}`
            /// 
            /// Parameter description:
            /// 
            /// *   dbName: the name of the database in which the data source resides.
            /// *   schema: the schema of the database.
            /// *   enable: indicates whether the database is available. A value of true indicates that the database is available. A value of false indicates that the database is unavailable.
            /// *   tableName: the name of the table in the database.
            /// *   tableInfos: the information about the table in the database.
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// Indicates whether the metadata of the data source was retrieved. Valid values:
            /// 
            /// *   success: The metadata of the data source was retrieved.
            /// *   fail: The metadata of the data source failed to be retrieved. You can troubleshoot issues based on the Message parameter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The unique ID of the request. You can query logs and troubleshoot issues based on the unique ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

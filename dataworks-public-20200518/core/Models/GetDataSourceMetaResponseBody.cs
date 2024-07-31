// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataSourceMetaResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataSourceMetaResponseBodyData Data { get; set; }
        public class GetDataSourceMetaResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the metadata of the data source fails to be obtained. If the metadata of the data source is obtained, no value is returned for this parameter.
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
            /// *   enable: indicates whether the database is available. The valid values are true and false. The value true indicates that the database is available. The value false indicates that the database is unavailable.
            /// *   tableName: the name of the table in the database.
            /// *   tableInfos: the information about the table in the database.
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// Indicates whether the metadata of the data source is obtained. Valid values:
            /// 
            /// *   success: The metadata of the data source is obtained.
            /// *   fail: The metadata of the data source failed to be obtained. You can troubleshoot issues based on the Message parameter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

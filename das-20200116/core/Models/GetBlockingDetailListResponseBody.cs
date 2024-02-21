// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetBlockingDetailListResponseBody : TeaModel {
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
        public GetBlockingDetailListResponseBodyData Data { get; set; }
        public class GetBlockingDetailListResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the data returned.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetBlockingDetailListResponseBodyDataList> List { get; set; }
            public class GetBlockingDetailListResponseBodyDataList : TeaModel {
                /// <summary>
                /// The batch ID.
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// The client name.
                /// </summary>
                [NameInMap("ClientAppName")]
                [Validation(Required=false)]
                public string ClientAppName { get; set; }

                /// <summary>
                /// The time when the blocking data was collected.
                /// </summary>
                [NameInMap("CurrentCollectionTime")]
                [Validation(Required=false)]
                public long? CurrentCollectionTime { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("DataBase")]
                [Validation(Required=false)]
                public string DataBase { get; set; }

                /// <summary>
                /// The client hostname.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The username that is used for the logon.
                /// </summary>
                [NameInMap("LoginId")]
                [Validation(Required=false)]
                public string LoginId { get; set; }

                /// <summary>
                /// The hash value of the SQL statement.
                /// </summary>
                [NameInMap("QueryHash")]
                [Validation(Required=false)]
                public string QueryHash { get; set; }

                /// <summary>
                /// The session ID.
                /// </summary>
                [NameInMap("Spid")]
                [Validation(Required=false)]
                public string Spid { get; set; }

                /// <summary>
                /// The SQL statement.
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// The time when the execution started.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The blocking duration. Unit: milliseconds.
                /// </summary>
                [NameInMap("WaitTimeMs")]
                [Validation(Required=false)]
                public long? WaitTimeMs { get; set; }

                /// <summary>
                /// The wait type.
                /// </summary>
                [NameInMap("WaitType")]
                [Validation(Required=false)]
                public string WaitType { get; set; }

            }

            /// <summary>
            /// The page number of the page returned.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request is successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
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
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

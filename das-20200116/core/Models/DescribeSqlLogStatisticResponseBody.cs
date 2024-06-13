// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogStatisticResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogStatisticResponseBodyData Data { get; set; }
        public class DescribeSqlLogStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// The size of the SQL Explorer and Audit data that is stored in cold storage. Unit: bytes.
            /// </summary>
            [NameInMap("ColdSqlSize")]
            [Validation(Required=false)]
            public long? ColdSqlSize { get; set; }

            /// <summary>
            /// The free quota for cold data storage. Unit: bytes.
            /// </summary>
            [NameInMap("FreeColdSqlSize")]
            [Validation(Required=false)]
            public long? FreeColdSqlSize { get; set; }

            /// <summary>
            /// The free quota for hot data storage. Unit: bytes.
            /// </summary>
            [NameInMap("FreeHotSqlSize")]
            [Validation(Required=false)]
            public long? FreeHotSqlSize { get; set; }

            /// <summary>
            /// The size of the SQL Explorer and Audit data that is stored in hot storage. Unit: bytes.
            /// </summary>
            [NameInMap("HotSqlSize")]
            [Validation(Required=false)]
            public long? HotSqlSize { get; set; }

            /// <summary>
            /// The size of the SQL Explorer and Audit data that was generated in the most recent day. Unit: bytes.
            /// </summary>
            [NameInMap("ImportSqlSize")]
            [Validation(Required=false)]
            public long? ImportSqlSize { get; set; }

            /// <summary>
            /// The timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message is returned.
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
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

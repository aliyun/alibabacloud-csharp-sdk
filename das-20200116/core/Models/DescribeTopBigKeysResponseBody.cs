// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeTopBigKeysResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information about the large keys.
        /// 
        /// > This parameter is left empty If no large keys exist within the specified time range.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTopBigKeysResponseBodyData Data { get; set; }
        public class DescribeTopBigKeysResponseBodyData : TeaModel {
            [NameInMap("BigKey")]
            [Validation(Required=false)]
            public List<DescribeTopBigKeysResponseBodyDataBigKey> BigKey { get; set; }
            public class DescribeTopBigKeysResponseBodyDataBigKey : TeaModel {
                /// <summary>
                /// The database in which the key is stored.
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public int? Db { get; set; }

                /// <summary>
                /// The key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The type of the key.
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// The ID of the data shard on the ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The number of elements in the key.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
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
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

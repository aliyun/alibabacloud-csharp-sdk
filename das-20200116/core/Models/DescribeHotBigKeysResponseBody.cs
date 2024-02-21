// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotBigKeysResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The list of hot keys and large keys.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotBigKeysResponseBodyData Data { get; set; }
        public class DescribeHotBigKeysResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the large key failed to be queried.
            /// </summary>
            [NameInMap("BigKeyMsg")]
            [Validation(Required=false)]
            public string BigKeyMsg { get; set; }

            /// <summary>
            /// The list of large keys.
            /// </summary>
            [NameInMap("BigKeys")]
            [Validation(Required=false)]
            public DescribeHotBigKeysResponseBodyDataBigKeys BigKeys { get; set; }
            public class DescribeHotBigKeysResponseBodyDataBigKeys : TeaModel {
                [NameInMap("BigKey")]
                [Validation(Required=false)]
                public List<DescribeHotBigKeysResponseBodyDataBigKeysBigKey> BigKey { get; set; }
                public class DescribeHotBigKeysResponseBodyDataBigKeysBigKey : TeaModel {
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
            /// The reason why the hot key failed to be queried.
            /// </summary>
            [NameInMap("HotKeyMsg")]
            [Validation(Required=false)]
            public string HotKeyMsg { get; set; }

            /// <summary>
            /// The list of hot keys.
            /// </summary>
            [NameInMap("HotKeys")]
            [Validation(Required=false)]
            public DescribeHotBigKeysResponseBodyDataHotKeys HotKeys { get; set; }
            public class DescribeHotBigKeysResponseBodyDataHotKeys : TeaModel {
                [NameInMap("HotKey")]
                [Validation(Required=false)]
                public List<DescribeHotBigKeysResponseBodyDataHotKeysHotKey> HotKey { get; set; }
                public class DescribeHotBigKeysResponseBodyDataHotKeysHotKey : TeaModel {
                    /// <summary>
                    /// The database in which the key is stored.
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// The frequency at which the key is accessed, which indicates the queries per second (QPS) of the key.
                    /// </summary>
                    [NameInMap("Hot")]
                    [Validation(Required=false)]
                    public string Hot { get; set; }

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
                    /// The statistical value that is calculated based on the least frequently used (LFU) caching algorithm.
                    /// </summary>
                    [NameInMap("Lfu")]
                    [Validation(Required=false)]
                    public int? Lfu { get; set; }

                    /// <summary>
                    /// The ID of the data shard on the ApsaraDB for Redis instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                }

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

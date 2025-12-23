// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotBigKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of hot keys and large keys.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotBigKeysResponseBodyData Data { get; set; }
        public class DescribeHotBigKeysResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the large key failed to be queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>current version doesn\&quot;t support</para>
            /// </summary>
            [NameInMap("BigKeyMsg")]
            [Validation(Required=false)]
            public string BigKeyMsg { get; set; }

            /// <summary>
            /// <para>The list of large keys.</para>
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
                    /// <para>The database in which the key is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// <para>The key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc:def:eng</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The type of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zset</para>
                    /// </summary>
                    [NameInMap("KeyType")]
                    [Validation(Required=false)]
                    public string KeyType { get; set; }

                    /// <summary>
                    /// <para>The ID of the data shard on the ApsaraDB for Redis instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-x****-db-0</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The number of elements in the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

            }

            [NameInMap("HighTrafficKeyMsg")]
            [Validation(Required=false)]
            public string HighTrafficKeyMsg { get; set; }

            [NameInMap("HighTrafficKeys")]
            [Validation(Required=false)]
            public DescribeHotBigKeysResponseBodyDataHighTrafficKeys HighTrafficKeys { get; set; }
            public class DescribeHotBigKeysResponseBodyDataHighTrafficKeys : TeaModel {
                [NameInMap("HighTrafficKey")]
                [Validation(Required=false)]
                public List<DescribeHotBigKeysResponseBodyDataHighTrafficKeysHighTrafficKey> HighTrafficKey { get; set; }
                public class DescribeHotBigKeysResponseBodyDataHighTrafficKeysHighTrafficKey : TeaModel {
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    [NameInMap("Hot")]
                    [Validation(Required=false)]
                    public string Hot { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("KeyType")]
                    [Validation(Required=false)]
                    public string KeyType { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    [NameInMap("inBytes")]
                    [Validation(Required=false)]
                    public long? InBytes { get; set; }

                    [NameInMap("outBytes")]
                    [Validation(Required=false)]
                    public long? OutBytes { get; set; }

                }

            }

            /// <summary>
            /// <para>The reason why the hot key failed to be queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>current version doesn\&quot;t support</para>
            /// </summary>
            [NameInMap("HotKeyMsg")]
            [Validation(Required=false)]
            public string HotKeyMsg { get; set; }

            /// <summary>
            /// <para>The list of hot keys.</para>
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
                    /// <para>The database in which the key is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// <para>The frequency at which the key is accessed, which indicates the queries per second (QPS) of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5500~6000</para>
                    /// </summary>
                    [NameInMap("Hot")]
                    [Validation(Required=false)]
                    public string Hot { get; set; }

                    /// <summary>
                    /// <para>The key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc:def:eng</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The type of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zset</para>
                    /// </summary>
                    [NameInMap("KeyType")]
                    [Validation(Required=false)]
                    public string KeyType { get; set; }

                    /// <summary>
                    /// <para>The statistical value that is calculated based on the least frequently used (LFU) caching algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>253</para>
                    /// </summary>
                    [NameInMap("Lfu")]
                    [Validation(Required=false)]
                    public int? Lfu { get; set; }

                    /// <summary>
                    /// <para>The ID of the data shard on the ApsaraDB for Redis instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-x****-db-0</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

            }

            [NameInMap("LargeKeyMsg")]
            [Validation(Required=false)]
            public string LargeKeyMsg { get; set; }

            [NameInMap("LargeKeys")]
            [Validation(Required=false)]
            public DescribeHotBigKeysResponseBodyDataLargeKeys LargeKeys { get; set; }
            public class DescribeHotBigKeysResponseBodyDataLargeKeys : TeaModel {
                [NameInMap("LargeKey")]
                [Validation(Required=false)]
                public List<DescribeHotBigKeysResponseBodyDataLargeKeysLargeKey> LargeKey { get; set; }
                public class DescribeHotBigKeysResponseBodyDataLargeKeysLargeKey : TeaModel {
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public string Db { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("KeyType")]
                    [Validation(Required=false)]
                    public string KeyType { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

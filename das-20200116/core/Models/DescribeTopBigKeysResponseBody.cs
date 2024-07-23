// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeTopBigKeysResponseBody : TeaModel {
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
        /// <para>The detailed information about the large keys.</para>
        /// <remarks>
        /// <para>This parameter is left empty If no large keys exist within the specified time range.</para>
        /// </remarks>
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

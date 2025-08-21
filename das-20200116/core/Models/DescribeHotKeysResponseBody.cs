// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotKeysResponseBody : TeaModel {
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
        /// <para>The details of the hot keys.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotKeysResponseBodyData Data { get; set; }
        public class DescribeHotKeysResponseBodyData : TeaModel {
            [NameInMap("HotKey")]
            [Validation(Required=false)]
            public List<DescribeHotKeysResponseBodyDataHotKey> HotKey { get; set; }
            public class DescribeHotKeysResponseBodyDataHotKey : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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

                [NameInMap("InBytes")]
                [Validation(Required=false)]
                public long? InBytes { get; set; }

                /// <summary>
                /// <para>The name of the key.</para>
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

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("OutBytes")]
                [Validation(Required=false)]
                public long? OutBytes { get; set; }

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
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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

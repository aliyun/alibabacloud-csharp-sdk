// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotKeysResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the hot keys.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotKeysResponseBodyData Data { get; set; }
        public class DescribeHotKeysResponseBodyData : TeaModel {
            [NameInMap("HotKey")]
            [Validation(Required=false)]
            public List<DescribeHotKeysResponseBodyDataHotKey> HotKey { get; set; }
            public class DescribeHotKeysResponseBodyDataHotKey : TeaModel {
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
                /// The name of the key.
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
                /// The number of elements in the key.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

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

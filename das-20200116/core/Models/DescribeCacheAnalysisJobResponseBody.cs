// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCacheAnalysisJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisJobResponseBodyData Data { get; set; }
        public class DescribeCacheAnalysisJobResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the large keys. The returned large keys are sorted in descending order based on the number of bytes occupied by the keys.
            /// </summary>
            [NameInMap("BigKeys")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataBigKeys BigKeys { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataBigKeys : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataBigKeysKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataBigKeysKeyInfo : TeaModel {
                    /// <summary>
                    /// The number of bytes that are occupied by the key.
                    /// </summary>
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    /// <summary>
                    /// The number of elements in the key.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// The data type of the key.
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// The expiration period of the key. Unit: milliseconds. A value of 0 indicates that the key does not expire.
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// The name of the key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The ID of the data node on the instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The data type of the instance.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The details of the large keys. The returned large keys are sorted in descending order based on the number of keys.
            /// </summary>
            [NameInMap("BigKeysOfNum")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNum BigKeysOfNum { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNum : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNumKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNumKeyInfo : TeaModel {
                    /// <summary>
                    /// The number of bytes that are occupied by the key.
                    /// </summary>
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    /// <summary>
                    /// The number of elements in the key.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// The data type of the key.
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// The expiration period of the key. Unit: milliseconds. A value of 0 indicates that the key does not expire.
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// The name of the key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The ID of the data node on the instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The data type of the instance.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the cache analysis task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The prefixes of the keys.
            /// </summary>
            [NameInMap("KeyPrefixes")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataKeyPrefixes KeyPrefixes { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataKeyPrefixes : TeaModel {
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataKeyPrefixesPrefix> Prefix { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataKeyPrefixesPrefix : TeaModel {
                    /// <summary>
                    /// The number of bytes that are occupied by the key.
                    /// </summary>
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    /// <summary>
                    /// The number of elements in the key.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The number of keys that contain the prefix.
                    /// </summary>
                    [NameInMap("KeyNum")]
                    [Validation(Required=false)]
                    public long? KeyNum { get; set; }

                    /// <summary>
                    /// The prefix of the key.
                    /// </summary>
                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    /// <summary>
                    /// The data type of the instance.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The message that is returned for the request.
            /// 
            /// >  If the request is successful, **Successful** is returned. If the request fails, an error message that contains information such as an error code is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the data node on the instance.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The state of the cache analysis task. Valid values:
            /// 
            /// *   **BACKUP**: The data is being backed up.
            /// *   **ANALYZING**: The data is being analyzed.
            /// *   **FINISHED**: The data is analyzed.
            /// *   **FAILED**: An error occurred.
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// The details of permanent keys. The returned keys are sorted in descending order based on the number of bytes occupied by the keys.
            /// </summary>
            [NameInMap("UnexBigKeysOfBytes")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytes UnexBigKeysOfBytes { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytes : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytesKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytesKeyInfo : TeaModel {
                    /// <summary>
                    /// The number of bytes that are occupied by the key.
                    /// </summary>
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    /// <summary>
                    /// The number of elements in the key.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// The data type of the key.
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// The expiration period of the key. Unit: milliseconds. A value of 0 indicates that the key does not expire.
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// The name of the key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The ID of the data node on the instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The data type of the instance.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The details of permanent keys. The returned keys are sorted in descending order based on the number of keys.
            /// </summary>
            [NameInMap("UnexBigKeysOfNum")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNum UnexBigKeysOfNum { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNum : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNumKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNumKeyInfo : TeaModel {
                    /// <summary>
                    /// The number of bytes that are occupied by the key.
                    /// </summary>
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    /// <summary>
                    /// The number of elements in the key.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("Db")]
                    [Validation(Required=false)]
                    public int? Db { get; set; }

                    /// <summary>
                    /// The data type of the key.
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// The expiration period of the key. Unit: milliseconds. A value of 0 indicates that the key does not expire.
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// The name of the key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The ID of the data node on the instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The data type of the instance.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// The message that is returned for the request.
        /// 
        /// >  If the request is successful, **Successful** is returned. If the request fails, an error message that contains information such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
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

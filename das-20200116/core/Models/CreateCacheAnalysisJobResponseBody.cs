// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCacheAnalysisJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCacheAnalysisJobResponseBodyData Data { get; set; }
        public class CreateCacheAnalysisJobResponseBodyData : TeaModel {
            /// <summary>
            /// The number of elements in the key.
            /// </summary>
            [NameInMap("BigKeys")]
            [Validation(Required=false)]
            public CreateCacheAnalysisJobResponseBodyDataBigKeys BigKeys { get; set; }
            public class CreateCacheAnalysisJobResponseBodyDataBigKeys : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<CreateCacheAnalysisJobResponseBodyDataBigKeysKeyInfo> KeyInfo { get; set; }
                public class CreateCacheAnalysisJobResponseBodyDataBigKeysKeyInfo : TeaModel {
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
                    /// The data type of the ApsaraDB for Redis instance.
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
            /// 
            /// >  This parameter can be used to query a specific cache analysis task. When you call the CreateCacheAnalysisJob operation, it takes some time to create a cache analysis task. As a result, the analysis results cannot be immediately returned. You can call the [DescribeCacheAnalysisJob](https://help.aliyun.com/document_detail/180983.html) operation to query the analysis results of the specified cache analysis task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The returned message.
            /// 
            /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
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

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
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

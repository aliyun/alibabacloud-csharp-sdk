// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCacheAnalysisJobsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The list of cache analysis tasks.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisJobsResponseBodyData Data { get; set; }
        public class DescribeCacheAnalysisJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// The ID of the data node on the instance.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobsResponseBodyDataList List { get; set; }
            public class DescribeCacheAnalysisJobsResponseBodyDataList : TeaModel {
                [NameInMap("CacheAnalysisJob")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJob> CacheAnalysisJob { get; set; }
                public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJob : TeaModel {
                    /// <summary>
                    /// The details about the large keys.
                    /// 
                    /// > The sub-parameters of this parameter and the content of the sub-parameters are not returned. To query the detailed information about the cache analysis tasks, call the [DescribeCacheAnalysisJob](~~443012~~) operation.
                    /// </summary>
                    [NameInMap("BigKeys")]
                    [Validation(Required=false)]
                    public DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeys BigKeys { get; set; }
                    public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeys : TeaModel {
                        [NameInMap("KeyInfo")]
                        [Validation(Required=false)]
                        public List<DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeysKeyInfo> KeyInfo { get; set; }
                        public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeysKeyInfo : TeaModel {
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
                    /// * **BACKUP**: The data is being backed up.
                    /// * **ANALYZING**: The data is being analyzed.
                    /// * **FINISHED**: The data is analyzed.
                    /// * **FAILED**: An error occurred.
                    /// </summary>
                    [NameInMap("TaskState")]
                    [Validation(Required=false)]
                    public string TaskState { get; set; }

                }

            }

            /// <summary>
            /// The page number. The value must be an integer that is greater than 0. Default value: 1.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10.
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

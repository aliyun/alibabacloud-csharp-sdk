// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCacheAnalysisJobsResponseBody : TeaModel {
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
        /// <para>The list of cache analysis tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisJobsResponseBodyData Data { get; set; }
        public class DescribeCacheAnalysisJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The ID of the data node on the instance.</para>
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
                    /// <para>The details about the large keys.</para>
                    /// <remarks>
                    /// <para>The sub-parameters of this parameter and the content of the sub-parameters are not returned. To query the detailed information about the cache analysis tasks, call the <a href="https://help.aliyun.com/document_detail/443012.html">DescribeCacheAnalysisJob</a> operation.</para>
                    /// </remarks>
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
                            /// <para>The number of bytes that are occupied by the key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>12345</para>
                            /// </summary>
                            [NameInMap("Bytes")]
                            [Validation(Required=false)]
                            public long? Bytes { get; set; }

                            /// <summary>
                            /// <para>The number of elements in the key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>127</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public long? Count { get; set; }

                            /// <summary>
                            /// <para>The name of the database.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Db")]
                            [Validation(Required=false)]
                            public int? Db { get; set; }

                            /// <summary>
                            /// <para>The data type of the key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>hashtable</para>
                            /// </summary>
                            [NameInMap("Encoding")]
                            [Validation(Required=false)]
                            public string Encoding { get; set; }

                            /// <summary>
                            /// <para>The expiration period of the key. Unit: milliseconds. A value of 0 indicates that the key does not expire.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1596256542547</para>
                            /// </summary>
                            [NameInMap("ExpirationTimeMillis")]
                            [Validation(Required=false)]
                            public long? ExpirationTimeMillis { get; set; }

                            /// <summary>
                            /// <para>The name of the key.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>task_*****</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The ID of the data node on the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>r-****-db-0</para>
                            /// </summary>
                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                            /// <summary>
                            /// <para>The data type of the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>hash</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-bp18ff4a195d****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the cache analysis task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sf79-sd99-sa37-****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The returned message.</para>
                    /// <remarks>
                    /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Successful</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The ID of the data node on the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-x****-db-0</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The state of the cache analysis task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>BACKUP</b>: The data is being backed up.</description></item>
                    /// <item><description><b>ANALYZING</b>: The data is being analyzed.</description></item>
                    /// <item><description><b>FINISHED</b>: The data is analyzed.</description></item>
                    /// <item><description><b>FAILED</b>: An error occurred.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BACKUP</para>
                    /// </summary>
                    [NameInMap("TaskState")]
                    [Validation(Required=false)]
                    public string TaskState { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number. The value must be an integer that is greater than 0. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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

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

            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobsResponseBodyDataList List { get; set; }
            public class DescribeCacheAnalysisJobsResponseBodyDataList : TeaModel {
                [NameInMap("CacheAnalysisJob")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJob> CacheAnalysisJob { get; set; }
                public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJob : TeaModel {
                    [NameInMap("BigKeys")]
                    [Validation(Required=false)]
                    public DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeys BigKeys { get; set; }
                    public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeys : TeaModel {
                        [NameInMap("KeyInfo")]
                        [Validation(Required=false)]
                        public List<DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeysKeyInfo> KeyInfo { get; set; }
                        public class DescribeCacheAnalysisJobsResponseBodyDataListCacheAnalysisJobBigKeysKeyInfo : TeaModel {
                            [NameInMap("Bytes")]
                            [Validation(Required=false)]
                            public long? Bytes { get; set; }

                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public long? Count { get; set; }

                            [NameInMap("Db")]
                            [Validation(Required=false)]
                            public int? Db { get; set; }

                            [NameInMap("Encoding")]
                            [Validation(Required=false)]
                            public string Encoding { get; set; }

                            [NameInMap("ExpirationTimeMillis")]
                            [Validation(Required=false)]
                            public long? ExpirationTimeMillis { get; set; }

                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

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

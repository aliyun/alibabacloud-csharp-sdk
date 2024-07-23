// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCacheAnalysisJobResponseBody : TeaModel {
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
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCacheAnalysisJobResponseBodyData Data { get; set; }
        public class CreateCacheAnalysisJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of elements in the key.</para>
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
                    /// <para>task_x****</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

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
                    /// <para>The data type of the ApsaraDB for Redis instance.</para>
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
            /// <remarks>
            /// <para> This parameter can be used to query a specific cache analysis task. When you call the CreateCacheAnalysisJob operation, it takes some time to create a cache analysis task. As a result, the analysis results cannot be immediately returned. You can call the <a href="https://help.aliyun.com/document_detail/180983.html">DescribeCacheAnalysisJob</a> operation to query the analysis results of the specified cache analysis task.</para>
            /// </remarks>
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

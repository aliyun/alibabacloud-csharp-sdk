// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCacheAnalysisJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCacheAnalysisJobResponseBodyData Data { get; set; }
        public class CreateCacheAnalysisJobResponseBodyData : TeaModel {
            [NameInMap("BigKeys")]
            [Validation(Required=false)]
            public CreateCacheAnalysisJobResponseBodyDataBigKeys BigKeys { get; set; }
            public class CreateCacheAnalysisJobResponseBodyDataBigKeys : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<CreateCacheAnalysisJobResponseBodyDataBigKeysKeyInfo> KeyInfo { get; set; }
                public class CreateCacheAnalysisJobResponseBodyDataBigKeysKeyInfo : TeaModel {
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
            /// <para>The ID of query cache analysis task.</para>
            /// <remarks>
            /// <para>You can use this parameter to query query cache analysis task. Because creating a cache analysis task takes some time, the analysis result is not immediately returned when you call this operation. Use this parameter together with the <a href="https://help.aliyun.com/document_detail/180983.html">DescribeCacheAnalysisJob</a> operation to query the analysis result.</para>
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
            /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the data node in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-x****-db-0</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The status of the cache analysis task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKUP</b>: The system is performing a backup.</description></item>
            /// <item><description><b>ANALYZING</b>: The system is analyzing the backup file.</description></item>
            /// <item><description><b>FINISHED</b>: The analysis is complete.</description></item>
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
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
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

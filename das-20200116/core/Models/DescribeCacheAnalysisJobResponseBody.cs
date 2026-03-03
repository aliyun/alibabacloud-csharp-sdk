// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCacheAnalysisJobResponseBody : TeaModel {
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
        /// <para>The details of the cache analysis task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCacheAnalysisJobResponseBodyData Data { get; set; }
        public class DescribeCacheAnalysisJobResponseBodyData : TeaModel {
            [NameInMap("BigKeys")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataBigKeys BigKeys { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataBigKeys : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataBigKeysKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataBigKeysKeyInfo : TeaModel {
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

            [NameInMap("BigKeysOfNum")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNum BigKeysOfNum { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNum : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNumKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataBigKeysOfNumKeyInfo : TeaModel {
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

            [NameInMap("ExpiryKeysLevelCount")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCount ExpiryKeysLevelCount { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCount : TeaModel {
                [NameInMap("ExpiryLevel")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCountExpiryLevel> ExpiryLevel { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCountExpiryLevel : TeaModel {
                    [NameInMap("AnalysisTs")]
                    [Validation(Required=false)]
                    public long? AnalysisTs { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                    [NameInMap("TotalBytes")]
                    [Validation(Required=false)]
                    public long? TotalBytes { get; set; }

                    [NameInMap("TotalKeys")]
                    [Validation(Required=false)]
                    public long? TotalKeys { get; set; }

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

            [NameInMap("KeyPrefixes")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataKeyPrefixes KeyPrefixes { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataKeyPrefixes : TeaModel {
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataKeyPrefixesPrefix> Prefix { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataKeyPrefixesPrefix : TeaModel {
                    [NameInMap("Bytes")]
                    [Validation(Required=false)]
                    public long? Bytes { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    [NameInMap("KeyNum")]
                    [Validation(Required=false)]
                    public long? KeyNum { get; set; }

                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The message that is returned for the request.</para>
            /// <remarks>
            /// <para> If the request is successful, <b>Successful</b> is returned. If the request fails, an error message that contains information such as an error code is returned.</para>
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

            [NameInMap("UnexBigKeysOfBytes")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytes UnexBigKeysOfBytes { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytes : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytesKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfBytesKeyInfo : TeaModel {
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

            [NameInMap("UnexBigKeysOfNum")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNum UnexBigKeysOfNum { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNum : TeaModel {
                [NameInMap("KeyInfo")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNumKeyInfo> KeyInfo { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataUnexBigKeysOfNumKeyInfo : TeaModel {
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

        }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// <remarks>
        /// <para> If the request is successful, <b>Successful</b> is returned. If the request fails, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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

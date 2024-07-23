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
            /// <summary>
            /// <para>The details of the large keys. The returned large keys are sorted in descending order based on the number of bytes occupied by the keys.</para>
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
                    /// <para>The database name.</para>
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
                    /// <para>The time when the key expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A value of 0 indicates that the key never expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1596256542547</para>
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// <para>The key name.</para>
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
            /// <para>The details of the large keys. The returned large keys are sorted in descending order based on the number of keys.</para>
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
                    /// <para>The database name.</para>
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
                    /// <para>The time when the key expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A value of 0 indicates that the key never expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1596256542547</para>
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// <para>The key name.</para>
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
            /// <para>The statistics of the keys that have expired.</para>
            /// </summary>
            [NameInMap("ExpiryKeysLevelCount")]
            [Validation(Required=false)]
            public DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCount ExpiryKeysLevelCount { get; set; }
            public class DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCount : TeaModel {
                [NameInMap("ExpiryLevel")]
                [Validation(Required=false)]
                public List<DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCountExpiryLevel> ExpiryLevel { get; set; }
                public class DescribeCacheAnalysisJobResponseBodyDataExpiryKeysLevelCountExpiryLevel : TeaModel {
                    /// <summary>
                    /// <para>The time when the cache analysis task was complete. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1717469347000</para>
                    /// </summary>
                    [NameInMap("AnalysisTs")]
                    [Validation(Required=false)]
                    public long? AnalysisTs { get; set; }

                    /// <summary>
                    /// <para>The expiration level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The key never expires.</description></item>
                    /// <item><description><b>1</b>: The key has expired.</description></item>
                    /// <item><description><b>2</b>: The key has expired for 0 to 1 hour.</description></item>
                    /// <item><description><b>3</b>: The key has expired for 1 to 3 hours.</description></item>
                    /// <item><description><b>4</b>: The key has expired for 3 to 12 hours.</description></item>
                    /// <item><description><b>5</b>: The key has expired for 12 to 24 hours.</description></item>
                    /// <item><description><b>6</b>: The key has expired for one to two days.</description></item>
                    /// <item><description><b>7</b>: The key has expired for three to seven days.</description></item>
                    /// <item><description><b>8</b>: The key has expired for more than seven days.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                    /// <summary>
                    /// <para>The number of bytes occupied by the keys that have expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8064</para>
                    /// </summary>
                    [NameInMap("TotalBytes")]
                    [Validation(Required=false)]
                    public long? TotalBytes { get; set; }

                    /// <summary>
                    /// <para>The total number of the keys that have expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>62</para>
                    /// </summary>
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

            /// <summary>
            /// <para>The prefixes of the keys.</para>
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
                    /// <para>The number of keys that contain the prefix.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("KeyNum")]
                    [Validation(Required=false)]
                    public long? KeyNum { get; set; }

                    /// <summary>
                    /// <para>The prefix of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>task_</para>
                    /// </summary>
                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

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

            /// <summary>
            /// <para>The details of permanent keys. The returned keys are sorted in descending order based on the number of bytes occupied by the keys.</para>
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
                    /// <para>The database name.</para>
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
                    /// <para>The time when the key expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A value of 0 indicates that the key never expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1596256542547</para>
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// <para>The key name.</para>
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
            /// <para>The details of permanent keys. The returned keys are sorted in descending order based on the number of keys.</para>
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
                    /// <para>The database name.</para>
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
                    /// <para>The time when the key expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. A value of 0 indicates that the key never expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1596256542547</para>
                    /// </summary>
                    [NameInMap("ExpirationTimeMillis")]
                    [Validation(Required=false)]
                    public long? ExpirationTimeMillis { get; set; }

                    /// <summary>
                    /// <para>The key name.</para>
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

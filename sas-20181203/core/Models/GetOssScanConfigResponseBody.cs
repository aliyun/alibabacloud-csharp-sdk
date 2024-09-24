// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssScanConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssScanConfigResponseBodyData Data { get; set; }
        public class GetOssScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether to match all file prefixes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllKeyPrefix")]
            [Validation(Required=false)]
            public bool? AllKeyPrefix { get; set; }

            /// <summary>
            /// <para>The number of the buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz-new01****</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The names of the buckets.</para>
            /// </summary>
            [NameInMap("BucketNameList")]
            [Validation(Required=false)]
            public List<string> BucketNameList { get; set; }

            /// <summary>
            /// <para>The maximum number of files for decompression. The minimum value is 1, and the maximum value is 1000. If the decompression level exceeds the maximum, the decompression operation will be terminated, but the detection of decompressed files will not be affected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DecompressMaxFileCount")]
            [Validation(Required=false)]
            public int? DecompressMaxFileCount { get; set; }

            /// <summary>
            /// <para>The maximum level of decompression when dealing with nested compressed files with multiple levels. The minimum value is 1, and the maximum value is 5. If the decompression level exceeds the maximum, the decompression operation will be terminated, but the detection of decompressed files will not be affected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DecompressMaxLayer")]
            [Validation(Required=false)]
            public int? DecompressMaxLayer { get; set; }

            [NameInMap("DecryptionList")]
            [Validation(Required=false)]
            public List<string> DecryptionList { get; set; }

            /// <summary>
            /// <para>Indicates whether the check policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The end time of the check. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1274****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The prefixes of the object that you want to check.</para>
            /// </summary>
            [NameInMap("KeyPrefixList")]
            [Validation(Required=false)]
            public List<string> KeyPrefixList { get; set; }

            /// <summary>
            /// <para>The suffixes of the objects that are checked.</para>
            /// </summary>
            [NameInMap("KeySuffixList")]
            [Validation(Required=false)]
            public List<string> KeySuffixList { get; set; }

            [NameInMap("LastModifiedStartTime")]
            [Validation(Required=false)]
            public long? LastModifiedStartTime { get; set; }

            /// <summary>
            /// <para>The time when the policy last update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1702025633079</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0104</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The days when the check is performed. The value indicates the days of the week.</para>
            /// </summary>
            [NameInMap("ScanDayList")]
            [Validation(Required=false)]
            public List<int?> ScanDayList { get; set; }

            /// <summary>
            /// <para>The start time of the check. The time is in the HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E10BAF1C-A6C5-51E2-866C-76D5922E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

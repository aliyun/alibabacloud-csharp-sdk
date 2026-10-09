// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssScanConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssScanConfigResponseBodyData Data { get; set; }
        public class GetOssScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether to match all prefixes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllKeyPrefix")]
            [Validation(Required=false)]
            public bool? AllKeyPrefix { get; set; }

            /// <summary>
            /// <para>Specifies whether to automatically add new buckets to the scan policy. Valid values: 0 (disabled) and 1 (enabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AutoAdd")]
            [Validation(Required=false)]
            public int? AutoAdd { get; set; }

            /// <summary>
            /// <para>The configuration name used when automatically adding buckets.</para>
            /// </summary>
            [NameInMap("AutoAddConfigName")]
            [Validation(Required=false)]
            public string AutoAddConfigName { get; set; }

            /// <summary>
            /// <para>The number of buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz-new02****</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The list of bucket names.</para>
            /// </summary>
            [NameInMap("BucketNameList")]
            [Validation(Required=false)]
            public List<string> BucketNameList { get; set; }

            /// <summary>
            /// <para>The maximum number of files to extract. The minimum value is 1 and the maximum value is 1000. If the number of extracted files exceeds the maximum, the decompression operation stops immediately. Files that have already been extracted are still scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DecompressMaxFileCount")]
            [Validation(Required=false)]
            public int? DecompressMaxFileCount { get; set; }

            /// <summary>
            /// <para>The maximum number of decompression layers for nested compressed archives. The minimum value is 1 and the maximum value is 5. If the number of layers exceeds the maximum, the decompression operation stops immediately. Files that have already been extracted are still scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DecompressMaxLayer")]
            [Validation(Required=false)]
            public int? DecompressMaxLayer { get; set; }

            /// <summary>
            /// <para>The list of decryption types.</para>
            /// </summary>
            [NameInMap("DecryptionList")]
            [Validation(Required=false)]
            public List<string> DecryptionList { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The scan stop time in HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The prefix list of files.</para>
            /// </summary>
            [NameInMap("KeyPrefixList")]
            [Validation(Required=false)]
            public List<string> KeyPrefixList { get; set; }

            /// <summary>
            /// <para>The list of file suffixes to scan.</para>
            /// </summary>
            [NameInMap("KeySuffixList")]
            [Validation(Required=false)]
            public List<string> KeySuffixList { get; set; }

            /// <summary>
            /// <para>Scans files whose last modification time is after the specified timestamp. The unit is milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724301769834</para>
            /// </summary>
            [NameInMap("LastModifiedStartTime")]
            [Validation(Required=false)]
            public long? LastModifiedStartTime { get; set; }

            /// <summary>
            /// <para>The last update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1702025633079</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testPolicy****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether real-time incremental scanning is enabled. If this parameter is set to true, the ScanDayList, StartTime, and EndTime parameters do not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RealTimeIncr")]
            [Validation(Required=false)]
            public bool? RealTimeIncr { get; set; }

            /// <summary>
            /// <para>The scan days, represented as numbers indicating the day of the week.</para>
            /// </summary>
            [NameInMap("ScanDayList")]
            [Validation(Required=false)]
            public List<int?> ScanDayList { get; set; }

            /// <summary>
            /// <para>The service source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OSS</b>: OSS.</description></item>
            /// <item><description><b>NAS</b>: NAS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The scan start time in HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E10BAF1C-A6C5-51E2-866C-76D5922E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

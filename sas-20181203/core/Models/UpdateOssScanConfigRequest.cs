// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOssScanConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to match all file prefixes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllKeyPrefix")]
        [Validation(Required=false)]
        public bool? AllKeyPrefix { get; set; }

        /// <summary>
        /// <para>The list of bucket names.</para>
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// <para>The maximum number of files to decompress. Minimum value: 1. Maximum value: 1000. If the maximum number of decompressed files is exceeded, the decompression operation stops. The detection of already decompressed files is not affected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of decompression layers for nested compressed files. Minimum value: 1. Maximum value: 5. If the maximum number of decompression layers is exceeded, the decompression operation stops. The detection of already decompressed files is not affected.</para>
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
        /// <para>Specifies whether to enable the scan policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The scan end time in the HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:01</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The scan policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1141****</para>
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
        /// <para>The list of file suffixes.</para>
        /// </summary>
        [NameInMap("KeySuffixList")]
        [Validation(Required=false)]
        public List<string> KeySuffixList { get; set; }

        /// <summary>
        /// <para>Scans files whose last modification time is after the specified timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724301769834</para>
        /// </summary>
        [NameInMap("LastModifiedStartTime")]
        [Validation(Required=false)]
        public long? LastModifiedStartTime { get; set; }

        /// <summary>
        /// <para>The scan policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testStrategy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable real-time incremental detection. If this parameter is set to true, the ScanDayList, StartTime, and EndTime parameters do not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RealTimeIncr")]
        [Validation(Required=false)]
        public bool? RealTimeIncr { get; set; }

        /// <summary>
        /// <para>The scan days. The number indicates the day of the week.</para>
        /// </summary>
        [NameInMap("ScanDayList")]
        [Validation(Required=false)]
        public List<int?> ScanDayList { get; set; }

        /// <summary>
        /// <para>The scan start time in the HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

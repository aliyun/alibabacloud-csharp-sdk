// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOssScanConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to match the prefixes of all objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllKeyPrefix")]
        [Validation(Required=false)]
        public bool? AllKeyPrefix { get; set; }

        /// <summary>
        /// <para>The names of the buckets.</para>
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// <para>The maximum number of objects that can be extracted from a package. Valid values: 1 to 1000. If the value is reached, the decompression operation immediately finishes. The detection of extracted objects is not affected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of decompression levels when multi-level packages are decompressed. Valid values: 1 to 5. If the value is reached, the decompression operation immediately finishes. The detection of extracted objects is not affected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DecompressMaxLayer")]
        [Validation(Required=false)]
        public int? DecompressMaxLayer { get; set; }

        /// <summary>
        /// <para>The decryption methods.</para>
        /// </summary>
        [NameInMap("DecryptionList")]
        [Validation(Required=false)]
        public List<string> DecryptionList { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the bucket check policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the bucket check policy.</description></item>
        /// <item><description><b>0</b>: disables the bucket check policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The end time of the check. Specify the time in the HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:01</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65778</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The prefixes of the objects.</para>
        /// </summary>
        [NameInMap("KeyPrefixList")]
        [Validation(Required=false)]
        public List<string> KeyPrefixList { get; set; }

        /// <summary>
        /// <para>The suffixes of the objects that you want to check.</para>
        /// </summary>
        [NameInMap("KeySuffixList")]
        [Validation(Required=false)]
        public List<string> KeySuffixList { get; set; }

        /// <summary>
        /// <para>The timestamp. The objects whose last modification time is later than the specified value are detected. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724301769834</para>
        /// </summary>
        [NameInMap("LastModifiedStartTime")]
        [Validation(Required=false)]
        public long? LastModifiedStartTime { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacos****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The time when the check is performed. The value specifies the days of the week.</para>
        /// </summary>
        [NameInMap("ScanDayList")]
        [Validation(Required=false)]
        public List<int?> ScanDayList { get; set; }

        /// <summary>
        /// <para>The start time of the check. Specify the time in the HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

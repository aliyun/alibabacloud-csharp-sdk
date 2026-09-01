// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOssBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to match all prefixes. If this parameter is set to true, the KeyPrefixList parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllKeyPrefix")]
        [Validation(Required=false)]
        public bool? AllKeyPrefix { get; set; }

        /// <summary>
        /// <para>The list of bucket names.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// <para>The maximum number of files to decompress. The minimum value is 1 and the maximum value is 1000. When the maximum number of decompressed files is exceeded, the decompression operation ends immediately. The detection of files that have already been decompressed is not affected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        /// <summary>
        /// <para>The maximum number of decompression layers when multiple levels of compressed packages are nested. The minimum value is 1 and the maximum value is 5. When the maximum number of decompression layers is exceeded, the decompression operation ends immediately. The detection of files that have already been decompressed is not affected.</para>
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
        /// <para>The list of file suffixes to exclude from detection.</para>
        /// </summary>
        [NameInMap("ExcludeKeySuffixList")]
        [Validation(Required=false)]
        public List<string> ExcludeKeySuffixList { get; set; }

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
        /// <para>Specifies that only files whose last modification time is after the specified timestamp are detected. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724301769834</para>
        /// </summary>
        [NameInMap("LastModifiedStartTime")]
        [Validation(Required=false)]
        public long? LastModifiedStartTime { get; set; }

        /// <summary>
        /// <para>The detection mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Full file detection.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Incremental file detection.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public int? ScanMode { get; set; }

        /// <summary>
        /// <para>The business source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS</description></item>
        /// <item><description><b>NAS</b>: NAS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}

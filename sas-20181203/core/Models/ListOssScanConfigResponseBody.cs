// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssScanConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssScanConfigResponseBodyData> Data { get; set; }
        public class ListOssScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether all prefixes are matched.</para>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("BucketCount")]
            [Validation(Required=false)]
            public int? BucketCount { get; set; }

            /// <summary>
            /// <para>The list of bucket names.</para>
            /// </summary>
            [NameInMap("BucketNameList")]
            [Validation(Required=false)]
            public List<string> BucketNameList { get; set; }

            /// <summary>
            /// <para>The maximum number of files to extract. The minimum value is 1 and the maximum value is 1000. If the maximum number of files is exceeded, the decompression operation stops immediately. Files that have already been extracted are still scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DecompressMaxFileCount")]
            [Validation(Required=false)]
            public int? DecompressMaxFileCount { get; set; }

            /// <summary>
            /// <para>The maximum number of decompression layers for nested compressed archives. The minimum value is 1 and the maximum value is 5. If the maximum number of layers is exceeded, the decompression operation stops immediately. Files that have already been extracted are still scanned.</para>
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
            /// <para>Specifies whether the configuration is enabled. Valid values:</para>
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
            /// <para>The detection end time in HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443496</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of file directories to scan.</para>
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
            /// <para>The timestamp in milliseconds. Only files whose last modification time is after this timestamp are scanned.</para>
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
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether real-time incremental detection is enabled. If this parameter is set to true, the ScanDayList, StartTime, and EndTime parameters do not take effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RealTimeIncr")]
            [Validation(Required=false)]
            public bool? RealTimeIncr { get; set; }

            /// <summary>
            /// <para>The scan days. Each number represents a day of the week.</para>
            /// </summary>
            [NameInMap("ScanDayList")]
            [Validation(Required=false)]
            public List<int?> ScanDayList { get; set; }

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

            /// <summary>
            /// <para>The detection start time in HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOssScanConfigResponseBodyPageInfo PageInfo { get; set; }
        public class ListOssScanConfigResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number for paged queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries displayed per page for paged queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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

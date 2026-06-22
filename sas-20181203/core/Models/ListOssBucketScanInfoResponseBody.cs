// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssBucketScanInfoResponseBodyData> Data { get; set; }
        public class ListOssBucketScanInfoResponseBodyData : TeaModel {
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
            /// <para>The enabling status of the bucket scan configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not configured.</description></item>
            /// <item><description><b>1</b>: Configured and enabled.</description></item>
            /// <item><description><b>2</b>: Configured but not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public int? ConfigStatus { get; set; }

            /// <summary>
            /// <para>The enabling status of the bucket decompression configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Decompression not configured.</description></item>
            /// <item><description><b>1</b>: Decompression configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DecompressStatus")]
            [Validation(Required=false)]
            public int? DecompressStatus { get; set; }

            /// <summary>
            /// <para>The number of high-risk files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            /// <summary>
            /// <para>The end timestamp of the latest scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastScanEndTime")]
            [Validation(Required=false)]
            public long? LastScanEndTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The number of low-risk files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            /// <summary>
            /// <para>The number of medium-risk files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            /// <summary>
            /// <para>The reason why scanning is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unsupported Region。</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of scanned files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// <para>Indicates whether the bucket has been scanned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Scanned.</description></item>
            /// <item><description><b>false</b>: Not scanned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Scanned")]
            [Validation(Required=false)]
            public bool? Scanned { get; set; }

            /// <summary>
            /// <para>The detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Not scanned.</description></item>
            /// <item><description><b>2</b>: Full scan in progress.</description></item>
            /// <item><description><b>3</b>: Incremental scan in progress.</description></item>
            /// <item><description><b>4</b>: Scanned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The storage class of the bucket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: Standard LRS</description></item>
            /// <item><description><b>IA</b>: Infrequent Access LRS</description></item>
            /// <item><description><b>Archive</b>: Archive LRS</description></item>
            /// <item><description><b>ColdArchive</b>: Cold Archive LRS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Archive</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>Indicates whether scanning is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Supported.</description></item>
            /// <item><description>false: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

            /// <summary>
            /// <para>The total number of files in the bucket.</para>
            /// <remarks>
            /// <para>This parameter is obtained through the OSS GetBucketStat operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        /// <summary>
        /// <para>The paging information in a paging query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOssBucketScanInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListOssBucketScanInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page in a paging query.</para>
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
            /// <para>165</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The China value is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C578F36-92D2-552C-8AA0-86EB1AC2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

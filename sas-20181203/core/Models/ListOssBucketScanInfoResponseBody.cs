// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssBucketScanInfoResponseBodyData> Data { get; set; }
        public class ListOssBucketScanInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz-new02****</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>Configuration status, valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No Configuration.</description></item>
            /// <item><description><b>1</b>: Not Open.</description></item>
            /// <item><description><b>2</b>: Open.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public int? ConfigStatus { get; set; }

            /// <summary>
            /// <para>Bucket decompression configuration status, valid values:</para>
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
            /// <para>The number of high-risk objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            /// <summary>
            /// <para>The time when the most recent check ended. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastScanEndTime")]
            [Validation(Required=false)]
            public long? LastScanEndTime { get; set; }

            /// <summary>
            /// <para>The time when the bucket was last checked. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The number of low-risk objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            /// <summary>
            /// <para>The number of medium-risk objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            /// <summary>
            /// <para>The reason why the bucket cannot be checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unsupported Region.</para>
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
            /// <para>The number of objects that are checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// <para>Indicates whether the bucket is checked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Scanned")]
            [Validation(Required=false)]
            public bool? Scanned { get; set; }

            /// <summary>
            /// <para>The check status of the bucket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The bucket is not checked.</description></item>
            /// <item><description><b>2</b>: All objects in the bucket are being checked.</description></item>
            /// <item><description><b>3</b>: Only new objects are being checked.</description></item>
            /// <item><description><b>4</b>: The bucket is checked.</description></item>
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
            /// <item><description><b>Standard</b></description></item>
            /// <item><description><b>IA</b></description></item>
            /// <item><description><b>Archive</b></description></item>
            /// <item><description><b>ColdArchive</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Archive</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>Indicates whether the bucket can be checked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

            /// <summary>
            /// <para>The total number of objects in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        /// <summary>
        /// <para>The page information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOssBucketScanInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListOssBucketScanInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C578F36-92D2-552C-8AA0-86EB1AC2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

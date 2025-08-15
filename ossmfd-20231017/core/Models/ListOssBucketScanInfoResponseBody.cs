// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class ListOssBucketScanInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssBucketScanInfoResponseBodyData> Data { get; set; }
        public class ListOssBucketScanInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testBucket******</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public int? ConfigStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DecompressStatus")]
            [Validation(Required=false)]
            public int? DecompressStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1698388233884</para>
            /// </summary>
            [NameInMap("LastScanEndTime")]
            [Validation(Required=false)]
            public long? LastScanEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1698388233883</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Unsupported Region。</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Scanned")]
            [Validation(Required=false)]
            public bool? Scanned { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IA</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOssBucketScanInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListOssBucketScanInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2220FE66-76EF-5D9D-A0EE-3221CC******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTieringStorageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage usage data.</para>
        /// </summary>
        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public List<DescribeVodTieringStorageDataResponseBodyStorageData> StorageData { get; set; }
        public class DescribeVodTieringStorageDataResponseBodyStorageData : TeaModel {
            /// <summary>
            /// <para>The size of data stored for less than one month. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("LessthanMonthDatasize")]
            [Validation(Required=false)]
            public long? LessthanMonthDatasize { get; set; }

            /// <summary>
            /// <para>The storage region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The storage class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IA</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>The storage usage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("StorageUtilization")]
            [Validation(Required=false)]
            public long? StorageUtilization { get; set; }

            /// <summary>
            /// <para>The start time of the time interval. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-29T01:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

    }

}

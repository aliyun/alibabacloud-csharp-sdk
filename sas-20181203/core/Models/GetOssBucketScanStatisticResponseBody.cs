// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssBucketScanStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssBucketScanStatisticResponseBodyData Data { get; set; }
        public class GetOssBucketScanStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the authorization expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1714442403000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

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
            /// <para>The number of buckets that have not been scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoScanBucket")]
            [Validation(Required=false)]
            public int? NoScanBucket { get; set; }

            /// <summary>
            /// <para>The number of pay-as-you-go invocations used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PostPayInvokeCount")]
            [Validation(Required=false)]
            public long? PostPayInvokeCount { get; set; }

            /// <summary>
            /// <para>The number of prepaid authorization times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("PrePayAuthCount")]
            [Validation(Required=false)]
            public long? PrePayAuthCount { get; set; }

            /// <summary>
            /// <para>The number of prepaid invocations used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PrePayInvokeCount")]
            [Validation(Required=false)]
            public long? PrePayInvokeCount { get; set; }

            /// <summary>
            /// <para>The remaining number of authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemainAuth")]
            [Validation(Required=false)]
            public int? RemainAuth { get; set; }

            /// <summary>
            /// <para>The number of buckets that contain risky files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskBucket")]
            [Validation(Required=false)]
            public int? RiskBucket { get; set; }

            /// <summary>
            /// <para>The number of scanned files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// <para>The total number of buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalBucket")]
            [Validation(Required=false)]
            public int? TotalBucket { get; set; }

            /// <summary>
            /// <para>The total number of files in the buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The China Chinese system generates a unique identifier for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAC50208-E56B-5CC8-8738-2B219D1A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

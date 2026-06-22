// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of process details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnknownThreatDetectProcessResponseBodyData> Data { get; set; }
        public class ListUnknownThreatDetectProcessResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The analysis result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>black</b>: A malicious process.</para>
            /// </description></item>
            /// <item><description><para><b>white</b>: A normal process.</para>
            /// </description></item>
            /// <item><description><para><b>abnormal</b>: An abnormal process.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>white</para>
            /// </summary>
            [NameInMap("AnalyzeResult")]
            [Validation(Required=false)]
            public string AnalyzeResult { get; set; }

            [NameInMap("ExplanationEn")]
            [Validation(Required=false)]
            public string ExplanationEn { get; set; }

            [NameInMap("ExplanationZh")]
            [Validation(Required=false)]
            public string ExplanationZh { get; set; }

            /// <summary>
            /// <para>The timestamp of the first occurrence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b394b54ca632fe51c4ab4a6dbaf****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025031506350619216822625103151158982</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The process path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/bin/tar</para>
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// <para>Remarks about the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>safe process</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The SHA-256 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3a6fed5fc11392b3ee9f81caf017b48640d7458766a8eb0382899a605b41****</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListUnknownThreatDetectProcessResponseBodyPageInfo PageInfo { get; set; }
        public class ListUnknownThreatDetectProcessResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
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
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20456DD5-5CBF-5015-9173-12CA4246B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

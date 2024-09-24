// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedMaliciousFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the malicious image sample.</para>
        /// </summary>
        [NameInMap("GroupedMaliciousFileResponse")]
        [Validation(Required=false)]
        public List<DescribeGroupedMaliciousFilesResponseBodyGroupedMaliciousFileResponse> GroupedMaliciousFileResponse { get; set; }
        public class DescribeGroupedMaliciousFilesResponseBodyGroupedMaliciousFileResponse : TeaModel {
            /// <summary>
            /// <para>The timestamp generated when the first scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594907349000</para>
            /// </summary>
            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            /// <summary>
            /// <para>The number of affected images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public long? ImageCount { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596533942000</para>
            /// </summary>
            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            /// <summary>
            /// <para>The severity of the malicious image sample. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b></description></item>
            /// <item><description><b>suspicious</b></description></item>
            /// <item><description><b>remind</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The keyword of the malicious image sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSHELL_IMG</para>
            /// </summary>
            [NameInMap("MaliciousKey")]
            [Validation(Required=false)]
            public string MaliciousKey { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the malicious image sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d836968041f7683b5459****</para>
            /// </summary>
            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            /// <summary>
            /// <para>The name of the malicious image sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testFile</para>
            /// </summary>
            [NameInMap("MaliciousName")]
            [Validation(Required=false)]
            public string MaliciousName { get; set; }

            /// <summary>
            /// <para>The handling status of the malicious image sample. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unhandled</description></item>
            /// <item><description><b>1</b>: handled</description></item>
            /// <item><description><b>2</b>: verifying</description></item>
            /// <item><description><b>3</b>: whitelisted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeGroupedMaliciousFilesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeGroupedMaliciousFilesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8045E03E-6D91-4C53-9F22-5A1B84BB29D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

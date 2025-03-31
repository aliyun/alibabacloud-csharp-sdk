// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanMaliciousFileByTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: successful</description></item>
        /// <item><description><c>false</c>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52AE49C8-B91A-5C1A-821F-C34324B42F7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried malicious files.</para>
        /// </summary>
        [NameInMap("ScanMaliciousFiles")]
        [Validation(Required=false)]
        public List<ListScanMaliciousFileByTaskResponseBodyScanMaliciousFiles> ScanMaliciousFiles { get; set; }
        public class ListScanMaliciousFileByTaskResponseBodyScanMaliciousFiles : TeaModel {
            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10 11:42:06</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The path of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenant/0000000000000000/</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The time when the image was first scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10 11:42:06</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The severity of the malicious file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remind</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the malicious file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e76c9759783cbbc9be0ff91ca3xxxxxx</para>
            /// </summary>
            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            /// <summary>
            /// <para>The type of the malicious file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Suspected to contain Webshell code</para>
            /// </summary>
            [NameInMap("MaliciousName")]
            [Validation(Required=false)]
            public string MaliciousName { get; set; }

            /// <summary>
            /// <para>The ID of the image scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe2d8980-de45-4f55-b57d-e438e6d2e972</para>
            /// </summary>
            [NameInMap("ScanTaskId")]
            [Validation(Required=false)]
            public string ScanTaskId { get; set; }

            /// <summary>
            /// <para>The time when the image was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-10 11:42:06</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

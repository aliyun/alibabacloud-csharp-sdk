// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

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
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the processes.</para>
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<DescribeWhiteListProcessResponseBodyProcesses> Processes { get; set; }
        public class DescribeWhiteListProcessResponseBodyProcesses : TeaModel {
            /// <summary>
            /// <para>The path to the process startup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/bash1</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The primary key of the process information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2100019</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The trust score of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the process startup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a28e8eba54ece1f3748d80e57dc89400</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The ID of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53090</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public int? ProcessId { get; set; }

            /// <summary>
            /// <para>The name of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vim</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The type of the process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: trusted</description></item>
            /// <item><description><b>2</b>: suspicious</description></item>
            /// <item><description><b>3</b>: malicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProcessType")]
            [Validation(Required=false)]
            public int? ProcessType { get; set; }

            /// <summary>
            /// <para>Indicates whether the process is trusted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: no</description></item>
            /// <item><description><b>2</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D81DD78E-E006-5C65-A171-C8CB09XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

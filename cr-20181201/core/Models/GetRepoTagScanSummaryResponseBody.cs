// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of medium-severity vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of low-severity vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("HighSeverity")]
        [Validation(Required=false)]
        public int? HighSeverity { get; set; }

        /// <summary>
        /// <para>The number of high-severity vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>89</para>
        /// </summary>
        [NameInMap("LowSeverity")]
        [Validation(Required=false)]
        public int? LowSeverity { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("MediumSeverity")]
        [Validation(Required=false)]
        public int? MediumSeverity { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities detected on images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC648259-91A7-4502-BED3-EDF64361FA83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>196</para>
        /// </summary>
        [NameInMap("TotalSeverity")]
        [Validation(Required=false)]
        public int? TotalSeverity { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnknownSeverity")]
        [Validation(Required=false)]
        public int? UnknownSeverity { get; set; }

    }

}

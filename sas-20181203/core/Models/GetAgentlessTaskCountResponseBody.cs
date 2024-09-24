// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of baseline checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BaselineCheckCount")]
        [Validation(Required=false)]
        public int? BaselineCheckCount { get; set; }

        /// <summary>
        /// <para>The number of system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CveVulCount")]
        [Validation(Required=false)]
        public int? CveVulCount { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the last detection is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682577532318</para>
        /// </summary>
        [NameInMap("LastTaskTime")]
        [Validation(Required=false)]
        public long? LastTaskTime { get; set; }

        /// <summary>
        /// <para>The number of malicious files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaliciousFile")]
        [Validation(Required=false)]
        public int? MaliciousFile { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of risky hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskMachine")]
        [Validation(Required=false)]
        public int? RiskMachine { get; set; }

        /// <summary>
        /// <para>The number of application vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaVulCount")]
        [Validation(Required=false)]
        public int? ScaVulCount { get; set; }

        /// <summary>
        /// <para>The number of hosts that are scanned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanMachine")]
        [Validation(Required=false)]
        public int? ScanMachine { get; set; }

        /// <summary>
        /// <para>The total number of sensitive files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SensitiveFileCount")]
        [Validation(Required=false)]
        public int? SensitiveFileCount { get; set; }

        /// <summary>
        /// <para>The total number of Windows system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SysVulCount")]
        [Validation(Required=false)]
        public string SysVulCount { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public int? Vulnerability { get; set; }

    }

}

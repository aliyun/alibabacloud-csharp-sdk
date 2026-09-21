// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DataValue : TeaModel {
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
        /// <para>The number of scanned hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScanMachine")]
        [Validation(Required=false)]
        public int? ScanMachine { get; set; }

        /// <summary>
        /// <para>The total number of malicious sample files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaliciousFile")]
        [Validation(Required=false)]
        public int? MaliciousFile { get; set; }

        /// <summary>
        /// <para>The number of vulnerability risks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public int? Vulnerability { get; set; }

        /// <summary>
        /// <para>The timestamp of the last scan time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682577532318</para>
        /// </summary>
        [NameInMap("LastTaskTime")]
        [Validation(Required=false)]
        public long? LastTaskTime { get; set; }

        /// <summary>
        /// <para>The total number of baseline check items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BaselineCheckCount")]
        [Validation(Required=false)]
        public int? BaselineCheckCount { get; set; }

        /// <summary>
        /// <para>The total number of application vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaVulCount")]
        [Validation(Required=false)]
        public int? ScaVulCount { get; set; }

        /// <summary>
        /// <para>The total number of system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CveVulCount")]
        [Validation(Required=false)]
        public int? CveVulCount { get; set; }

        /// <summary>
        /// <para>The total number of Windows system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SysVulCount")]
        [Validation(Required=false)]
        public int? SysVulCount { get; set; }

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
        /// <para>The estimated detection volume. Unit: GB. This field is not returned by the batch statistics operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("EstimateUsedSize")]
        [Validation(Required=false)]
        public long? EstimateUsedSize { get; set; }

        /// <summary>
        /// <para>The number of Linux software vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CveNum")]
        [Validation(Required=false)]
        public int? CveNum { get; set; }

        /// <summary>
        /// <para>The number of emergency vulnerabilities. This field is 0 when ImageVul is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EmgNum")]
        [Validation(Required=false)]
        public int? EmgNum { get; set; }

        /// <summary>
        /// <para>The number of Windows system vulnerabilities. This field is 0 when ImageVul is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SysNum")]
        [Validation(Required=false)]
        public int? SysNum { get; set; }

        /// <summary>
        /// <para>The number of Web-CMS vulnerabilities. This field is 0 when ImageVul is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CmsNum")]
        [Validation(Required=false)]
        public int? CmsNum { get; set; }

        /// <summary>
        /// <para>The number of application vulnerabilities. This field is 0 when ImageVul is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AppNum")]
        [Validation(Required=false)]
        public int? AppNum { get; set; }

        /// <summary>
        /// <para>The number of software composition analysis (SCA) vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaNum")]
        [Validation(Required=false)]
        public int? ScaNum { get; set; }

        /// <summary>
        /// <para>The number of high-priority vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        /// <summary>
        /// <para>The number of medium-priority vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        /// <summary>
        /// <para>The number of low-priority vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

        /// <summary>
        /// <para>The number of high-priority system vulnerabilities among Linux software vulnerabilities and Windows system vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SysAsapNum")]
        [Validation(Required=false)]
        public int? SysAsapNum { get; set; }

    }

}

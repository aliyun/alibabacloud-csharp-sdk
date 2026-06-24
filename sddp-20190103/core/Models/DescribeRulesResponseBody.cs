// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesResponseBody : TeaModel {
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
        /// <para>A list of sensitive data detection rules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeRulesResponseBodyItems> Items { get; set; }
        public class DescribeRulesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The audit mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuditMode")]
            [Validation(Required=false)]
            public int? AuditMode { get; set; }

            /// <summary>
            /// <para>The type of content in the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: keyword</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: regular expression</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The name of the content type for the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Regular expression</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The content of the sensitive data detection rule.</para>
            /// <remarks>
            /// <para>The content of a built-in rule, for which CustomType is 0, is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>(?:\\D|^)((?:(?:25[0-4]|2[0-4]\\d|1\\d{2}|[1-9]\\d{1})\\.)(?:(?:25[0-5]|2[0-4]\\d|[01]?\\d?\\d)\\.){2}(?:25[0-5]|2[0-4]\\d|1[0-9]\\d|[1-9]\\d|[1-9]))(?:\\D|$)</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The content type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: SQL injection exploits</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: SQL injection bypass attempts</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: stored procedure abuse</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: buffer overflows</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: error-based SQL injections</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContentCategory")]
            [Validation(Required=false)]
            public string ContentCategory { get; set; }

            /// <summary>
            /// <para>The type of the sensitive data detection rule.</para>
            /// <list type="bullet">
            /// <item><description><para>0: built-in</para>
            /// </description></item>
            /// <item><description><para>1: custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public int? CustomType { get; set; }

            /// <summary>
            /// <para>The description of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to identify IP addresses</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the user who created the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the sensitive data detection rule was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the sensitive data detection rule was last modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The parent group of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4_1</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The number of times the rule was hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HitTotalCount")]
            [Validation(Required=false)]
            public int? HitTotalCount { get; set; }

            /// <summary>
            /// <para>The unique ID of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The logon name of the user who created the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// <para>The primary dimension key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("MajorKey")]
            [Validation(Required=false)]
            public string MajorKey { get; set; }

            /// <summary>
            /// <para>The match type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: rule-based match</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: dictionary-based match</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public int? MatchType { get; set; }

            /// <summary>
            /// <para>A collection of model IDs for sensitive data auditing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1452</para>
            /// </summary>
            [NameInMap("ModelRuleIds")]
            [Validation(Required=false)]
            public string ModelRuleIds { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP address</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b></para>
            /// </description></item>
            /// <item><description><para><b>OSS</b></para>
            /// </description></item>
            /// <item><description><para><b>ADS</b></para>
            /// </description></item>
            /// <item><description><para><b>OTS</b></para>
            /// </description></item>
            /// <item><description><para><b>RDS</b></para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The sensitivity level ID of the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: N/A. No sensitive data is detected.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: S1. Level 1 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: S2. Level 2 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: S3. Level 3 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: S4. Level 4 sensitive data.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>N/A</b>: No sensitive data is detected.</para>
            /// </description></item>
            /// <item><description><para><b>S1</b>: Level 1 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>S2</b>: Level 2 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>S3</b>: Level 3 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>S4</b>: Level 4 sensitive data.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The statistical expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatExpress")]
            [Validation(Required=false)]
            public string StatExpress { get; set; }

            /// <summary>
            /// <para>The detection status of the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of data asset that the rule supports. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: all assets</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: structured assets</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: unstructured assets</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SupportForm")]
            [Validation(Required=false)]
            public int? SupportForm { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b></para>
            /// </description></item>
            /// <item><description><para><b>OSS</b></para>
            /// </description></item>
            /// <item><description><para><b>ADS</b></para>
            /// </description></item>
            /// <item><description><para><b>OTS</b></para>
            /// </description></item>
            /// <item><description><para><b>RDS</b></para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>A collection of template IDs for sensitive data auditing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateRuleIds")]
            [Validation(Required=false)]
            public string TemplateRuleIds { get; set; }

            /// <summary>
            /// <para>The threat analysis mode status. Valid values: 0 (disabled), 1 (enabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThreatAnalysisStatus")]
            [Validation(Required=false)]
            public int? ThreatAnalysisStatus { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Low</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: High</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public int? WarnLevel { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

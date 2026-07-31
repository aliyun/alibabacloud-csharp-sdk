// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBaseSystemRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80736FA5-FA87-55F6-AA69-C5477C6FE6D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of system protection rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeBaseSystemRulesResponseBodyRules> Rules { get; set; }
        public class DescribeBaseSystemRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The CVE ID of the vulnerability associated with the system rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2021-34538</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The detection module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sqli</b>: SQL injection.</description></item>
            /// <item><description><b>xss</b>: cross-site scripting (XSS).</description></item>
            /// <item><description><b>cmdi</b>: OS command injection.</description></item>
            /// <item><description><b>expression_injection</b>: expression injection.</description></item>
            /// <item><description><b>java_deserialization</b>: Java deserialization.</description></item>
            /// <item><description><b>dot_net_deserialization</b>: .NET deserialization.</description></item>
            /// <item><description><b>php_deserialization</b>: PHP deserialization.</description></item>
            /// <item><description><b>code_exec</b>: code execution.</description></item>
            /// <item><description><b>ssrf</b>: server-side request forgery (SSRF).</description></item>
            /// <item><description><b>path_traversal</b>: path traversal.</description></item>
            /// <item><description><b>arbitrary_file_uploading</b>: arbitrary file upload.</description></item>
            /// <item><description><b>webshell</b>: webshell.</description></item>
            /// <item><description><b>rfilei</b>: remote file inclusion (RFI).</description></item>
            /// <item><description><b>lfilei</b>: local file inclusion (LFI).</description></item>
            /// <item><description><b>protocol_violation</b>: protocol violation.</description></item>
            /// <item><description><b>scanner_behavior</b>: scanner behavior.</description></item>
            /// <item><description><b>logic_flaw</b>: business logic bug.</description></item>
            /// <item><description><b>arbitrary_file_reading</b>: arbitrary file reading.</description></item>
            /// <item><description><b>arbitrary_file_download</b>: arbitrary file download.</description></item>
            /// <item><description><b>xxe</b>: XML external entity injection.</description></item>
            /// <item><description><b>csrf</b>: cross-site request forgery.</description></item>
            /// <item><description><b>crlf</b>: CRLF.</description></item>
            /// <item><description><b>other</b>: other.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sqli</para>
            /// </summary>
            [NameInMap("DetectType")]
            [Validation(Required=false)]
            public string DetectType { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>super_strict</b>: Super strict.</para>
            /// </description></item>
            /// <item><description><para><b>strict</b>: Strict.</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: Medium.</para>
            /// </description></item>
            /// <item><description><para><b>loose</b>: Loose.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>super_strict</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The rule action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>block</b>: Block.</para>
            /// </description></item>
            /// <item><description><para><b>monitor</b>: Monitor.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113089</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>systemRuleTest</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// <item><description><b>0</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

            /// <summary>
            /// <para>The time when the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665460629000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

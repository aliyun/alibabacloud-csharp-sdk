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
            /// <para>The CVE ID of the vulnerability that is associated with the system protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2021-34538</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The description of the system protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of attack that the system protection rule detects. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>sqli</b>: SQL injection.</para>
            /// </description></item>
            /// <item><description><para><b>xss</b>: cross-site scripting (XSS).</para>
            /// </description></item>
            /// <item><description><para><b>cmdi</b>: OS command injection.</para>
            /// </description></item>
            /// <item><description><para><b>expression_injection</b>: expression injection.</para>
            /// </description></item>
            /// <item><description><para><b>java_deserialization</b>: Java deserialization.</para>
            /// </description></item>
            /// <item><description><para><b>dot_net_deserialization</b>: .NET deserialization.</para>
            /// </description></item>
            /// <item><description><para><b>php_deserialization</b>: PHP deserialization.</para>
            /// </description></item>
            /// <item><description><para><b>code_exec</b>: code execution.</para>
            /// </description></item>
            /// <item><description><para><b>ssrf</b>: server-side request forgery (SSRF).</para>
            /// </description></item>
            /// <item><description><para><b>path_traversal</b>: path traversal.</para>
            /// </description></item>
            /// <item><description><para><b>arbitrary_file_uploading</b>: arbitrary file upload.</para>
            /// </description></item>
            /// <item><description><para><b>webshell</b>: webshell.</para>
            /// </description></item>
            /// <item><description><para><b>rfilei</b>: remote file inclusion (RFI).</para>
            /// </description></item>
            /// <item><description><para><b>lfilei</b>: local file inclusion (LFI).</para>
            /// </description></item>
            /// <item><description><para><b>protocol_violation</b>: protocol violation.</para>
            /// </description></item>
            /// <item><description><para><b>scanner_behavior</b>: scanner behavior.</para>
            /// </description></item>
            /// <item><description><para><b>logic_flaw</b>: logic flaw.</para>
            /// </description></item>
            /// <item><description><para><b>arbitrary_file_reading</b>: arbitrary file read.</para>
            /// </description></item>
            /// <item><description><para><b>arbitrary_file_download</b>: arbitrary file download.</para>
            /// </description></item>
            /// <item><description><para><b>xxe</b>: external entity injection.</para>
            /// </description></item>
            /// <item><description><para><b>csrf</b>: cross-site request forgery (CSRF).</para>
            /// </description></item>
            /// <item><description><para><b>crlf</b>: CRLF injection.</para>
            /// </description></item>
            /// <item><description><para><b>other</b>: other.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sqli</para>
            /// </summary>
            [NameInMap("DetectType")]
            [Validation(Required=false)]
            public string DetectType { get; set; }

            /// <summary>
            /// <para>The risk level of the system protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>super_strict</b>: Very Strict.</para>
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
            /// <para>The action of the system protection rule. Valid values:</para>
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
            /// <para>The ID of the system protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113089</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the system protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>systemRuleTest</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the system protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

            /// <summary>
            /// <para>The time when the system protection rule was last updated. This value is a UNIX timestamp. Unit: milliseconds.</para>
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

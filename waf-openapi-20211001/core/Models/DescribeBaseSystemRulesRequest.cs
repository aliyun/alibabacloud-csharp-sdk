// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBaseSystemRulesRequest : TeaModel {
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
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of your WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

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
        /// <para>loose</para>
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
        /// <para>The ID of the system protection rule to query.</para>
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
        /// <para>The ID of the protection template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify this parameter to query the system protection rules in a specific WAF protection template.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the default configurations of the system protection rules are queried.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24354</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

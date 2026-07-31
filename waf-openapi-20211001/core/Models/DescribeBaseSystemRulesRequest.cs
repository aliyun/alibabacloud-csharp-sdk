// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBaseSystemRulesRequest : TeaModel {
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
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The language of the returned rule content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number to return in a paged query. Default value: <b>1</b>, which indicates the first page. For more information about paging, see the PageSize parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: 100, which indicates 100 entries per page. For more information about paging, see the PageNumber parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
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
        /// <para>loose</para>
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
        /// <para>The ID of the system protection rule to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113089</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The list of system protection rule IDs to query.</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<long?> RuleIds { get; set; }

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
        /// <para>The ID of the protection template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify this parameter to query the system protection rules in a specific Web core protection rule template.</description></item>
        /// <item><description>If this parameter is left empty, the default settings of system protection rules are queried.</description></item>
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

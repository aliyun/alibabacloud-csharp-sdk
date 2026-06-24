// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: keyword.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: regular expression.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>The content of the sensitive data detection rule. The content can be a regular expression or a keyword that is used to match sensitive data fields or text.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para><b>1</b>: SQL injection exploit.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: SQL injection bypass.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: stored procedure abuse.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: buffer overflow.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: error-based SQL injection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentCategory")]
        [Validation(Required=false)]
        public int? ContentCategory { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID card</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
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
        /// <para>The match type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: rule-based match.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: dictionary-based match.</para>
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
        /// <para>The IDs of the model rules for sensitive data auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1452</para>
        /// </summary>
        [NameInMap("ModelRuleIds")]
        [Validation(Required=false)]
        public string ModelRuleIds { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-tst</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the service to which the data asset belongs. Valid values: <b>MaxCompute</b>, <b>OSS</b>, <b>ADS</b>, <b>OTS</b>, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
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
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: data detection rule.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: audit policy.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: anomaly detection rule.</para>
        /// </description></item>
        /// <item><description><para><b>99</b>: custom rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The statistical expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:&quot;24&quot;,&quot;groupby&quot;:&quot;1003&quot;,&quot;having&quot;:[{&quot;key&quot;:&quot;2001&quot;,&quot;value&quot;:&quot;50&quot;}]}</para>
        /// </summary>
        [NameInMap("StatExpress")]
        [Validation(Required=false)]
        public string StatExpress { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled.</para>
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
        /// <para>The type of data assets that the rule supports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: all assets.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: structured assets.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: unstructured assets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

        /// <summary>
        /// <para>The code of the service to which the rule applies. Valid values: <b>MaxCompute</b>, <b>OSS</b>, <b>ADS</b>, <b>OTS</b>, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The IDs of the template rules for sensitive data auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Low.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Medium.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: High.</para>
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

}

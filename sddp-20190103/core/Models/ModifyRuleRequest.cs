// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleRequest : TeaModel {
        /// <summary>
        /// <para>The type of the content in the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: regular expression.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: algorithm.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: keyword.</para>
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
        /// <para>The content of the sensitive data detection rule. The rule can be a regular expression, an algorithm, or a keyword, and matches fields or text that contain sensitive data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(?:\\D|^)((?:(?:25[0-4]|2[0-4]\\d|1\\d{2}|[1-9]\\d{1})\\.)(?:(?:25[0-5]|2[0-4]\\d|[01]?\\d?\\d)\\.){2}(?:25[0-5]|2[0-4]\\d|1[0-9]\\d|[1-9]\\d|[1-9]))(?:\\D|$)</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The unique ID of the sensitive data detection rule.</para>
        /// <para>You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
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
        /// <para>You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to obtain the rule name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esw</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the product resource that contains the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MaxCompute</b>.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>ADS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>OTS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>RDS</b>.</para>
        /// </description></item>
        /// <item><description><para><b>SELF_DB</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the product that contains the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADS.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: OTS.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: SELF_DB.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the risk level for the sensitive data detection rule. Valid values:</para>
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
        /// <para>The type of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: data detection rule.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: audit policy.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: abnormal event rule.</para>
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
        /// <para>The type of data asset that the rule supports. Valid values:</para>
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
        /// <para>A collection of template IDs for sensitive data auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

        /// <summary>
        /// <para>The risk level of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: low.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: medium.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: high.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

    }

}

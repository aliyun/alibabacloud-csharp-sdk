// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleRequest : TeaModel {
        /// <summary>
        /// <para>The type of the sensitive data detection rule content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: regular expression.</description></item>
        /// <item><description><b>3</b>: algorithm.</description></item>
        /// <item><description><b>5</b>: keyword.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>The content of the sensitive data detection rule. The content can be a regular expression, algorithm, or keyword that is used to match sensitive data fields or text.</para>
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
        /// <para>You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to obtain the rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese.</description></item>
        /// <item><description><b>en_us</b>: English (US).</description></item>
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
        /// <item><description><b>1</b>: rule match.</description></item>
        /// <item><description><b>2</b>: dictionary match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        /// <summary>
        /// <para>The collection of model IDs associated with the sensitive data audit.</para>
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
        /// <para>The resource type of the product that contains the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MaxCompute</b></description></item>
        /// <item><description><b>OSS</b></description></item>
        /// <item><description><b>ADS</b></description></item>
        /// <item><description><b>OTS</b></description></item>
        /// <item><description><b>RDS</b></description></item>
        /// <item><description><b>SELF_DB</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product ID of the product that contains the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute.</description></item>
        /// <item><description><b>2</b>: OSS.</description></item>
        /// <item><description><b>3</b>: ADS.</description></item>
        /// <item><description><b>4</b>: OTS.</description></item>
        /// <item><description><b>5</b>: RDS.</description></item>
        /// <item><description><b>6</b>: SELF_DB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The risk level ID of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A. No sensitive data is detected.</description></item>
        /// <item><description><b>2</b>: S1. Level-1 sensitive data.</description></item>
        /// <item><description><b>3</b>: S2. Level-2 sensitive data.</description></item>
        /// <item><description><b>4</b>: S3. Level-3 sensitive data.</description></item>
        /// <item><description><b>5</b>: S4. Level-4 sensitive data.</description></item>
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
        /// <item><description><b>1</b>: data detection rule.</description></item>
        /// <item><description><b>2</b>: audit policy.</description></item>
        /// <item><description><b>3</b>: anomalous activity rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The data asset type supported by the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: all assets.</description></item>
        /// <item><description><b>1</b>: structured assets.</description></item>
        /// <item><description><b>2</b>: unstructured assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

        /// <summary>
        /// <para>The collection of template IDs associated with the sensitive data audit.</para>
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
        /// <item><description><b>1</b>: low.</description></item>
        /// <item><description><b>2</b>: medium.</description></item>
        /// <item><description><b>3</b>: high.</description></item>
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

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
        /// <item><description><b>0</b>: keyword</description></item>
        /// <item><description><b>2</b>: regular expression</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>The content of the sensitive data detection rule. You can specify a regular expression or keywords that are used to match sensitive fields or text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(?:\\D|^)((?:(?:25[0-4]|2[0-4]\\d|1\\d{2}|[1-9]\\d{1})\\.)(?:(?:25[0-5]|2[0-4]\\d|[01]?\\d?\\d)\\.){2}(?:25[0-5]|2[0-4]\\d|1[0-9]\\d|[1-9]\\d|[1-9]))(?:\\D|$)</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The type of the content in the sensitive data detection rule. Valid values include <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates attempts to exploit SQL injections. The value 2 indicates bypass by using SQL injections. The value 3 indicates abuse of stored procedures. The value 4 indicates buffer overflow. The value 5 indicates SQL injections based on errors.</para>
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
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <item><description><b>1</b>: rule-based match</description></item>
        /// <item><description><b>2</b>: dictionary-based match</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        /// <summary>
        /// <para>The IDs of the models for sensitive data audit.</para>
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
        /// <para>The name of the service to which data in the column of the table belongs. Valid values include <b>MaxCompute</b>, <b>OSS</b>, <b>ADS</b>, <b>OTS</b>, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the data asset belongs. Valid values include <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates Object Storage Service (OSS). The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the sensitive data that hits the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
        /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
        /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
        /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
        /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
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
        /// <item><description><b>1</b>: sensitive data detection rule</description></item>
        /// <item><description><b>2</b>: audit rule</description></item>
        /// <item><description><b>3</b>: anomalous event detection rule</description></item>
        /// <item><description><b>99</b>: custom rule</description></item>
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
        /// <para>39.170.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

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
        /// <para>Specifies whether to enable the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The type of the data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: all data assets</description></item>
        /// <item><description><b>1</b>: structured data asset</description></item>
        /// <item><description><b>2</b>: unstructured data asset</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set the parameter to 1 or 2, rules that support all data assets and rules that support the queried data asset type are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

        /// <summary>
        /// <para>The code of the service to which the sensitive data detection rule is applied. Valid values include <b>MaxCompute</b>, <b>OSS</b>, <b>ADS</b>, <b>OTS</b>, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The IDs of the templates that are used to audit sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateRuleIds")]
        [Validation(Required=false)]
        public string TemplateRuleIds { get; set; }

        /// <summary>
        /// <para>The risk level of the alert that is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: low</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: high</description></item>
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

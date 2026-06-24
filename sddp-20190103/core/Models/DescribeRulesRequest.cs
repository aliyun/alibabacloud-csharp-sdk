// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesRequest : TeaModel {
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
        public int? ContentCategory { get; set; }

        /// <summary>
        /// <para>The source of the external cooperation request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DAS</para>
        /// </description></item>
        /// <item><description><para>YAOCHI</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAS</para>
        /// </summary>
        [NameInMap("CooperationChannel")]
        [Validation(Required=false)]
        public string CooperationChannel { get; set; }

        /// <summary>
        /// <para>The page number of the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: built-in</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: custom</para>
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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

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
        /// <para>Specifies whether the keyword is compatible with earlier versions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In earlier versions, the Category parameter for keywords had a value of 0. In the current version, it has a value of 5. Enable this parameter based on your business needs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeywordCompatible")]
        [Validation(Required=false)]
        public bool? KeywordCompatible { get; set; }

        /// <summary>
        /// <para>The language of the request and response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <item><description><para>1: rule-based match</para>
        /// </description></item>
        /// <item><description><para>2: dictionary-based match</para>
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
        /// <para>The name of the sensitive data detection rule. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***Rule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        public int? ProductCode { get; set; }

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
        /// <para>1</para>
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
        /// <para>The type of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: data detection rule</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: audit policy</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: anomaly detection rule</para>
        /// </description></item>
        /// <item><description><para><b>99</b>: custom rule</para>
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
        /// <para>Specifies whether to return a simplified version of the rule that contains only the rule name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Simplify")]
        [Validation(Required=false)]
        public bool? Simplify { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Normal</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled</para>
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
        /// <remarks>
        /// <para>When you query for rules that support structured or unstructured assets, the response also includes rules that support all asset types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportForm")]
        [Validation(Required=false)]
        public int? SupportForm { get; set; }

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

}

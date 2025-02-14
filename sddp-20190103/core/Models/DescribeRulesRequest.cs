// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesRequest : TeaModel {
        /// <summary>
        /// <para>The content type of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: keyword</description></item>
        /// <item><description><b>2</b>: regular expression</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

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
        /// <para>The external cooperation channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAS</description></item>
        /// <item><description>YAOCHI</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAS</para>
        /// </summary>
        [NameInMap("CooperationChannel")]
        [Validation(Required=false)]
        public string CooperationChannel { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
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
        /// <item><description><b>0</b>: built-in rule</description></item>
        /// <item><description><b>1</b>: custom rule</description></item>
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
        /// <para>The parent group type of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4_1</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow earlier versions of request parameters to support keywords that are supported in later versions of request parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para>To specify keywords as the content type of the sensitive data detection rule, you can set the Category parameter to 0 for earlier versions of request parameters and set the Category parameter to 5 for later versions of request parameters. You can specify the KeywordCompatible parameter based on your business requirements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeywordCompatible")]
        [Validation(Required=false)]
        public bool? KeywordCompatible { get; set; }

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
        /// <item><description>1: rule-based match</description></item>
        /// <item><description>2: dictionary-based match</description></item>
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
        /// <para>\<em>\</em>\* rule</para>
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
        /// <para>The name of the service to which the data asset belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public int? ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the sensitive data detection rule is applied. Valid values include <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates Object Storage Service (OSS). The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>Specifies whether to query a simplified rule. The simplified rule contains only the rule name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Simplify")]
        [Validation(Required=false)]
        public bool? Simplify { get; set; }

        /// <summary>
        /// <para>The status of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
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
        /// <para>The severity level of the alert. Valid values:</para>
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

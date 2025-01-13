// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>An array that consists of the sensitive data detection rules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeRulesResponseBodyItems> Items { get; set; }
        public class DescribeRulesResponseBodyItems : TeaModel {
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
            /// <para>The name of the content type of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Regular expression</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The content in the sensitive data detection rule.</para>
            /// <remarks>
            /// <para> A built-in detection rule whose CustomType is 0 does not return the content of the rule.</para>
            /// </remarks>
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
            public string ContentCategory { get; set; }

            /// <summary>
            /// <para>The type of the sensitive data detection rule.</para>
            /// <list type="bullet">
            /// <item><description>0: built-in rule</description></item>
            /// <item><description>1: custom rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CustomType")]
            [Validation(Required=false)]
            public int? CustomType { get; set; }

            /// <summary>
            /// <para>The description of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The sensitive data detection rule is used to detect IP addresses.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the account that is used to create the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the sensitive data detection rule is created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the sensitive data detection rule is modified. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

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
            /// <para>The number of times that the sensitive data detection rule is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HitTotalCount")]
            [Validation(Required=false)]
            public int? HitTotalCount { get; set; }

            /// <summary>
            /// <para>The ID of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The username of the account that is used to create the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// <para>The key of the primary dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("MajorKey")]
            [Validation(Required=false)]
            public string MajorKey { get; set; }

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

            [NameInMap("ModelRuleIds")]
            [Validation(Required=false)]
            public string ModelRuleIds { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP address</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the sensitive data detection rule is applied. Valid values include <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
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
            /// <para>The sensitivity level of data that hits the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>S1</b>: indicates the low sensitivity level.</description></item>
            /// <item><description><b>S2</b>: indicates the medium sensitivity level.</description></item>
            /// <item><description><b>S3</b>: indicates the high sensitivity level.</description></item>
            /// <item><description><b>S4</b>: indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

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
            /// <para>The status of the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The data asset type that is supported by the sensitive data detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: all data assets</description></item>
            /// <item><description><b>1</b>: structured data assets</description></item>
            /// <item><description><b>2</b>: unstructured data assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SupportForm")]
            [Validation(Required=false)]
            public int? SupportForm { get; set; }

            /// <summary>
            /// <para>The name of the service to which the data asset belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TemplateRuleIds")]
            [Validation(Required=false)]
            public string TemplateRuleIds { get; set; }

            /// <summary>
            /// <para>The ID of the account that is used to create the sensitive data detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The severity level. Valid values:</para>
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

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

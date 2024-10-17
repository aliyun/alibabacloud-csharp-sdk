// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The keyword that is used to search for data assets. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the data asset that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute project</description></item>
        /// <item><description><b>2</b>: MaxCompute table</description></item>
        /// <item><description><b>3</b>: MaxCompute package</description></item>
        /// <item><description><b>11</b>: AnalyticDB for MySQL database</description></item>
        /// <item><description><b>12</b>: AnalyticDB for MySQL table</description></item>
        /// <item><description><b>21</b>: Object Storage Service (OSS) bucket</description></item>
        /// <item><description><b>22</b>: OSS object</description></item>
        /// <item><description><b>31</b>: Tablestore instance</description></item>
        /// <item><description><b>32</b>: Tablestore table</description></item>
        /// <item><description><b>51</b>: ApsaraDB RDS database</description></item>
        /// <item><description><b>52</b>: ApsaraDB RDS table</description></item>
        /// <item><description><b>61</b>: self-managed database hosted on an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>62</b>: self-managed table hosted on an ECS instance</description></item>
        /// <item><description><b>71</b>: PolarDB-X database</description></item>
        /// <item><description><b>72</b>: PolarDB-X table</description></item>
        /// <item><description><b>81</b>: PolarDB database</description></item>
        /// <item><description><b>82</b>: PolarDB table</description></item>
        /// <item><description><b>91</b>: AnalyticDB for PostgreSQL database</description></item>
        /// <item><description><b>92</b>: AnalyticDB for PostgreSQL table</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RangeId")]
        [Validation(Required=false)]
        public int? RangeId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the data asset. Separate multiple sensitivity levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: S1, indicating the low sensitivity level</description></item>
        /// <item><description><b>3</b>: S2, indicating the medium sensitivity level</description></item>
        /// <item><description><b>4</b>: S3, indicating the high sensitivity level</description></item>
        /// <item><description><b>5</b>: S4, indicating the highest sensitivity level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// <para>The unique ID of the sensitive data detection rule that the data assets to be queried hit.</para>
        /// <remarks>
        /// <para>If you query sensitive data detection results based on the sensitive data detection rule that the data assets hit, you can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to query the ID of the sensitive data detection rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11122200</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}

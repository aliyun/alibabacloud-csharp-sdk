// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese (Simplified)</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English (US)</para>
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
        /// <para>The keyword for a fuzzy search of data assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of data asset to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute project</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: MaxCompute table</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: MaxCompute package</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: AnalyticDB for MySQL database</para>
        /// </description></item>
        /// <item><description><para><b>12</b>: AnalyticDB for MySQL table</para>
        /// </description></item>
        /// <item><description><para><b>21</b>: OSS bucket</para>
        /// </description></item>
        /// <item><description><para><b>22</b>: OSS object</para>
        /// </description></item>
        /// <item><description><para><b>31</b>: Tablestore instance</para>
        /// </description></item>
        /// <item><description><para><b>32</b>: Tablestore table</para>
        /// </description></item>
        /// <item><description><para><b>51</b>: RDS database</para>
        /// </description></item>
        /// <item><description><para><b>52</b>: RDS table</para>
        /// </description></item>
        /// <item><description><para><b>61</b>: Self-managed database on an ECS instance</para>
        /// </description></item>
        /// <item><description><para><b>62</b>: Self-managed table on an ECS instance</para>
        /// </description></item>
        /// <item><description><para><b>71</b>: DRDS database</para>
        /// </description></item>
        /// <item><description><para><b>72</b>: DRDS table</para>
        /// </description></item>
        /// <item><description><para><b>81</b>: PolarDB database</para>
        /// </description></item>
        /// <item><description><para><b>82</b>: PolarDB table</para>
        /// </description></item>
        /// <item><description><para><b>91</b>: GPDB database</para>
        /// </description></item>
        /// <item><description><para><b>92</b>: GPDB table</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RangeId")]
        [Validation(Required=false)]
        public int? RangeId { get; set; }

        /// <summary>
        /// <para>The risk levels of the data assets to query. Separate multiple risk levels with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: S1, low risk level</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2, medium risk level</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3, high risk level</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4, highest risk level</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the data asset matches.</para>
        /// <remarks>
        /// <para>To find data assets based on the sensitive data detection rules they match, call the <a href="~~DescribeRules~~">DescribeRules</a> operation to get the rule IDs.</para>
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

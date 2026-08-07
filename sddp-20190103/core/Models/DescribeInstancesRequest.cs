// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese (Simplified).</description></item>
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
        /// <para>The search keyword. Fuzzy match is supported. For example, if you enter data, all data entries that contain data in the search item are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of data asset instances to return on each page in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the product to which the data asset instance belongs, such as MaxCompute, OSS, or RDS. For supported product names, see <a href="https://help.aliyun.com/document_detail/212906.html">Data types from which sensitive data can be detected</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the data asset instance belongs. You can call the <a href="~~DescribeDataAssets~~">DescribeDataAssets</a> operation to obtain the product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The risk level ID of the data asset instance. A higher risk level ID indicates more sensitive data is detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: No sensitive data is detected. No risk.</description></item>
        /// <item><description><b>2</b>: Sensitive data risk at level 1.</description></item>
        /// <item><description><b>3</b>: Sensitive data risk at level 2.</description></item>
        /// <item><description><b>4</b>: Sensitive data risk at level 3.</description></item>
        /// <item><description><b>5</b>: Sensitive data risk at level 4.</description></item>
        /// <item><description><b>6</b>: Sensitive data risk at level 5.</description></item>
        /// <item><description><b>7</b>: Sensitive data risk at level 6.</description></item>
        /// <item><description><b>8</b>: Sensitive data risk at level 7.</description></item>
        /// <item><description><b>9</b>: Sensitive data risk at level 8.</description></item>
        /// <item><description><b>10</b>: Sensitive data risk at level 9.</description></item>
        /// <item><description><b>11</b>: Sensitive data risk at level 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the data asset instance hits. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation and obtain the rule ID from the <b>Id</b> response parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region of the data asset instance. For more information, see <a href="https://help.aliyun.com/document_detail/214257.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}

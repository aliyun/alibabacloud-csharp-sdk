// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the paged query. Default value: <b>1</b>.</para>
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
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English</para>
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
        /// <para>The keyword to search for. Fuzzy match is supported. For example, if you enter &quot;data&quot;, all data that contains &quot;data&quot; is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of data asset instances to return on each page of a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the product to which the data asset instance belongs, such as MaxCompute, OSS, or RDS. For more information about the supported products, see <a href="https://help.aliyun.com/document_detail/212906.html">Data assets that can be scanned for sensitive data</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the data asset instance belongs. You can call the <a href="~~DescribeDataAssets~~">DescribeDataAssets</a> operation to query the product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the threat level for the data asset instance. The higher the threat level ID, the more sensitive the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: No sensitive data is detected. No threat.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Threat level 1.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Threat level 2.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Threat level 3.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Threat level 4.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Threat level 5.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: Threat level 6.</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: Threat level 7.</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: Threat level 8.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Threat level 9.</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: Threat level 10.</para>
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
        /// <para>The ID of the sensitive data detection rule that the data asset instance hits. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation and view the value of the <b>Id</b> parameter in the response to obtain the rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region where the data asset instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/214257.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}

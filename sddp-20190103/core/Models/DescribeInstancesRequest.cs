// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
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
        /// <para>The keyword that is used to search for data assets. DSC searches for data assets based on the keyword that you specify in fuzzy match mode. For example, if you specify data, all data assets whose names contain data are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service to which the data asset belongs, such as MaxCompute, OSS, and ApsaraDB RDS. For more information about the types of data assets from which DSC can scan for sensitive data, see <a href="https://help.aliyun.com/document_detail/212906.html">Supported data assets</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the data asset belongs. You can call the <a href="~~DescribeDataAssets~~">DescribeDataAssets</a> operation to query the ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The sensitivity level ID of the data asset. A higher sensitivity level indicates that the identified data is more sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: No sensitive data is identified.</description></item>
        /// <item><description><b>2</b>: sensitive data at level 1.</description></item>
        /// <item><description><b>3</b>: sensitive data at level 2.</description></item>
        /// <item><description><b>4</b>: sensitive data at level 3</description></item>
        /// <item><description><b>5</b>: sensitive data at level 4.</description></item>
        /// <item><description><b>6</b>: sensitive data at level 5.</description></item>
        /// <item><description><b>7</b>: sensitive data at level 6.</description></item>
        /// <item><description><b>8</b>: sensitive data at level 7.</description></item>
        /// <item><description><b>9</b>: sensitive data at level 8.</description></item>
        /// <item><description><b>10</b>: sensitive data at level 9.</description></item>
        /// <item><description><b>11</b>: sensitive data at level 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the data asset hits. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation and obtain the ID of the sensitive data detection rule from the <b>Id</b> response parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region where the data asset resides. For more information, see <a href="https://help.aliyun.com/document_detail/214257.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

    }

}

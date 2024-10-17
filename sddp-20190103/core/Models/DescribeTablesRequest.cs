// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeTablesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the data asset to which the table belongs. You can call the <a href="~~DescribeInstances~~">DescribeInstances</a> operation to obtain the ID of the data asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
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
        /// <para>The search keyword. Fuzzy match is supported. For example, if you specify test, all tables whose names contain test are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the package to which the table belongs. You can call the <a href="~~DescribePackages~~">DescribePackages</a> operation to obtain the ID of the package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>555555</para>
        /// </summary>
        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public long? PackageId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service to which the table belongs, such as MaxCompute, OSS, and ApsaraDB RDS. For more information about the types of data assets from which Data Security Center (DSC) can scan for sensitive data, see <a href="https://help.aliyun.com/document_detail/212906.html">Supported data assets</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the table belongs. You can call the <a href="~~DescribeDataAssets~~">DescribeDataAssets</a> operation to obtain the ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the table. Each sensitivity level ID corresponds to a sensitivity level name. Valid values:</para>
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
        /// <para>The ID of the sensitive data detection rule that the table hits. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to obtain the ID of the sensitive data detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333322</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region in which DSC is activated. For more information, see <a href="https://help.aliyun.com/document_detail/214257.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the industry-specific rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

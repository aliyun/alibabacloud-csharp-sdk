// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The version of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("APIVersion")]
        [Validation(Required=false)]
        public int? APIVersion { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketName</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataBaseName</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the data domain to which the data asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

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
        /// <para>The code of the file category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// <para>The type of the OSS file.</para>
        /// <remarks>
        /// <para>This parameter is valid only for querying data assets of the OSS type. You can call the <a href="https://help.aliyun.com/document_detail/2536492.html">DescribeDocTypes</a> operation to obtain the supported OSS file types. Use the value of the <c>Code</c> parameter in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public long? FileType { get; set; }

        /// <summary>
        /// <para>The keyword of the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8vb54hn2g9j191ddz</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
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
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>Specifies whether to query data at the Logstore level. The Simple Log Service data catalog has two layers. Set this parameter to 1 to query data at the Logstore level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogStoreFlag")]
        [Validation(Required=false)]
        public int? LogStoreFlag { get; set; }

        /// <summary>
        /// <para>The ID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The model ID of the industry-specific rule template. You can specify multiple IDs. Separate them with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2536491.html">DescribeTemplateAllRules</a> operation to obtain the model ID of the industry-specific rule template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The data labels to be queried. You can specify multiple data labels. Separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>101</b>: personal sensitive information</para>
        /// </description></item>
        /// <item><description><para><b>102</b>: personal information</para>
        /// </description></item>
        /// <item><description><para><b>107</b>: general information</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101,102</para>
        /// </summary>
        [NameInMap("ModelTagIds")]
        [Validation(Required=false)]
        public string ModelTagIds { get; set; }

        /// <summary>
        /// <para>The number of data assets to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the parent asset categories to be queried. You can specify multiple IDs. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>234,236,238</para>
        /// </summary>
        [NameInMap("ParentCategoryIds")]
        [Validation(Required=false)]
        public string ParentCategoryIds { get; set; }

        /// <summary>
        /// <para>The path of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>road</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>The IDs of the products to which the data assets to be queried belong. You can specify multiple product IDs. Separate them with commas (,). We recommend that you specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADB-MYSQL</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: TableStore</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: SELF_DB</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: PolarDB-X</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: PolarDB</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: ADB-PG</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: OceanBase</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: Redis</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to query data assets that belong to OSS, you cannot query data assets of other products. By default, data assets of products other than OSS are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The keyword of the data asset to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t_sddp_selfmysql_pers0</para>
        /// </summary>
        [NameInMap("QueryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The region in which the data asset catalog resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the sensitivity levels. You can specify multiple sensitivity level IDs. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RiskLevelIdList")]
        [Validation(Required=false)]
        public string RiskLevelIdList { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the data asset. You can specify multiple sensitivity levels. Separate them with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: S1, low sensitivity level</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2, medium sensitivity level</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3, high sensitivity level</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4, highest sensitivity level</para>
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
        /// <para>The IDs of the rules. You can specify multiple rule IDs. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// <para>The region where the data asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-beijing</b>: China (Beijing)</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou</b>: China (Zhangjiakou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-huhehaote</b>: China (Hohhot)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the industry-specific rule template.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a> operation to obtain the ID of the industry-specific rule template.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The identifier used for canary release evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("APIVersion")]
        [Validation(Required=false)]
        public int? APIVersion { get; set; }

        /// <summary>
        /// <para>The OSS bucket filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketName</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The page number in a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("CursorDirection")]
        [Validation(Required=false)]
        public string CursorDirection { get; set; }

        /// <summary>
        /// <para>The database name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataBaseName</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The data domain ID to which the data asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The facet dimension for associated filtering in the data catalog. Valid values: rule (category), task (task), instance (instance), and db (database). If this parameter is not specified or is empty, the original list and count query is performed (behavior unchanged). If a valid value is specified, the list query is skipped and only content.hitValues is returned. If an invalid value is specified, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("FacetType")]
        [Validation(Required=false)]
        public string FacetType { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The file category code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// <para>The OSS file type supported for detection.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2536492.html">DescribeDocTypes</a> to obtain the supported OSS file types. Use the Code field value from the response. This parameter is valid only for OSS asset queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public long? FileType { get; set; }

        /// <summary>
        /// <para>The keyword of the asset instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8vb54hn2g9j191ddz</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter revision items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsRevision")]
        [Validation(Required=false)]
        public int? IsRevision { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The SLS Logstore filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>The data catalog SLS page has two layers. This parameter indicates whether the query is at the Logstore dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogStoreFlag")]
        [Validation(Required=false)]
        public int? LogStoreFlag { get; set; }

        /// <summary>
        /// <para>The member accounts ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>The model IDs of the industry template, separated by commas.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2536491.html">DescribeTemplateAllRules</a> to obtain the industry template model IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The data tags to query, separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>101</b>: personal sensitive information.</description></item>
        /// <item><description><b>102</b>: personal information.</description></item>
        /// <item><description><b>107</b>: general information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101,102</para>
        /// </summary>
        [NameInMap("ModelTagIds")]
        [Validation(Required=false)]
        public string ModelTagIds { get; set; }

        /// <summary>
        /// <para>The maximum number of data asset instances to return per page in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of parent category IDs of the templates to query, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234,236,238</para>
        /// </summary>
        [NameInMap("ParentCategoryIds")]
        [Validation(Required=false)]
        public string ParentCategoryIds { get; set; }

        /// <summary>
        /// <para>The file path filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>road</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The product of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// <para>We recommend that you specify this parameter. The list of product IDs to query, separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: OSS</description></item>
        /// <item><description><b>3</b>: ADB-MYSQL</description></item>
        /// <item><description><b>4</b>: TableStore</description></item>
        /// <item><description><b>5</b>: RDS</description></item>
        /// <item><description><b>6</b>: SELF_DB</description></item>
        /// <item><description><b>7</b>: PolarDB-X</description></item>
        /// <item><description><b>8</b>: PolarDB</description></item>
        /// <item><description><b>9</b>: ADB-PG</description></item>
        /// <item><description><b>10</b>: OceanBase</description></item>
        /// <item><description><b>11</b>: MongoDB</description></item>
        /// <item><description><b>25</b>: Redis</description></item>
        /// </list>
        /// <remarks>
        /// <para>OSS is mutually exclusive with other products. If OSS is included in the query, no other products can be specified. By default, non-OSS products are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The SLS project filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The keyword of the data object to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t_sddp_selfmysql_pers0</para>
        /// </summary>
        [NameInMap("QueryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The region of the data catalog display page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The risk level filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RiskLevelIdList")]
        [Validation(Required=false)]
        public string RiskLevelIdList { get; set; }

        /// <summary>
        /// <para>The risk levels of the data assets to query. Separate multiple values with commas (,).</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: S1, low risk level.</description></item>
        /// <item><description><b>3</b>: S2, medium risk level.</description></item>
        /// <item><description><b>4</b>: S3, high risk level.</description></item>
        /// <item><description><b>5</b>: S4, highest risk level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// <para>The rule filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// <para>The region where the asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou).</description></item>
        /// <item><description><b>cn-huhehaote</b>: China (Hohhot).</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai).</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen).</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The task name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The task ID filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The industry template ID.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a> to obtain the industry template ID.</para>
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

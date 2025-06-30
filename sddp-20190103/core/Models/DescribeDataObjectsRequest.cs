// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsRequest : TeaModel {
        /// <summary>
        /// <para>Page number for the paginated query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>ID of the data domain to which the data asset belongs.</para>
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
        /// <para>File category code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// <para>OSS file types that are supported for recognition.</para>
        /// <remarks>
        /// <para>You can obtain the supported OSS file types by calling <a href="https://help.aliyun.com/document_detail/2536492.html">DescribeDocTypes</a>, using the Code field value from the response. This parameter is only valid for querying OSS-type assets.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public long? FileType { get; set; }

        /// <summary>
        /// <para>Keyword for the asset instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8vb54hn2g9j191ddz</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language type for request and response messages, default is <b>zh_cn</b>. Values:</para>
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
        /// <para>Member account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**********8103</para>
        /// </summary>
        [NameInMap("MemberAccount")]
        [Validation(Required=false)]
        public long? MemberAccount { get; set; }

        /// <summary>
        /// <para>Model IDs of the industry template, separated by commas.</para>
        /// <remarks>
        /// <para>You can obtain the industry template model identifier ID by calling <a href="https://help.aliyun.com/document_detail/2536491.html">DescribeTemplateAllRules</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>Data labels to be queried, separated by commas. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>101</b>: Personal Sensitive Information.</description></item>
        /// <item><description><b>102</b>: Personal Information.</description></item>
        /// <item><description><b>107</b>: General Information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101,102</para>
        /// </summary>
        [NameInMap("ModelTagIds")]
        [Validation(Required=false)]
        public string ModelTagIds { get; set; }

        /// <summary>
        /// <para>When performing a paginated query, set the maximum number of data asset instances to display per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of parent category IDs for the template to be queried, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234,236,238</para>
        /// </summary>
        [NameInMap("ParentCategoryIds")]
        [Validation(Required=false)]
        public string ParentCategoryIds { get; set; }

        /// <summary>
        /// <para>It is recommended to fill in the list of product IDs to be queried, separated by commas. Values:</para>
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
        /// <para>OSS is mutually exclusive with other products, meaning if OSS is included in the query, no other products can be listed; by default, non-OSS products are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1,5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>Keyword for the data object to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t_sddp_selfmysql_pers0</para>
        /// </summary>
        [NameInMap("QueryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>Specify the risk levels of the data assets to be queried, separated by commas if multiple.</para>
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
        /// <para>Region where the asset is located. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: North China 2 (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: North China 3 (Zhangjiakou).</description></item>
        /// <item><description><b>cn-huhehaote</b>: North China 5 (Hohhot).</description></item>
        /// <item><description><b>cn-hangzhou</b>: East China 1 (Hangzhou).</description></item>
        /// <item><description><b>cn-shanghai</b>: East China 2 (Shanghai).</description></item>
        /// <item><description><b>cn-shenzhen</b>: South China 1 (Shenzhen).</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong, China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>Industry template ID.</para>
        /// <remarks>
        /// <para>You can obtain the industry template identifier ID by calling <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a>.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectColumnDetailV2Request : TeaModel {
        /// <summary>
        /// <para>Settings for paging query. The page number of the current page. Default value: <b>1</b>.</para>
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
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The unique ID of the data object to query.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2399253.html">DescribeDataObjects</a> to obtain the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13456723343</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

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
        /// <para>Settings for paging query. The maximum number of data asset instances to display on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the data object belongs. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The industry template ID.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/2399253.html">DescribeDataObjects</a> to obtain the industry template ID.</para>
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

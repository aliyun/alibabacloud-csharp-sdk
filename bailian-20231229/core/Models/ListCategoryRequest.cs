// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListCategoryRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results to include only the category with this exact name. If this parameter is omitted, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>产品清单</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>The type of category to query. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>UNSTRUCTURED</c>: A category for unstructured data.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This API does not support querying structured data tables.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This API does not support querying structured data tables.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSTRUCTURED</para>
        /// </summary>
        [NameInMap("CategoryType")]
        [Validation(Required=false)]
        public string CategoryType { get; set; }

        /// <summary>
        /// <para>The ID of the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file_conn_xxxxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The maximum number of categories to return per page. The valid range is 1 to 200.</para>
        /// <para>Default value: 20. If this parameter is not specified or is set to a value less than 1, the default value is used. If a value greater than 200 is specified, the maximum value of 200 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. To retrieve the next page of results, pass the <c>NextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdH70eOCSCKtacdomNzak4U=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3xxxxxxxx</para>
        /// </summary>
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public string ParentCategoryId { get; set; }

    }

}

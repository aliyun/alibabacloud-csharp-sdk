// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListProductsRequest : TeaModel {
        /// <summary>
        /// <para>The product category IDs. This corresponds to the Categories property of the Product resource, where the members are category IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category-xxxxxxxx</para>
        /// </summary>
        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public string CategoryIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the API product. This corresponds to the Name property of the Product resource and matches the name field in the response list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weather-query-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The cursor token for querying the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the HiMarket developer portal where the API product is published. This corresponds to the PortalId property of the Product resource. This property is used only for list queries in the product resource definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>portal-xxxxxxxx</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

        /// <summary>
        /// <para>The status of the API product. This corresponds to the Status property of the Product resource and matches the status field in the response list. Valid values: Pending, Ready, Published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Published</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the API product. This corresponds to the Type property of the Product resource and matches the type field in the response list. The valid values are not declared in the API definition. Refer to the types displayed in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

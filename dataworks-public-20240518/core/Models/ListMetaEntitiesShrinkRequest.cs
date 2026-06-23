// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaEntitiesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Conditions for filtering entities by entity attributes. The <c>AND</c> operator is used between different filters, and the <c>OR</c> operator is used for multiple values within a single filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("AttributeFilters")]
        [Validation(Required=false)]
        public string AttributeFiltersShrink { get; set; }

        /// <summary>
        /// <para>Filters entities by comment. This is a token-based match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Conditions for filtering entities by custom attributes. The <c>AND</c> operator is used between different filters, and the <c>OR</c> operator is used for multiple values within a single filter. This parameter supports only <c>ENUM</c> custom attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CustomAttributeFilters")]
        [Validation(Required=false)]
        public string CustomAttributeFiltersShrink { get; set; }

        /// <summary>
        /// <para>The type of the entity to list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Filters entities by name. This is a containment match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_create_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that specifies the next page of results. To retrieve the first page, do not specify this parameter. To retrieve subsequent pages, set this parameter to the <c>NextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAaUpAxoCTD/+sbOf3f+uxvnYyILMeAjoTFQSX64R12GN</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: <c>Asc</c> and <c>Desc</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field to use for sorting the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}

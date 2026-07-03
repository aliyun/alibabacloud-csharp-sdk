// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If the response does not contain this parameter, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of normalization categories.</para>
        /// </summary>
        [NameInMap("NormalizationCategories")]
        [Validation(Required=false)]
        public List<ListNormalizationCategoriesResponseBodyNormalizationCategories> NormalizationCategories { get; set; }
        public class ListNormalizationCategoriesResponseBodyNormalizationCategories : TeaModel {
            /// <summary>
            /// <para>The ID of the normalization category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <para>The name of the normalization category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryName")]
            [Validation(Required=false)]
            public string NormalizationCategoryName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

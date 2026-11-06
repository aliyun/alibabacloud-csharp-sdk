// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListModelsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of models to return per page. Valid values: 1 to 100. Explicitly specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Set this parameter to <c>text</c> for text sessions. If you omit this parameter, all visible models are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The pagination token returned from the previous page. Omit this parameter for the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The legacy pagination parameter for compatibility. The page number starts from 1. Use MaxResults and NextToken instead. Do not mix the two sets of pagination parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The legacy pagination parameter for compatibility. The number of entries per page. Valid values: 1 to 100. Use MaxResults and NextToken instead. Do not mix the two sets of pagination parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}

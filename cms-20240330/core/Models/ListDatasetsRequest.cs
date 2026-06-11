// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_dataset</para>
        /// </summary>
        [NameInMap("datasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for retrieving the next page of results. A <c>nextToken</c> is included in the response when the result set is truncated. To continue pagination, provide the <c>nextToken</c> from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d9a48d977f45aa6fcf6981ed13b885b3fab0b124c12dcbbe70edce5d81ba****************</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

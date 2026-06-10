// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppTemplateDictsRequest : TeaModel {
        /// <summary>
        /// <para>Dictionary type</para>
        /// 
        /// <b>Example:</b>
        /// <para>product_version</para>
        /// </summary>
        [NameInMap("DictType")]
        [Validation(Required=false)]
        public string DictType { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Valid range: 10 to 100. Default Value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token indicating the start of the next query. This value is empty if there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFh3Xqm+JgZ/U9Jyb7wdVr9LWk80Tghn5UZjbcWEVEderBcbVF+Y6PS0i8PpCL4PQZ3e0C9oEH0Asd4tJEuGtkl2WuKdiWZpEwadNydQdJPFM=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

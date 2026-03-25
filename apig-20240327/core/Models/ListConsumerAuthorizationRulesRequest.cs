// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerAuthorizationRulesRequest : TeaModel {
        /// <summary>
        /// <para>API name for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3</para>
        /// </summary>
        [NameInMap("apiNameLike")]
        [Validation(Required=false)]
        public string ApiNameLike { get; set; }

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
        /// <para>The number of entries returned on each page. If you do not specify this parameter, the default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

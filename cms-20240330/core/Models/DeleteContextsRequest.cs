// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteContextsRequest : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of context IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mem_long_01,mem_long_02</para>
        /// </summary>
        [NameInMap("contextIds")]
        [Validation(Required=false)]
        public string ContextIds { get; set; }

        /// <summary>
        /// <para>The filter condition, specified as a JSON string in the query. The syntax is the same as the <c>filter</c> parameter of the <c>SearchContext</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;u-10001&quot;}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of bindings between datasets and OSS buckets.</para>
        /// </summary>
        [NameInMap("Bindings")]
        [Validation(Required=false)]
        public List<Binding> Bindings { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The pagination token that is used when the total number of bindings exceeds the value of MaxResults.</description></item>
        /// <item><description>Use this value as NextToken in the next request to obtain the remaining bindings.</description></item>
        /// <item><description>This parameter is returned only when not all bindings are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>immtest:dataset001:examplebucket01</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFDFD356-C928-4A36-951A-6EB5A592****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

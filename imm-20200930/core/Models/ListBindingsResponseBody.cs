// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBindingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The bindings between the dataset and OSS buckets.</para>
        /// </summary>
        [NameInMap("Bindings")]
        [Validation(Required=false)]
        public List<Binding> Bindings { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The pagination token that is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter.</description></item>
        /// <item><description>The next request returns remaining results starting from the position marked by the NextToken parameter value.</description></item>
        /// <item><description>This parameter has a non-empty value only when not all bindings are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>immtest:dataset001:examplebucket01</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFDFD356-C928-4A36-951A-6EB5A592****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

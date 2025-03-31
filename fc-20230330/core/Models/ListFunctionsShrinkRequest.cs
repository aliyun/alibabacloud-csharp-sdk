// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListFunctionsShrinkRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The version of Function Compute to which the functions belong. Valid values: v3 and v2. v3: only lists functions of Function Compute 3.0. v2: only lists functions of Function Compute 2.0. By default, this parameter is left empty and functions in both Function Compute 3.0 and Function Compute 2.0 are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("fcVersion")]
        [Validation(Required=false)]
        public string FcVersion { get; set; }

        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The number of functions to return. The minimum value is 1 and the maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNCNhYmM=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The prefix of the function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-func</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}

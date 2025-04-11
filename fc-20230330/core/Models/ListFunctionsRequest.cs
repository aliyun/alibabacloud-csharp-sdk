// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListFunctionsRequest : TeaModel {
        /// <summary>
        /// <para>The description of the functions to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The version of Function Compute to which the functions belong.</para>
        /// <list type="bullet">
        /// <item><description>v3: Only lists functions of Function Compute 3.0.</description></item>
        /// <item><description>v2: Only lists functions of Function Compute 2.0.</description></item>
        /// </list>
        /// <para>By default, this parameter is left empty and functions in both Function Compute 3.0 and Function Compute 2.0 are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("fcVersion")]
        [Validation(Required=false)]
        public string FcVersion { get; set; }

        /// <summary>
        /// <para>The GPU type of the functions to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc.gpu.tesla.1</para>
        /// </summary>
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

        /// <summary>
        /// <para>The runtime of the functions to retrieve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.10</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// <para>The tag of the functions to retrieve.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}

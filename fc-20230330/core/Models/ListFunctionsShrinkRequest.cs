// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListFunctionsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description used to filter functions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The version of the function. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>v3: Lists only Function Compute 3.0 functions.</description></item>
        /// <item><description>v2: Lists only Function Compute 2.0 functions.</description></item>
        /// </list>
        /// <para>Default value: empty. An empty value indicates that both Function Compute 3.0 and Function Compute 2.0 functions are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("fcVersion")]
        [Validation(Required=false)]
        public string FcVersion { get; set; }

        /// <summary>
        /// <para>The name of the function.</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The GPU type used to filter functions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc.gpu.tesla.1</para>
        /// </summary>
        [NameInMap("gpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The number of functions to return. Valid values: 1 to 100.</para>
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
        /// <para>The ID of the resource group.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The runtime used to filter functions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python3.10</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        /// <summary>
        /// <para>The tags used to filter functions.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}

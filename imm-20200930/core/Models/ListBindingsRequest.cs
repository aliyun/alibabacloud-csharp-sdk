// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBindingsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the dataset name, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The maximum number of bindings to return. Valid values: 0 to 200.</description></item>
        /// <item><description>If this parameter is not specified or is set to 0, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the binding task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imm</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The pagination token that is used when the total number of bindings exceeds the value of MaxResults.</description></item>
        /// <item><description>The list of bindings is returned in lexicographical order starting from the NextToken value.</description></item>
        /// <item><description>Leave this parameter empty when you call this operation for the first time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>immtest:dataset001:examplebucket01</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URI of the source OSS bucket, which is used to filter the bindings associated with the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example-bucket</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}

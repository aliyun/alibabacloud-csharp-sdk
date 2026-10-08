// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FuzzyQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the dataset name, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The maximum number of files to return. Valid values: 0 to 200.</para>
        /// <para>If you do not set this parameter or set it to 0, the default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used for pagination when the total number of files exceeds the value of MaxResults.</para>
        /// <para>The list of file information is returned in lexicographical order starting from NextToken.</para>
        /// <para>Set this parameter to empty when you call this operation for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order of the sort fields. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: Ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc: Descending order. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can separate multiple sort orders with commas (,), such as asc,desc.</description></item>
        /// <item><description>The number of sort orders cannot exceed the number of sort fields. That is, the number of elements in the Order parameter must be less than or equal to the number of elements in the Sort parameter. For example, if Sort is set to Size,Filename, Order can be set to desc or asc.</description></item>
        /// <item><description>If the number of sort orders is less than the number of sort fields, the default sort order for the unspecified fields is asc. For example, if Sort is set to Size,Filename and Order is set to asc, the default sort order for Filename is asc, which means ascending order.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asc,desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

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
        /// <para>The string used for the query. The string cannot exceed 1 MB in size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The list of fields by which to sort the results. For more information, see the <a href="https://help.aliyun.com/document_detail/2743991.html">list of supported fields and operators</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>You can separate multiple sort fields with commas (,), such as <c>Size,Filename</c>.</para>
        /// </description></item>
        /// <item><description><para>You can specify up to 5 sort fields.</para>
        /// </description></item>
        /// <item><description><para>The order of the sort fields determines the sorting priority.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Size,Filename</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies the fields to return. Only the values of the specified fields are returned instead of all existing metadata fields. You can use this parameter to reduce the size of the returned struct.</para>
        /// <para>If you do not specify this parameter or leave it empty, all fields are returned.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public string WithFieldsShrink { get; set; }

    }

}

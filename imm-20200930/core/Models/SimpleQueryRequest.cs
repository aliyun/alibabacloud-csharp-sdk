// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryRequest : TeaModel {
        /// <summary>
        /// <para>The list of aggregation field information.</para>
        /// <remarks>
        /// <para>Notice: When you use an aggregation query, only the aggregation results are returned, and the list of matched metadata is not returned.</notice></para>
        /// </remarks>
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public List<SimpleQueryRequestAggregations> Aggregations { get; set; }
        public class SimpleQueryRequestAggregations : TeaModel {
            /// <summary>
            /// <para>The name of the field. For more information about supported fields, see <a href="https://help.aliyun.com/document_detail/2743991.html">Supported fields and operators</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Size</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The operator for the aggregation field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

        }

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
        /// <list type="bullet">
        /// <item><description><para>When you perform a query for files without specifying the Aggregations parameter, this parameter specifies the maximum number of files to return. Valid values: 0 to 100.</para>
        /// </description></item>
        /// <item><description><para>When you specify the Aggregations parameter for aggregation statistics, this parameter specifies the maximum number of groups to return. Valid values: 0 to 2000.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter or set it to 0, the default value is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used for pagination when the total number of files exceeds the value of MaxResults.</para>
        /// <para>The list of files is returned in lexicographical order starting from NextToken.</para>
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
        /// <item><description><para>asc: ascending order</para>
        /// </description></item>
        /// <item><description><para>desc: descending order (default)</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can separate multiple sort orders with commas (,), for example, asc,desc.</description></item>
        /// <item><description>The number of sort orders cannot exceed the number of sort fields. That is, the number of elements in the Order parameter must be less than or equal to the number of elements in the Sort parameter. For example, if Sort is set to Size,Filename, Order can be set to &quot;asc,desc&quot;.</description></item>
        /// <item><description>If the number of sort orders is less than the number of sort fields, the default sort order for the unspecified fields is desc. For example, if Sort is set to Size,Filename and Order is set to asc, the default sort order for Filename is desc, which means descending order.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The simple query conditions. Click the link on the left to view details.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public SimpleQuery Query { get; set; }

        /// <summary>
        /// <para>The list of sort fields. For more information, see <a href="https://help.aliyun.com/document_detail/2743991.html">Supported fields and operators</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can separate multiple sort fields with commas (,), for example, Size,Filename.</description></item>
        /// <item><description>You can specify a maximum of 5 sort fields.</description></item>
        /// <item><description>The order of the sort fields determines the sorting priority.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Size,Filename</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies the specific fields to return instead of all existing metadata fields. This can be used to reduce the size of the returned struct.</para>
        /// <para>If you do not specify this parameter or leave it empty, all fields are returned.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public List<string> WithFields { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of matched records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The TotalHits field is not returned.</description></item>
        /// <item><description>false: The TotalHits field is returned.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("WithoutTotalHits")]
        [Validation(Required=false)]
        public bool? WithoutTotalHits { get; set; }

    }

}

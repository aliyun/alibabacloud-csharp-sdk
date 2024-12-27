// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SimpleQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The aggregations.</para>
        /// <remarks>
        /// <para> If you perform an aggregate query, the aggregation returned in the response contains only statistical results, not the actual metadata.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Aggregations")]
        [Validation(Required=false)]
        public string AggregationsShrink { get; set; }

        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
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
        /// <item><description>If the Aggregations parameter is not specified, this parameter specifies the maximum number of files that can be returned. Valid values: 1 to 100.</description></item>
        /// <item><description>If the Aggregations parameter is specified, this parameter specifies the maximum number of aggregation groups that can be returned. Valid values: 0 to 2000.</description></item>
        /// <item><description>If you do not specify this parameter or set the parameter to 0, the default value of 100 is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter.</para>
        /// <para>The next call to the operation returns results lexicographically after the NextToken parameter value.</para>
        /// <para>You do not need to specify this parameter in your initial request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: sorts the results in ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc: sorts the results in descending order. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>You can specify multiple sort orders that are separated by commas. Example: asc,desc.</para>
        /// </description></item>
        /// <item><description><para>The number of elements in the Order parameter must be less than or equal to the number of elements in the Sort parameter. For example, if the value of the Sort parameter is Size,Filename, you can set the Order parameter to desc,asc.</para>
        /// </description></item>
        /// <item><description><para>If the number of sort orders is less than the number of sort fields, the sort fields for which no sorting orders are explicitly specified use the asc order by default. For example, if you set Sort to Size,Filename and Order to asc, the Filename field defaults to the value of asc.</para>
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
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string QueryShrink { get; set; }

        /// <summary>
        /// <para>The sort fields. For more information, see <a href="https://help.aliyun.com/document_detail/2743991.html">Supported fields and operators</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify multiple sort fields, separate them with commas (,), as in Size,Filename.</para>
        /// </description></item>
        /// <item><description><para>You can specify up to five sort fields.</para>
        /// </description></item>
        /// <item><description><para>The order of the sort fields determines their precedence in the sorting process.</para>
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
        /// <para>The fields that you want to include in the response. You can use this parameter to reduce the size of the response.</para>
        /// <para>If you do not specify this parameter or leave this parameter empty, the operation returns all metadata fields.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public string WithFieldsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of hits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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

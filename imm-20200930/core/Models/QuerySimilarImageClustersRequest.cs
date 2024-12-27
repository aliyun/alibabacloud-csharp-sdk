// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QuerySimilarImageClustersRequest : TeaModel {
        /// <summary>
        /// <para>The custom tags, which are used to filter tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;val&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. For more information, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Value range: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <para>If the total number of clusters is greater than the value of MaxResults, you must specify this parameter. The next call to the operation returns results lexicographically after the NextToken parameter value.</para>
        /// <remarks>
        /// <para> The first time you call this operation in a query, set this parameter to null.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KClVwZGF0ZVRpbWUQARgBIs8ECgkAAJLUwUCAQ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order.</description></item>
        /// <item><description>desc: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The sorting field.</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: the time when the clusters were created.</description></item>
        /// <item><description>UpdateTime: the time when the clusters were updated. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}

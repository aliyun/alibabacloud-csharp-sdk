// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryStoriesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The creation time range of the story.</para>
        /// </summary>
        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public string CreateTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The custom label key-value pairs. Only stories that match the specified label pairs are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key=value</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the name, see <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The IDs of the figure clusters.</para>
        /// </summary>
        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public string FigureClusterIdsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single call. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. If this parameter is left empty, the query starts from the beginning. To query the next page, set this parameter to the NextToken value returned in the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpw****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the story object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: Ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime: Sorts by story creation time.</para>
        /// </description></item>
        /// <item><description><para>StoryName: Sorts by story name.</para>
        /// </description></item>
        /// <item><description><para>StoryStartTime: Sorts by story start time.</para>
        /// </description></item>
        /// <item><description><para>StoryEndTime: Sorts by story end time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The end time range of the photos or videos in the story.</para>
        /// </summary>
        [NameInMap("StoryEndTimeRange")]
        [Validation(Required=false)]
        public string StoryEndTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The name of the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <para>The start time range of the photos or videos in the story.</para>
        /// </summary>
        [NameInMap("StoryStartTimeRange")]
        [Validation(Required=false)]
        public string StoryStartTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The subtype of the story. For valid values, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SeasonHighlights</para>
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>The type of the story. For valid values, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimeMemory</para>
        /// </summary>
        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return empty stories. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns empty stories. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>false: Does not return empty stories.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithEmptyStories")]
        [Validation(Required=false)]
        public bool? WithEmptyStories { get; set; }

    }

}

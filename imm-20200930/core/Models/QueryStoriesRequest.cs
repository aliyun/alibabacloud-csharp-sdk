// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryStoriesRequest : TeaModel {
        /// <summary>
        /// <para>The time range in which stories were created.</para>
        /// </summary>
        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public TimeRange CreateTimeRange { get; set; }

        /// <summary>
        /// <para>The custom labels in key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key=value</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

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
        /// <para>The IDs of the face clusters.</para>
        /// </summary>
        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public List<string> FigureClusterIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If you do not specify this token in the next request, results are returned from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpw****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: in ascending order.</description></item>
        /// <item><description>desc: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
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
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: sorts by story creation time.</description></item>
        /// <item><description>StoryName: sorts by story name.</description></item>
        /// <item><description>StoryStartTime: sorts by story start time.</description></item>
        /// <item><description>StoryEndTime: sorts by story end time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The time range for the creation time of the last photo or video in the story.</para>
        /// </summary>
        [NameInMap("StoryEndTimeRange")]
        [Validation(Required=false)]
        public TimeRange StoryEndTimeRange { get; set; }

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
        /// <para>The time range for the creation time of the first photo or video in the story.</para>
        /// </summary>
        [NameInMap("StoryStartTimeRange")]
        [Validation(Required=false)]
        public TimeRange StoryStartTimeRange { get; set; }

        /// <summary>
        /// <para>The subtype of the story. For a list of valid values, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SeasonHighlights</para>
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>The type of the story. For a list of valid values, see <a href="https://help.aliyun.com/document_detail/2743998.html">Story types and subtypes</a>.</para>
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
        /// <item><description>true (The default value)</description></item>
        /// <item><description>false</description></item>
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

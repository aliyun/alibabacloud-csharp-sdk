// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetFileMetasStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The metadata field used for statistical aggregation. The value is not case-sensitive. If you do not specify this parameter, the total number of file metadata entries in the dataset is returned, and the aggregation list is not returned.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>filedir: The directory path of the file.</para>
        /// </description></item>
        /// <item><description><para>filetype: The file type.</para>
        /// </description></item>
        /// <item><description><para>tags.user: Custom user tags.</para>
        /// </description></item>
        /// <item><description><para>tags.user-delete-ai-tags: Algorithm tags deleted by the user.</para>
        /// </description></item>
        /// <item><description><para>tags.ai: Algorithm tags that are aggregated from all labeling tasks.</para>
        /// </description></item>
        /// <item><description><para>tags.all: A combination of algorithm tags and custom user tags, excluding any algorithm tags deleted by the user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>filedir</para>
        /// </summary>
        [NameInMap("AggregateBy")]
        [Validation(Required=false)]
        public string AggregateBy { get; set; }

        /// <summary>
        /// <para>The name of the dataset version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for each query that uses the NextToken parameter. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The workspace ID. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145883</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

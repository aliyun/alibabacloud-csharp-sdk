// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetFileMetasStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Aggregates statistics based on the specified metadata field. The value is not case-sensitive. If not specified, the total number of dataset file metadata will be returned, instead of aggregation lists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>filedir: the directory path of the file</description></item>
        /// <item><description>file_type: the file type</description></item>
        /// <item><description>tags.user: user-defined tag</description></item>
        /// <item><description>tags.user-delete-ai-tags: algorithm tags deleted by the user</description></item>
        /// <item><description>tags.ai: algorithm tags (aggregated by all tagging tasks)</description></item>
        /// <item><description>tags.all: algorithm tags and user-defined tags (excluding alogorithm tags deleted by the user)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>filedir</para>
        /// </summary>
        [NameInMap("AggregateBy")]
        [Validation(Required=false)]
        public string AggregateBy { get; set; }

        /// <summary>
        /// <para>The dataset version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The maximum number of results to be returned from a single query when the NextToken parameter is used in the query. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
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

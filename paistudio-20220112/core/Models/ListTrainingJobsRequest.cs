// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_train</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The algorithm provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <para>The end time of the creation time range used to query jobs. Default value: the current time. The time is in ISO 8601 format and the UTC time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-27T02:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the algorithm is temporary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("IsTempAlgo")]
        [Validation(Required=false)]
        public bool? IsTempAlgo { get; set; }

        /// <summary>
        /// <para>The labels of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;project&quot;: &quot;sd-s3&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: Ascending order.</description></item>
        /// <item><description>DESC: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number for the paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModifiedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time of the creation time range used to query jobs. Default value: 7 days ago. The time is in ISO 8601 format and the UTC time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-22T01:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trains930928remn</para>
        /// </summary>
        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// <para>The name of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>large_language_model_training</para>
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

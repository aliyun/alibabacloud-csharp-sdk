// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("EndFileUpdateTime")]
        [Validation(Required=false)]
        public string EndFileUpdateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("EndTagUpdateTime")]
        [Validation(Required=false)]
        public string EndTagUpdateTime { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90a6ee35-****-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        [NameInMap("QueryFileDir")]
        [Validation(Required=false)]
        public string QueryFileDir { get; set; }

        [NameInMap("QueryFileName")]
        [Validation(Required=false)]
        public string QueryFileName { get; set; }

        [NameInMap("QueryFileTypeIncludeAny")]
        [Validation(Required=false)]
        public string QueryFileTypeIncludeAnyShrink { get; set; }

        [NameInMap("QueryImage")]
        [Validation(Required=false)]
        public string QueryImage { get; set; }

        [NameInMap("QueryTagsExclude")]
        [Validation(Required=false)]
        public string QueryTagsExcludeShrink { get; set; }

        [NameInMap("QueryTagsIncludeAll")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAllShrink { get; set; }

        [NameInMap("QueryTagsIncludeAny")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAnyShrink { get; set; }

        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TAG</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FileCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("StartFileUpdateTime")]
        [Validation(Required=false)]
        public string StartFileUpdateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("StartTagUpdateTime")]
        [Validation(Required=false)]
        public string StartTagUpdateTime { get; set; }

        [NameInMap("ThumbnailMode")]
        [Validation(Required=false)]
        public string ThumbnailMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105173</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

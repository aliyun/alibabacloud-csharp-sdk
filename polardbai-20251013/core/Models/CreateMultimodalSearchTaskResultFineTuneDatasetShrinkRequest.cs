// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class CreateMultimodalSearchTaskResultFineTuneDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze454l20me07****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>多模态数据集</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dataset-1</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("ResultIndex")]
        [Validation(Required=false)]
        public string ResultIndexShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;raw&quot;, &quot;rerank&quot;]</para>
        /// </summary>
        [NameInMap("ResultMode")]
        [Validation(Required=false)]
        public string ResultMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>476751c5-*****-39f6aff1df96</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitEnterpriseVocAnalysisTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ContentTags")]
        [Validation(Required=false)]
        public string ContentTagsShrink { get; set; }

        [NameInMap("Contents")]
        [Validation(Required=false)]
        public string ContentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://default/bucket-name/materialDocument/tenant_agent/fileName</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("FilterTags")]
        [Validation(Required=false)]
        public string FilterTagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>shortContent</para>
        /// </summary>
        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("PositiveSample")]
        [Validation(Required=false)]
        public string PositiveSample { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://default/bucket-name/path/xxx.xlsx</para>
        /// </summary>
        [NameInMap("PositiveSampleFileKey")]
        [Validation(Required=false)]
        public string PositiveSampleFileKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lightAppSass</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

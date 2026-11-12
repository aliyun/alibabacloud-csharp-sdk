// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDataProcessJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to fetch the image summary or video synopsis. When Settings is true, CaptioningPrompt must be provided.</para>
        /// </summary>
        [NameInMap("Captioning")]
        [Validation(Required=false)]
        public bool? Captioning { get; set; }

        /// <summary>
        /// <para>The prompt used for extracting captions. This parameter takes effect only when Captioning is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Summarize the image content</para>
        /// </summary>
        [NameInMap("CaptioningPrompt")]
        [Validation(Required=false)]
        public string CaptioningPrompt { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert the content into vectors.</para>
        /// </summary>
        [NameInMap("Embedding")]
        [Validation(Required=false)]
        public bool? Embedding { get; set; }

        /// <summary>
        /// <para>The output dimension of the vector. Valid values when Embedding is set to true: 512, 768, 1024, and 2048.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("EmbeddingDimension")]
        [Validation(Required=false)]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The JSON string for additional template configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ETL_TEMPLATE_STR&quot;:&quot;config&quot;}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The name of the task template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The templatetype of the node template. Valid value: image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

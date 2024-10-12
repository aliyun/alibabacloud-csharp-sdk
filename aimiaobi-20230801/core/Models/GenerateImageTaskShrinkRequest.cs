// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateImageTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
        /// </summary>
        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ParagraphList")]
        [Validation(Required=false)]
        public string ParagraphListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024*1024</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <auto>
        /// </summary>
        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}

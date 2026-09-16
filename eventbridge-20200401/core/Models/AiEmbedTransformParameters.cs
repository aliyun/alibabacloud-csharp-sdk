// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiEmbedTransformParameters : TeaModel {
        /// <summary>
        /// <para>The vector dimensions. Must be a dimension supported by the selected model. If not specified, the default value of the model is used (1024 for most models, 1536 for v1/v2/async).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The embedding model. Default value: text-embedding-v4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The field name in the CloudEvent to which the output is attached. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>embedding</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

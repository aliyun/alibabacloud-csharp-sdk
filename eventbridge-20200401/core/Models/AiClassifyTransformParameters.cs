// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiClassifyTransformParameters : TeaModel {
        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The classification constraints provided to the model, such as priority rules or how to categorize uncertain cases. If left empty, classification is performed based on Labels only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Classify as bug when crash or exception is mentioned, classify as other when uncertain</para>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The candidate classification labels. The classification result must fall within this list. Specify at least two labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;bug&quot;,&quot;feature&quot;,&quot;question&quot;,&quot;other&quot;]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// <para>The output mode. Valid values: single: single-label. multi: multi-label. Default value: single.</para>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("OutputMode")]
        [Validation(Required=false)]
        public string OutputMode { get; set; }

        /// <summary>
        /// <para>The field name in the CloudEvent to which the output is attached. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>classify_result</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiSentimentAnalysisTransformParameters : TeaModel {
        /// <summary>
        /// <para>Performs emotion analysis on each specified aspect separately. If left empty, performs overall emotion analysis on the entire text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;price&quot;,&quot;logistics&quot;,&quot;customer service&quot;]</para>
        /// </summary>
        [NameInMap("Aspects")]
        [Validation(Required=false)]
        public List<string> Aspects { get; set; }

        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The field name attached to the CloudEvent for output. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sentiment</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

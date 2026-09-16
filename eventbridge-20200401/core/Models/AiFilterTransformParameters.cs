// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiFilterTransformParameters : TeaModel {
        /// <summary>
        /// <para>The retention condition described in natural language. The model uses this condition to determine whether an event matches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Retain only content related to user complaints or refunds</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The behavior when a mismatch occurs. Valid values: discard (default): discards the event. forward: forwards the event as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>discard</para>
        /// </summary>
        [NameInMap("OnMismatch")]
        [Validation(Required=false)]
        public string OnMismatch { get; set; }

        /// <summary>
        /// <para>The field name in the CloudEvent to which the output is attached. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filter_result</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

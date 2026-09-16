// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiRedactTransformParameters : TeaModel {
        /// <summary>
        /// <para>The entity types to identify and mask in the text, such as phone numbers, ID card numbers, and email addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;PHONE&quot;,&quot;ID_CARD&quot;,&quot;EMAIL&quot;]</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The mask character used in mask mode. Default value: *.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("MaskChar")]
        [Validation(Required=false)]
        public string MaskChar { get; set; }

        /// <summary>
        /// <para>The masking mode. Valid values: mask, replace, and remove.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mask</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The field name appended to the CloudEvent for output. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redact_result</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

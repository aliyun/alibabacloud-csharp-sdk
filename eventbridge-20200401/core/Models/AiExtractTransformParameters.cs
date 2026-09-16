// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiExtractTransformParameters : TeaModel {
        /// <summary>
        /// <para>The JSON Schema of the extraction results. Pass a serialized JSON object string or JSON Schema text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;orderId&quot;:{&quot;type&quot;:&quot;string&quot;},&quot;amount&quot;:{&quot;type&quot;:&quot;number&quot;}}}</para>
        /// </summary>
        [NameInMap("ExtractSchema")]
        [Validation(Required=false)]
        public string ExtractSchema { get; set; }

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
        /// <para>extract_result</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

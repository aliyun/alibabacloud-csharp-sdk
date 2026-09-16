// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiPrepSearchTransformParameters : TeaModel {
        /// <summary>
        /// <para>The input text field.</para>
        /// </summary>
        [NameInMap("InputField")]
        [Validation(Required=false)]
        public AiTransformField InputField { get; set; }

        /// <summary>
        /// <para>The maximum number of chunks. Valid values: 1 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxChunkSize")]
        [Validation(Required=false)]
        public int? MaxChunkSize { get; set; }

        /// <summary>
        /// <para>The field name attached to the CloudEvent for output. Default value: transform0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chunks</para>
        /// </summary>
        [NameInMap("StepName")]
        [Validation(Required=false)]
        public string StepName { get; set; }

    }

}

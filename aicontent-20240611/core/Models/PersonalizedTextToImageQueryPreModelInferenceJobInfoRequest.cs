// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>girl-xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("inferenceJobId")]
        [Validation(Required=false)]
        public string InferenceJobId { get; set; }

    }

}

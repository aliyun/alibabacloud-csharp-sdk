// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class GetDistillationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The distillation template details.</para>
        /// </summary>
        [NameInMap("DistillationTemplate")]
        [Validation(Required=false)]
        public DistillationTemplate DistillationTemplate { get; set; }

        /// <summary>
        /// <para><b>Request ID</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

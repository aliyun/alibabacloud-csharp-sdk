// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDetectionRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dr-ha1i09ob3zmqrs85****</para>
        /// </summary>
        [NameInMap("DetectionRuleId")]
        [Validation(Required=false)]
        public string DetectionRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5CC09D0C-1CD7-54BD-A853-DCB2D945****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

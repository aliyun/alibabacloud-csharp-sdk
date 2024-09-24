// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackDriftResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the drift detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7044f0d-6f2e-4128-a307-4524ef88****</para>
        /// </summary>
        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

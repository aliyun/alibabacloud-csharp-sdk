// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateFaultInjectionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;FaultType&quot;: &quot;DiskFillTask&quot;,
        ///   &quot;FaultArgs&quot;: {
        ///     &quot;FaultAction&quot;: &quot;fill&quot;,
        ///     &quot;Percent&quot;: 80
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("FaultArgs")]
        [Validation(Required=false)]
        public object FaultArgs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CpuFullloadTask</para>
        /// </summary>
        [NameInMap("FaultType")]
        [Validation(Required=false)]
        public string FaultType { get; set; }

    }

}

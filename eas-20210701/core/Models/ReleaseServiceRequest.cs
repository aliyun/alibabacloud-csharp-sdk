// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ReleaseServiceRequest : TeaModel {
        /// <summary>
        /// <para>The traffic state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standalone: independent traffic.</description></item>
        /// <item><description>grouping: grouped traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>grouping</para>
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        /// <summary>
        /// <para>The weight of the service. Valid values: [-1, 1000].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}

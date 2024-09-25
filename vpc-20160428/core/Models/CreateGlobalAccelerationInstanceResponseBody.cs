// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateGlobalAccelerationInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1fi6sq7npnicmjj****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>The public IP address of the GA instance.</para>
        /// <para>If <b>BandwidthType</b> is set to <b>Sharing</b>, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.xx.xx.78</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

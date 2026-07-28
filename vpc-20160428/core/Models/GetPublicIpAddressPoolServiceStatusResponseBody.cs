// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetPublicIpAddressPoolServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the IP address pool feature is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: activated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not activated. You can call the OpenPublicIpAddressPoolService operation to activate the IP address pool feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-06F82A1B457</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

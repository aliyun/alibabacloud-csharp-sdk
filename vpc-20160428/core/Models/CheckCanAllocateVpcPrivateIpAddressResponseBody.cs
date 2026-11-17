// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CheckCanAllocateVpcPrivateIpAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the queried private IP address is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The private IP address is not in use in the specified vSwitch and is available.</description></item>
        /// <item><description><b>false</b>: The private IP address is already in use in the specified vSwitch and is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanAllocate")]
        [Validation(Required=false)]
        public bool? CanAllocate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93360B0-2969-40BF-8542-EBB34FD358AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

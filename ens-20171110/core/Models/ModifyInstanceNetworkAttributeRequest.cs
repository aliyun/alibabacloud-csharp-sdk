// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceNetworkAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ENS instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5myukg7hnpbto7m024002****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new private IP address.
        /// Default value: If this parameter is not specified, an IP address is randomly assigned from the CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description>If the specified ID is the current vSwitch of the instance, the vSwitch of the instance remains unchanged.</description></item>
        /// <item><description>If the specified ID is a new vSwitch, the new and old vSwitches must belong to the same edge zone.</description></item>
        /// <item><description>If this parameter is not specified, a value is randomly assigned from the CIDR block of the original vSwitch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5rllcjb3ol6duzjdnbm1o****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}

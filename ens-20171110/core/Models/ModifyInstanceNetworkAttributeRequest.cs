// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceNetworkAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ENS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5myukg7hnpbto7m024002****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new private IP address of the ECS instance. By default, if this parameter is empty, a private IP address is randomly assigned from the CIDR block of the specified vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to the ID of the current vSwitch, the vSwitch of the ECS instance remains unchanged.</description></item>
        /// <item><description>The input ID is a new vSwitch, and the new and old vSwitches must belong to the same node.</description></item>
        /// <item><description>By default, if this parameter is not specified, a private IP address is randomly assigned from within the CIDR block of the specified vSwitch.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesStatusRequest : TeaModel {
        /// <summary>
        /// <para>The action to perform on the endpoint device status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Locked</b>: Lock the device.</para>
        /// </description></item>
        /// <item><description><para><b>Lost</b>: Report the device as lost.</para>
        /// </description></item>
        /// <item><description><para><b>Unbound</b>: Detach the device. You can detach only offline or long-term offline devices.</para>
        /// </description></item>
        /// <item><description><para><b>Unlocked</b>: Unlock the device. You can unlock only locked devices.</para>
        /// </description></item>
        /// <item><description><para><b>Found</b>: Mark the device as found. You can mark only lost devices as found.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unbound</para>
        /// </summary>
        [NameInMap("DeviceAction")]
        [Validation(Required=false)]
        public string DeviceAction { get; set; }

        /// <summary>
        /// <para>A list of endpoint device IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

    }

}

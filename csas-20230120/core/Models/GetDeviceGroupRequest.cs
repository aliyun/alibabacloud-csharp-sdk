// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetDeviceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The device label ID. You can obtain this value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListDeviceGroups~~">ListDeviceGroups</a>: Lists device labels.</description></item>
        /// <item><description><a href="~~CreateDeviceGroup~~">CreateDeviceGroup</a>: Creates a device label.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device-group-5191cf830a5e****</para>
        /// </summary>
        [NameInMap("DeviceGroupId")]
        [Validation(Required=false)]
        public string DeviceGroupId { get; set; }

    }

}

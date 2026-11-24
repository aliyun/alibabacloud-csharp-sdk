// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddDeviceGroupMatchDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the terminal devices to add. You must specify at least one ID, and the IDs must be unique.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DevTags")]
        [Validation(Required=false)]
        public List<string> DevTags { get; set; }

        /// <summary>
        /// <para>The ID of the device tag.</para>
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

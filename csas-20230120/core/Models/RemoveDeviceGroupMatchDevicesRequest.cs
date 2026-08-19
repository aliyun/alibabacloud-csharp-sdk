// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RemoveDeviceGroupMatchDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The collection of terminal device IDs to be removed. At least one ID must be specified, and duplicate values are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DevTags")]
        [Validation(Required=false)]
        public List<string> DevTags { get; set; }

        /// <summary>
        /// <para>The device label ID.</para>
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

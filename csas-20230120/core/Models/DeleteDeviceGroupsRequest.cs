// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteDeviceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The collection of instance tag IDs to delete. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("DeviceGroupIds")]
        [Validation(Required=false)]
        public List<string> DeviceGroupIds { get; set; }

    }

}

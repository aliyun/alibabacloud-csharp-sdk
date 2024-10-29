// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unbound</para>
        /// </summary>
        [NameInMap("DeviceAction")]
        [Validation(Required=false)]
        public string DeviceAction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

    }

}

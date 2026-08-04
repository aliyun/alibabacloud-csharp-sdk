// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesSharingStatusRequest : TeaModel {
        /// <summary>
        /// <para>Collection of device IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

        /// <summary>
        /// <para>Indicates whether device sharing is enabled. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable sharing.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable sharing.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharingStatus")]
        [Validation(Required=false)]
        public bool? SharingStatus { get; set; }

    }

}

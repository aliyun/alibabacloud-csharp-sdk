// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateExcessiveDeviceRegistrationApplicationsStatusRequest : TeaModel {
        /// <summary>
        /// <para>List of IDs for device registration applications that exceed your quota.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>Status of the device registration application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Approved</b>: Approve the application. You can approve only applications with a Pending status.</para>
        /// </description></item>
        /// <item><description><para><b>Rejected</b>: Reject the application. You can reject only applications with a Pending status.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

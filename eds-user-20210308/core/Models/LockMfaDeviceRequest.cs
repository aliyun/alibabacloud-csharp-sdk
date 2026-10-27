// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockMfaDeviceRequest : TeaModel {
        /// <summary>
        /// <para>The address of the AD office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upower.vip</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The serial number of the bound virtual MFA device. The user must first complete the MFA binding in the client authentication flow. You can call <a href="~~DescribeMfaDevices~~">DescribeMfaDevices</a> to query the serial number of the bound device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc856334-446b-4035-bfbc-18af261e****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}

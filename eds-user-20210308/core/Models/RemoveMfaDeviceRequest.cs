// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveMfaDeviceRequest : TeaModel {
        /// <summary>
        /// <para>The address of the AD office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alpha.lftltd.net</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <para>The serial number of the virtual MFA device. You can call the <a href="~~DescribeMfaDevices~~">DescribeMfaDevices</a> operation to get this information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc856334-446b-4035-bfbc-18af261e****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}

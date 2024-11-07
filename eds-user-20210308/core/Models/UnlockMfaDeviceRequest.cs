// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockMfaDeviceRequest : TeaModel {
        /// <summary>
        /// <para>The domain of the Active Directory (AD) workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>welab.co.id</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <para>The serial number of the virtual MFA device. The serial number is unique for each device.</para>
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

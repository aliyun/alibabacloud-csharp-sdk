// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ActiveDeviceCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The serial number of the device certificate that you reactivated. The serial number is the unique identifier of a device certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356217374433******</para>
        /// </summary>
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

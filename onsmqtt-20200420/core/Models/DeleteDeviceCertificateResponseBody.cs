// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DeleteDeviceCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The SN of the deleted device certificate. The SN uniquely identifies a device certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356217374433******</para>
        /// </summary>
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// <para>The common parameter. Each request has a unique ID that can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

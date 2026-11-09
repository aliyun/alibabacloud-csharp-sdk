// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DeleteDeviceCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The serial number of the CA certificate to which the device certificate belongs. The serial number uniquely identifies a CA certificate. The CA certificate is used to verify the validity of the device certificate. The value can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>007269004887******</para>
        /// </summary>
        [NameInMap("CaSn")]
        [Validation(Required=false)]
        public string CaSn { get; set; }

        /// <summary>
        /// <para>The serial number (SN) of the device certificate to delete. The SN uniquely identifies a device certificate. The value can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356217374433****</para>
        /// </summary>
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the device certificate is bound, which is the instance ID of ApsaraMQ for MQTT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2d******</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

    }

}

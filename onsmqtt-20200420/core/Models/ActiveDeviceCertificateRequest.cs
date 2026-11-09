// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ActiveDeviceCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The SN of the CA certificate to which the device certificate to be activated belongs. The SN uniquely identifies a CA certificate.
        /// Valid values: up to 128 bytes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>007269004887******</para>
        /// </summary>
        [NameInMap("CaSn")]
        [Validation(Required=false)]
        public string CaSn { get; set; }

        /// <summary>
        /// <para>The serial number (SN) of the device certificate to be activated. The SN uniquely identifies a device certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356217374433******</para>
        /// </summary>
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// <para>The instance ID to which the device certificate is attached, which is the instance ID of MSMQ for MQTT.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RegisterCaCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The content of the CA certificate that you want to register with an ApsaraMQ for MQTT broker.</para>
        /// <remarks>
        /// <para>In the example, \n indicates a line feed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\nMIIDuzCCAqdGVzdC5jbi1xaW5n******\n-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CaContent")]
        [Validation(Required=false)]
        public string CaContent { get; set; }

        /// <summary>
        /// <para>The name of the CA certificate that you want to register with an ApsaraMQ for MQTT broker.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt_ca</para>
        /// </summary>
        [NameInMap("CaName")]
        [Validation(Required=false)]
        public string CaName { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance to which you want to bind the CA certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2d******</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// <para>The content of the validation certificate issued by the CA certificate that you want to register with an ApsaraMQ for MQTT broker. The validation certificate must be used together with the registration code of the CA certificate to verify the private key of the CA certificate.</para>
        /// <remarks>
        /// <para>In the example, \n indicates a line feed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\nMIID/DCCAu+Y5sRMpp9tnd+4s******\n-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("VerificationContent")]
        [Validation(Required=false)]
        public string VerificationContent { get; set; }

    }

}

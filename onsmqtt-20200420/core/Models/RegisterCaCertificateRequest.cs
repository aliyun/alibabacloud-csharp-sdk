// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RegisterCaCertificateRequest : TeaModel {
        /// <summary>
        /// <para>Content of the CA certificate to be registered.</para>
        /// <remarks>
        /// <para>Note that \n in the example represents a new line.</para>
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
        /// <para>Name of the CA certificate to be registered</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt_ca</para>
        /// </summary>
        [NameInMap("CaName")]
        [Validation(Required=false)]
        public string CaName { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Message Queue MQTT version. When registering a CA certificate, you need to specify an instance to bind with.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2d******</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// <para>Content of the verification certificate for the CA certificate to be registered. It is used together with the registration code of the CA certificate to verify that the user possesses the private key of this CA certificate. </para>
        /// <remarks>
        /// <para> in the example represents a line break.</para>
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

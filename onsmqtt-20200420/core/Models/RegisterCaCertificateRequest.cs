// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RegisterCaCertificateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\nMIIDuzCCAqdGVzdC5jbi1xaW5n******\n-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CaContent")]
        [Validation(Required=false)]
        public string CaContent { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the RegisterCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt_ca</para>
        /// </summary>
        [NameInMap("CaName")]
        [Validation(Required=false)]
        public string CaName { get; set; }

        /// <summary>
        /// <para>RegisterCaCertificate</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2d******</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
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

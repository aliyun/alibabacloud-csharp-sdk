// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class SetSniConfigRequest : TeaModel {
        /// <summary>
        /// <para>The default certificate. If the domain name that you access cannot match the certificates of the broker, the default certificate is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1533xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("DefaultCertificate")]
        [Validation(Required=false)]
        public string DefaultCertificate { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-cn-5yd3xxx</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// <para>The Server Name Indication (SNI) configuration. This parameter is used to map domain names and certificates. Format: Domain name#Certificate ID#Password (if available);Domain name#Certificate ID#Password (if available).</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.mqtt.aliyuncs.com#15xxxxx-cn-hangzhou;mqtt-test.mqtt.aliyuncs.com#15xxxx9-cn-hangzhou</para>
        /// </summary>
        [NameInMap("SniConfig")]
        [Validation(Required=false)]
        public string SniConfig { get; set; }

    }

}

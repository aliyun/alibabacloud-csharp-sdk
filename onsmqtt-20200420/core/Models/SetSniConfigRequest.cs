// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class SetSniConfigRequest : TeaModel {
        /// <summary>
        /// <para>The default certificate. This certificate is returned if no matching domain name is found in the server certificate list.</para>
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
        /// <para>The Server Name Indication (SNI) configuration that maps domain names to certificates. Format: DomainName#CertificateID#Password(if any);DomainName#CertificateID#Password(if any)</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.mqtt.aliyuncs.com#15xxxxx-cn-hangzhou;mqtt-test.mqtt.aliyuncs.com#15xxxx9-cn-hangzhou</para>
        /// </summary>
        [NameInMap("SniConfig")]
        [Validation(Required=false)]
        public string SniConfig { get; set; }

    }

}

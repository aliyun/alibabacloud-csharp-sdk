// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DeleteCaCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance to which the CA certificate is bound.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-7mz2d******</para>
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// <para>The serial number of the CA certificate that you want to delete. The serial number is the unique identifier of a CA certificate.</para>
        /// <para>The serial number of a CA certificate cannot exceed 128 bytes in size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>007269004887******</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}

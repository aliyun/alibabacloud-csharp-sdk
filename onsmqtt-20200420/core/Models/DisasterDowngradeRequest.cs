// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DisasterDowngradeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance for which you want to downgrade the VIP access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-cn-xxxx</para>
        /// </summary>
        [NameInMap("DowngradeInstanceId")]
        [Validation(Required=false)]
        public string DowngradeInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class BatchQuerySessionByClientIdsRequest : TeaModel {
        /// <summary>
        /// <para>The list of clients.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientIdList.1</para>
        /// </summary>
        [NameInMap("ClientIdList")]
        [Validation(Required=false)]
        public List<string> ClientIdList { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance. The ID must match the actual instance ID used by the client. You can obtain the ID on the <b>Instance Details</b> page in the <a href="https://mqtt.console.aliyun.com">console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-0pp12gl****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ReadyForServiceRequest : TeaModel {
        /// <summary>
        /// <para>Device ID. This parameter is meaningless and can be filled with any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enter outbound-only mode after being published. This parameter is optional and defaults to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutboundScenario")]
        [Validation(Required=false)]
        public bool? OutboundScenario { get; set; }

        /// <summary>
        /// <para>Agent ID. If not specified, it defaults to the agent mapped to the current RAM account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-test@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

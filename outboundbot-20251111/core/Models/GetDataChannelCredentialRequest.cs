// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetDataChannelCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The client device ID used to apply for data channel credentials. It cannot be empty. It must be consistent with the DeviceId used by the same client for subsequent BridgeWebCall or MakePilotCall operations. The business identifier is provided by the integrator according to the agreement, and is not the ClientId returned by the service or the ChannelId of the voice channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>The instance identity of the associated product. You must use an instance that the user who invokes the operation has access to and that actually exists. It must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

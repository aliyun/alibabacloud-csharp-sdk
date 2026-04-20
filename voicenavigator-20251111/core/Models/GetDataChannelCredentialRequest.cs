// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetDataChannelCredentialRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>d4c38420-<b><b>-43bc-b001-56bfc274</b></b></para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c28fc549-d88f-4f6e-85ad-a0806e5e39c0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

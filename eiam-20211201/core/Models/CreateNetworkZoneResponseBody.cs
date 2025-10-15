// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateNetworkZoneResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>network_m6a57vre4g3h7m725yrq6pxxxx</para>
        /// </summary>
        [NameInMap("NetworkZoneId")]
        [Validation(Required=false)]
        public string NetworkZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

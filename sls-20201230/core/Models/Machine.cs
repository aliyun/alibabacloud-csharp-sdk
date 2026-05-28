// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Machine : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("host-id")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.xx.x</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1447182247</para>
        /// </summary>
        [NameInMap("lastHeartbeatTime")]
        [Validation(Required=false)]
        public long? LastHeartbeatTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3B70F4F1-80F7-46C4-A6C1-100***CEE647</para>
        /// </summary>
        [NameInMap("machine-uniqueid")]
        [Validation(Required=false)]
        public string MachineUniqueid { get; set; }

        [NameInMap("userdefined-id")]
        [Validation(Required=false)]
        public string UserdefinedId { get; set; }

    }

}

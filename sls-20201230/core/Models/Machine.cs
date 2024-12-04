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
        /// <para>192.168.x.x</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1657509674</para>
        /// </summary>
        [NameInMap("lastHeartbeatTime")]
        [Validation(Required=false)]
        public long? LastHeartbeatTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3B70F4F1-80F7-46C4-A6C1-100D66C***47</para>
        /// </summary>
        [NameInMap("machine-uniqueid")]
        [Validation(Required=false)]
        public string MachineUniqueid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("userdefined-id")]
        [Validation(Required=false)]
        public string UserdefinedId { get; set; }

    }

}

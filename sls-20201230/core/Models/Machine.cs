// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Machine : TeaModel {
        /// <summary>
        /// <para>The host ID of the machine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("host-id")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <para>The IP address of the machine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.x</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The time of the last heartbeat. The value is a UNIX timestamp. It represents the number of seconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1447182247</para>
        /// </summary>
        [NameInMap("lastHeartbeatTime")]
        [Validation(Required=false)]
        public long? LastHeartbeatTime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the machine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B70F4F1-80F7-46C4-A6C1-100****EE647</para>
        /// </summary>
        [NameInMap("machine-uniqueid")]
        [Validation(Required=false)]
        public string MachineUniqueid { get; set; }

        /// <summary>
        /// <para>The custom identifier of the machine. This parameter is valid only when the identity type of the machine group is set to custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("userdefined-id")]
        [Validation(Required=false)]
        public string UserdefinedId { get; set; }

    }

}

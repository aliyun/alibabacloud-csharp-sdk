// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Machine : TeaModel {
        /// <summary>
        /// 机器 ip 地址。
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// 最后一次心跳时间。Unix时间戳格式，表示从1970-1-1 00:00:00 UTC计算起的秒数。
        /// </summary>
        [NameInMap("lastHeartbeatTime")]
        [Validation(Required=false)]
        public long? LastHeartbeatTime { get; set; }

        /// <summary>
        /// 机器的唯一标识。
        /// </summary>
        [NameInMap("machine-uniqueid")]
        [Validation(Required=false)]
        public string MachineUniqueid { get; set; }

        /// <summary>
        /// 机器的用户自定义标识。
        /// </summary>
        [NameInMap("userdefined-id")]
        [Validation(Required=false)]
        public string UserdefinedId { get; set; }

    }

}

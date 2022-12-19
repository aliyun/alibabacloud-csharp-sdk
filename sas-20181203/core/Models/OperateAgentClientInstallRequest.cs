// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallRequest : TeaModel {
        /// <summary>
        /// The IDs of the servers on which you want to install the Security Center agent. Separate multiple IDs with commas (,).
        /// 
        /// >  You must specify at least one of the **InstanceIds** and **Uuids** parameters before you can call this operation.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to install the Security Center agent. Separate multiple UUIDs with commas (,).
        /// 
        /// >  You must specify at least one of the **InstanceIds** and **Uuids** parameters before you can call this operation.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}

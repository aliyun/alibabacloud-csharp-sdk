// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetInstanceRequest : TeaModel {
        /// <summary>
        /// The name of the security rule set corresponding to the control mode.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The name of the database link for the database instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the database instance belongs.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

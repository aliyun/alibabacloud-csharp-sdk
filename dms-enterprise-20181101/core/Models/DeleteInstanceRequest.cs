// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// The endpoint of the database instance. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to obtain the endpoint.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The port number that is used to connect to the database instance. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to obtain the port number.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The system ID (SID) of the database instance. You can call the [ListInstances](~~141936~~) or [GetInstance](~~141567~~) operation to obtain the SID.
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

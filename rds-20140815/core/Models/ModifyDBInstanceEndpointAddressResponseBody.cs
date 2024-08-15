// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceEndpointAddressResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBInstanceEndpointAddressResponseBodyData Data { get; set; }
        public class ModifyDBInstanceEndpointAddressResponseBodyData : TeaModel {
            /// <summary>
            /// The endpoint ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceEndpointId")]
            [Validation(Required=false)]
            public string DBInstanceEndpointId { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

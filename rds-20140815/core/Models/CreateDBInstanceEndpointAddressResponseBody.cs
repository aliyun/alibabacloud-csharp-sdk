// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceEndpointAddressResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDBInstanceEndpointAddressResponseBodyData Data { get; set; }
        public class CreateDBInstanceEndpointAddressResponseBodyData : TeaModel {
            /// <summary>
            /// The public endpoint.
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsMysqlDataSourceResponseBody : TeaModel {
        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOmsMysqlDataSourceResponseBodyData Data { get; set; }
        public class CreateOmsMysqlDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the data source record.
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

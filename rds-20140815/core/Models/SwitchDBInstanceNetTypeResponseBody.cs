// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceNetTypeResponseBody : TeaModel {
        /// <summary>
        /// The endpoint that is used to connect to the instance after the switch of endpoints.
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// The endpoint that is used to connect to the instance before the switch of endpoints.
        /// </summary>
        [NameInMap("OldConnectionString")]
        [Validation(Required=false)]
        public string OldConnectionString { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

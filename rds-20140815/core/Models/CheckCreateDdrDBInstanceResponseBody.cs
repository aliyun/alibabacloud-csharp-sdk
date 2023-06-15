// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckCreateDdrDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the data of the source instance can be restored across regions. Valid values:** true and false**
        /// </summary>
        [NameInMap("IsValid")]
        [Validation(Required=false)]
        public string IsValid { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

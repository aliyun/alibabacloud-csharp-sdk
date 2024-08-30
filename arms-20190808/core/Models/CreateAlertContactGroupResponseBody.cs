// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateAlertContactGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the alert contact group.
        /// </summary>
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public string ContactGroupId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

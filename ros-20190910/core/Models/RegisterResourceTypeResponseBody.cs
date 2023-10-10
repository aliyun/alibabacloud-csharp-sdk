// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class RegisterResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the registration record. You can call the [ListResourceTypeRegistrations](~~2330740~~) operation to query registration records.
        /// </summary>
        [NameInMap("RegistrationId")]
        [Validation(Required=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

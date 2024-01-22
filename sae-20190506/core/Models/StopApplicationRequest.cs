// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class StopApplicationRequest : TeaModel {
        /// <summary>
        /// The returned message.
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StopAlertResponseBody : TeaModel {
        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// A value of True indicates that the call succeeds. A value of False indicates that the call failed.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RenewDesktopGroupResponseBody : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public List<string> OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E55E6732-2028-52FA-AB06-EA29C36B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

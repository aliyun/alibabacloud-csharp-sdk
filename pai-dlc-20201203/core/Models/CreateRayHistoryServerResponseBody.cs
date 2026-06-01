// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateRayHistoryServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rhsxxxx</para>
        /// </summary>
        [NameInMap("RayHistoryServerId")]
        [Validation(Required=false)]
        public string RayHistoryServerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

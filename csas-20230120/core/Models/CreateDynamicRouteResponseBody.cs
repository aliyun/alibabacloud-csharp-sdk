// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDynamicRouteResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dr-ca9fddfac7c6****</para>
        /// </summary>
        [NameInMap("DynamicRouteId")]
        [Validation(Required=false)]
        public string DynamicRouteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

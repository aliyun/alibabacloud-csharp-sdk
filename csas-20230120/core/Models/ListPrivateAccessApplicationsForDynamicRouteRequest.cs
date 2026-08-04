// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationsForDynamicRouteRequest : TeaModel {
        /// <summary>
        /// <para>Collection of dynamic route IDs. You can specify up to 100 dynamic route IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DynamicRouteIds")]
        [Validation(Required=false)]
        public List<string> DynamicRouteIds { get; set; }

    }

}

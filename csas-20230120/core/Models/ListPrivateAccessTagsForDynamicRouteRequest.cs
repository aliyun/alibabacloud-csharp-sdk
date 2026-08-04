// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsForDynamicRouteRequest : TeaModel {
        /// <summary>
        /// <para>A collection of dynamic route IDs. You can enter a maximum of 100 dynamic route IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DynamicRouteIds")]
        [Validation(Required=false)]
        public List<string> DynamicRouteIds { get; set; }

    }

}

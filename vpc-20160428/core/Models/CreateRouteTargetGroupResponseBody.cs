// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteTargetGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AA5CE21-2E6A-4530-BDF5-F055849476E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the route target group instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtg-xxxx</para>
        /// </summary>
        [NameInMap("RouteTargetGroupId")]
        [Validation(Required=false)]
        public string RouteTargetGroupId { get; set; }

    }

}

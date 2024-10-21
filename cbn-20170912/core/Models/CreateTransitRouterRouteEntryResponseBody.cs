// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>835E7F4B-B380-4E0F-96A5-6EA572388047</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-75eg4jprkvk0pw****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryId { get; set; }

    }

}

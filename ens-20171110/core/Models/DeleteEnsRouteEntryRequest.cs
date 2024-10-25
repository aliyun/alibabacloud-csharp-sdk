// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteEnsRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the route that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-8vbmb2890wiret5maqq25</para>
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

    }

}

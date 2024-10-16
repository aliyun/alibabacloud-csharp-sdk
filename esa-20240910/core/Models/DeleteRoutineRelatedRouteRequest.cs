// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineRelatedRouteRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DeleteRoutineRelatedRoute</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Route")]
        [Validation(Required=false)]
        public string Route { get; set; }

        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

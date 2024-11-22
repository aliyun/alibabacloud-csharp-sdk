// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineRelatedRouteRequest : TeaModel {
        /// <summary>
        /// <para>The routine name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DeleteRoutineRelatedRoute</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The route URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>.example.com/path1</em></para>
        /// </summary>
        [NameInMap("Route")]
        [Validation(Required=false)]
        public string Route { get; set; }

        /// <summary>
        /// <para>The route ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c3b82a3d1524e9f750da11d0cc0be0a</para>
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

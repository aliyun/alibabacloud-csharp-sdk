// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineRelatedRouteRequest : TeaModel {
        [NameInMap("ByPass")]
        [Validation(Required=false)]
        public string ByPass { get; set; }

        /// <summary>
        /// <para>The routine name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateRoutineRelatedRoute</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>.example.com/path1</em></para>
        /// </summary>
        [NameInMap("Route")]
        [Validation(Required=false)]
        public string Route { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

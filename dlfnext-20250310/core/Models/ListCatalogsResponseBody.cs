// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListCatalogsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of catalogs.</para>
        /// </summary>
        [NameInMap("catalogs")]
        [Validation(Required=false)]
        public List<Catalog> Catalogs { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is null, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>A list of subscription computing resources.</para>
        /// </summary>
        [NameInMap("prepayResource")]
        [Validation(Required=false)]
        public List<PrepayResource> PrepayResource { get; set; }

    }

}

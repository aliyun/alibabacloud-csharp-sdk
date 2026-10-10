// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListCatalogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of catalogs.</para>
        /// </summary>
        [NameInMap("catalogs")]
        [Validation(Required=false)]
        public List<Catalog> Catalogs { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. A null value indicates that the current query has reached the last page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The list of subscription compute resources.</para>
        /// </summary>
        [NameInMap("prepayResource")]
        [Validation(Required=false)]
        public List<PrepayResource> PrepayResource { get; set; }

    }

}

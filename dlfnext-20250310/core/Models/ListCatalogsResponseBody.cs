// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListCatalogsResponseBody : TeaModel {
        [NameInMap("catalogs")]
        [Validation(Required=false)]
        public List<Catalog> Catalogs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("prepayResource")]
        [Validation(Required=false)]
        public List<PrepayResource> PrepayResource { get; set; }

    }

}

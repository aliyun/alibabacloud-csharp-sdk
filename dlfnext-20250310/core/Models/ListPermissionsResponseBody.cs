// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token used to retrieve the next page of data. If null is returned, the current page is the last page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The permission list.</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<Permission> Permissions { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetCatalogsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the catalog. If this parameter is left empty, all catalogs are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon</para>
        /// </summary>
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

    }

}

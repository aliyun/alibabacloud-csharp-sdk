// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The catalog UUID. You can obtain it by calling ListAgenticCatalog or SearchAgenticCatalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-OfjcNc2z***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

    }

}

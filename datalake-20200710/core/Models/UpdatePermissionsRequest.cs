// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdatePermissionsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Accesses")]
        [Validation(Required=false)]
        public List<string> Accesses { get; set; }

        /// <summary>
        /// CatalogId
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DelegateAccesses")]
        [Validation(Required=false)]
        public List<string> DelegateAccesses { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetaResource")]
        [Validation(Required=false)]
        public MetaResource MetaResource { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Principal")]
        [Validation(Required=false)]
        public Principal Principal { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

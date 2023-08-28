// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsRequest : TeaModel {
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Obtains the data restoration version of a data source.
        /// </summary>
        [NameInMap("validStatus")]
        [Validation(Required=false)]
        public bool? ValidStatus { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsRequest : TeaModel {
        /// <summary>
        /// The data center where the data source is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the index versions to be returned. Valid values:
        /// 
        /// 1.  true (default): returns the index versions that are complete and not expired.
        /// 2.  false: returns all index versions.
        /// </summary>
        [NameInMap("validStatus")]
        [Validation(Required=false)]
        public bool? ValidStatus { get; set; }

    }

}

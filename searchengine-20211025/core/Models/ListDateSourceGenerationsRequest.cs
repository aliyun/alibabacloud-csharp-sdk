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
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The valid state of the data source. Valid values: true and false. The default value of this parameter is true.
        /// 
        /// 1.  true indicates that the generations that have not expired and of which the tasks have been executed are returned.
        /// 2.  false indicates that all generations are returned.
        /// </summary>
        [NameInMap("validStatus")]
        [Validation(Required=false)]
        public bool? ValidStatus { get; set; }

    }

}

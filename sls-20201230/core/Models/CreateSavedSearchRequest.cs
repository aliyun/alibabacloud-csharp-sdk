// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateSavedSearchRequest : TeaModel {
        /// <summary>
        /// The display name.
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the Logstore to which the saved search belongs.
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// The name of the saved search. The name must be 3 to 63 characters in length.
        /// </summary>
        [NameInMap("savedsearchName")]
        [Validation(Required=false)]
        public string SavedsearchName { get; set; }

        /// <summary>
        /// The query statement of the saved search. A query statement consists of a search statement and an analytic statement in the `Search statement|Analytic statement` format. For more information about search statements and analytic statements, see [Log search overview](~~43772~~) and [Log analysis overview](~~53608~~).
        /// </summary>
        [NameInMap("searchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// The topic of the log.
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

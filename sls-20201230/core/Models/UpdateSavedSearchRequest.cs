// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateSavedSearchRequest : TeaModel {
        /// <summary>
        /// The display name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the Logstore to which the saved search belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// The name of the saved search. The name must be 3 to 63 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("savedsearchName")]
        [Validation(Required=false)]
        public string SavedsearchName { get; set; }

        /// <summary>
        /// The search statement or the query statement of the saved search. A query statement consists of a search statement and an analytic statement in the Search statement|Analytic statement format.
        /// 
        /// For more information, see Log search overview and Log analysis overview.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("searchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// The topic of the logs.
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

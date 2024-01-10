// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListDiagnosticsRequest : TeaModel {
        /// <summary>
        /// The keyword in the diagnosis.
        /// </summary>
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        /// <summary>
        /// The product that is diagnosed.
        /// </summary>
        [NameInMap("DiagnosticProduct")]
        [Validation(Required=false)]
        public string DiagnosticProduct { get; set; }

        /// <summary>
        /// The maximum number of results to be returned in a single call when NextToken is used for the query.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The diagnosis status.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

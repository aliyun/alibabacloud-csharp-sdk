// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteSQLQueryRequest : TeaModel {
        /// <summary>
        /// The SQL statement to be executed.
        /// 
        /// The number of characters in the SQL statement must be less than 2,000.
        /// 
        /// For more information about the SQL syntax, see [Basic SQL syntax](~~2539395~~).
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The search scope.
        /// 
        /// Set this parameter to the ID of a resource group.
        /// 
        /// For information about how to obtain the ID of a resource group, see [ListResourceGroups](~~158855~~).
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

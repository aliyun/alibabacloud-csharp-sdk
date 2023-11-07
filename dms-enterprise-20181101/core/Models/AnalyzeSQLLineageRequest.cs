// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AnalyzeSQLLineageRequest : TeaModel {
        /// <summary>
        /// The database ID.
        /// 
        /// >  You can call one of the [SearchDatabase](~~141876~~), [ListDatabases](~~141873~~), and [GetDatabase](~~141869~~) operations to obtain the database ID provided in the DatabaseId response parameter.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// The SQL statement.
        /// </summary>
        [NameInMap("SqlContent")]
        [Validation(Required=false)]
        public string SqlContent { get; set; }

        /// <summary>
        /// The tenant ID.
        /// 
        /// >  To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see [Manage DMS tenants](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

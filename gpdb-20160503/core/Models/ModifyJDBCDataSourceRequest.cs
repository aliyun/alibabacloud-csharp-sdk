// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyJDBCDataSourceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The JDBC connection string.
        /// </summary>
        [NameInMap("JDBCConnectionString")]
        [Validation(Required=false)]
        public string JDBCConnectionString { get; set; }

        /// <summary>
        /// The password of the database account.
        /// </summary>
        [NameInMap("JDBCPassword")]
        [Validation(Required=false)]
        public string JDBCPassword { get; set; }

        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("JDBCUserName")]
        [Validation(Required=false)]
        public string JDBCUserName { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

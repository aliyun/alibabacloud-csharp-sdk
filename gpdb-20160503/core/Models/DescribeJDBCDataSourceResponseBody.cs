// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeJDBCDataSourceResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the service. The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The status of the service. Valid values:
        /// 
        /// *   Init
        /// *   Running
        /// *   Exception
        /// </summary>
        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        /// <summary>
        /// The type of the data source.
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("ExternalDataServiceId")]
        [Validation(Required=false)]
        public string ExternalDataServiceId { get; set; }

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

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

    }

}

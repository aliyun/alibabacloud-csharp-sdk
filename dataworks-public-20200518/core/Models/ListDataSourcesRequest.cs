// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataSourcesRequest : TeaModel {
        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   odps
        /// *   mysql
        /// *   rds
        /// *   oss
        /// *   sqlserver
        /// *   polardb
        /// *   oracle
        /// *   mongodb
        /// *   emr
        /// *   postgresql
        /// *   analyticdb_for_mysql
        /// *   hybriddb_for_postgresql
        /// *   holo
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The environment in which the data source is used. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The name of the data source that you want to query.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return. The value of this parameter must be an integer greater than or equal to 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace to which the data sources belong. You can call the [ListProjects](~~178393~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The status of the data source. Valid values:
        /// 
        /// *   ENABLED: The data source is accessible.
        /// *   DISABLED: The data source is inaccessible.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The subtype of the data source. This parameter takes effect only if the DataSourceType parameter is set to rds.
        /// 
        /// If the DataSourceType parameter is set to rds, this parameter can be set to mysql, sqlserver, or postgresql.
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}

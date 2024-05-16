// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDataSourcesRequest : TeaModel {
        /// <summary>
        /// The data source type. Valid values:
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
        /// The environment to which the data sources belong. Valid values:
        /// 
        /// *   0: development environment
        /// *   1: production environment
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The keyword contained in the names of the data sources to be exported.
        /// 
        /// You can specify only one keyword. For example, if you set this parameter to test, all the data sources whose names contain test in the specified workspace are exported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return. The value of this parameter must be a positive integer greater than or equal to 1.
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
        /// The ID of the DataWorks workspace to which the data sources belong. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to query the ID of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The data source subtype. This parameter takes effect only if the DataSourceType parameter is set to rds.
        /// 
        /// If the DataSourceType parameter is set to rds, this parameter can be set to mysql, sqlserver, or postgresql.
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}

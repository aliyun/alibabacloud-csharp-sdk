// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListConnectionsRequest : TeaModel {
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
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

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
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the workspace to which the data source belongs. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The status of the data source. Valid values:
        /// 
        /// *   ENABLED
        /// *   DISABLED
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The subtype of the data source. This parameter is used in scenarios where a type includes subtypes. The following type and subtypes are supported:
        /// 
        /// *   Type: `rds`
        /// *   Subtypes: `mysql`, `sqlserver`, and `postgresql`
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteTableRequest : TeaModel {
        /// <summary>
        /// The globally unique identifier (GUID) of the MaxCompute project. Specify the GUID in the odps.{projectName} format.
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// The type of the compute engine or data source. Valid values:
        /// 
        /// *   cdh
        /// *   analyticdb_for_mysql
        /// *   odps
        /// *   emr
        /// *   hadoop
        /// *   holodb
        /// *   hybriddb_for_postgresql
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The schema information of the table. You need to enter the schema information of the table if you enable the table schema in MaxCompute.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// The name of the MaxCompute table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}

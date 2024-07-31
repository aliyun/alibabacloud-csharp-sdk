// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityEntityRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// 
        /// The value 0 indicates that the partition filter expression is at the SQL level, and the system checks data quality after each SQL statement is executed.
        /// 
        /// *
        /// *
        /// </summary>
        [NameInMap("EntityLevel")]
        [Validation(Required=false)]
        public int? EntityLevel { get; set; }

        /// <summary>
        /// The type of the compute engine or data source.
        /// 
        /// Valid values:
        /// 
        /// *   odps
        /// *   emr
        /// *   hadoop
        /// *   cdh
        /// *   analyticdb_for_mysql
        /// *   hybriddb_for_postgresql
        /// *   holodb
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The partition filter expression.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MatchExpression")]
        [Validation(Required=false)]
        public string MatchExpression { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the DataWorks console to query the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the compute engine or data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}

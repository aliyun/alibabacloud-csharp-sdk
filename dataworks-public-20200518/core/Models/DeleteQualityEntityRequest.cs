// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteQualityEntityRequest : TeaModel {
        /// <summary>
        /// The ID of the partition filter expression.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The type of the compute engine or data source. The following types are supported: E-MapReduce (EMR), Hologres, AnalyticDB for PostgreSQL, CDH, MaxCompute, Kafka, and DataHub.
        /// 
        /// Valid values:
        /// 
        /// *   odps
        /// *   emr
        /// *   hadoop
        /// *   cdh
        /// *   hybriddb_for_postgresql
        /// *   holodb
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The DataWorks workspace ID.
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

    }

}

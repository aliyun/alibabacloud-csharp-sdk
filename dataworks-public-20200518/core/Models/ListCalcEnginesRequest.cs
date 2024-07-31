// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesRequest : TeaModel {
        /// <summary>
        /// The type of the compute engine. The value of this parameter is not case-sensitive. Valid values:
        /// 
        /// *   **ODPS**
        /// *   **EMR**
        /// *   **BLINK**
        /// *   **HOLO**
        /// *   **MaxGraph**
        /// *   **HYBRIDDB_FOR_POSTGRESQL**
        /// *   **ADB_MYSQL**
        /// *   **HADOOP_CDH**
        /// *   **CLICKHOUSE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CalcEngineType")]
        [Validation(Required=false)]
        public string CalcEngineType { get; set; }

        /// <summary>
        /// The environment in which the compute engine is used. Valid values:
        /// 
        /// *   **DEV**
        /// *   **PRD**
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The name of the compute engine, which must be exactly matched.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
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
        /// The ID of the DataWorks workspace with which the compute engine is associated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}

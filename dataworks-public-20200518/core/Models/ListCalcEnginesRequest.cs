// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesRequest : TeaModel {
        /// <summary>
        /// The type of the compute engine instance. Valid values: `ODPS`, `EMR`, `BLINK`, `HOLO`, `MaxGraph`, `HYBRIDDB_FOR_POSTGRESQL`, `ADB_MYSQL`, and `HADOOP_CDH`. The values are not case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CalcEngineType")]
        [Validation(Required=false)]
        public string CalcEngineType { get; set; }

        /// <summary>
        /// The environment in which the compute engine instance runs. Valid values: DEV and PRD. The value DEV indicates the development environment, and the value PRD indicates the production environment.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The name of the compute engine instance that you want to query. Only exact match is supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 100. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The DataWorks workspace with which the compute engine instances are associated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}

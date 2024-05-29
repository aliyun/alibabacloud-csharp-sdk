// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SummaryJobDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration or data synchronization instance.
        /// 
        /// >  You must specify at least one of the DtsJobId and DtsInstanceId parameters.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the data migration or data synchronization task.
        /// 
        /// >  You must specify at least one of the DtsJobId and DtsInstanceId parameters.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The phase of the data migration task. Valid values:
        /// 
        /// *   **02**: The task is in the schema migration phase.
        /// *   **03**: The task is in the incremental migration phase.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of schema definition. Valid values:
        /// 
        /// *   **before**: schema migration or initial schema synchronization
        /// *   **after**: DDL operations performed during incremental data migration or synchronization
        /// </summary>
        [NameInMap("StructType")]
        [Validation(Required=false)]
        public string StructType { get; set; }

        /// <summary>
        /// The synchronization direction of the data synchronization task. Valid values:
        /// 
        /// *   **Forward**: Data is synchronized from the source database to the destination database.
        /// *   **Reverse**: Data is synchronized from the destination database to the source database.
        /// 
        /// > 
        /// *   Default value: **Forward**.
        /// *   You can set this parameter to **Reverse** to delete the reverse synchronization task only if the topology is two-way synchronization.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}

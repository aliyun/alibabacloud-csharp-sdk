// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The task code that specifies the type of the DTS subtask. Valid values:
        /// 
        /// *   **01**: precheck
        /// *   **02**: schema migration or initial schema synchronization
        /// *   **03**: full data migration or initial full data synchronization
        /// *   **04**: incremental data migration or synchronization
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// The filter item used to filter tables in fuzzy match.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than **0** and does not exceed the maximum value of the Integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID of the DTS instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The filter item used to filter tables, views, and functions during schema migration.
        /// </summary>
        [NameInMap("StructPhase")]
        [Validation(Required=false)]
        public string StructPhase { get; set; }

        /// <summary>
        /// The type of schema definition. Valid values:
        /// 
        /// *   **before**: schema migration or initial schema synchronization
        /// *   **after**: DDL operations performed during incremental data migration or synchronization
        /// </summary>
        [NameInMap("StructType")]
        [Validation(Required=false)]
        public string StructType { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsRequest : TeaModel {
        /// <summary>
        /// The maximum number of rows that you want the current query to return. To query only the number of matched rows without the need to return specific data, you can set the Limit parameter to `0`. Then, the operation returns only the number of matched rows.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token that is required to obtain the next page of backup snapshots.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The query conditions. Example:
        /// 
        ///     [
        ///       {
        ///         "field": "VaultId",
        ///         "value": "v-0003rf9m*****qx5",
        ///         "operation": "MATCH_TERM"
        ///       },
        ///       {
        ///         "field": "InstanceId",
        ///         "value": "i-bp1i20zq2*****e9368m",
        ///         "operation": "MATCH_TERM"
        ///       },
        ///       {
        ///         "field": "PlanId",
        ///         "value": "plan-0005vk*****gkd1iu4f",
        ///         "operation": "MATCH_TERM"
        ///       },
        ///       {
        ///         "field": "CompleteTime",
        ///         "value": 1626769913,
        ///         "operation": "GREATER_THAN_OR_EQUAL"
        ///       }
        ///     ]
        /// 
        /// *   The following fields are supported:
        /// 
        ///     *   VaultId: specifies the ID of the backup vault. This field is required.
        ///     *   InstanceId: specifies the ID of the ECS instance. If the SourceType parameter is set to ECS_FILE, this field is required.
        ///     *   Bucket: specifies the ID of the OSS bucket. If the SourceType parameter is set to OSS, this field is required.
        ///     *   FileSystemId: specifies the ID of the NAS file system. If the SourceType parameter is set to NAS, this field is required.
        ///     *   CreateTime: specifies the time when the NAS file system was created. If the SourceType parameter is set to NAS, this field is required.
        ///     *   CompleteTime: specifies the time when the backup snapshot was completed.
        ///     *   PlanId: the ID of a backup plan.
        /// 
        /// *   The following operations are supported:
        /// 
        ///     *   MATCH_TERM: exact match.
        ///     *   GREATER_THAN: greater than.
        ///     *   GREATER_THAN_OR_EQUAL: greater than or equal to.
        ///     *   LESS_THAN: less than.
        ///     *   LESS_THAN_OR_EQUAL: less than or equal to.
        ///     *   BETWEEN: specifies a JSON array as a range. The results must fall within the range in the `[Minimum value,Maximum value]` format.
        ///     *   IN: specifies an array as a collection. The results must fall within the collection.
        ///     *   NOT_IN: specifies an array as a collection. The results cannot fall within the collection.
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public List<object> Query { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: backup snapshots for Elastic Compute Service (ECS) files
        /// *   **OSS**: backup snapshots for Object Storage Service (OSS) buckets
        /// *   **NAS**: backup snapshots for Apsara File Storage NAS file systems
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

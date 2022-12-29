// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditRecordsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  If you set this parameter to the ID of a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the database to be queried. By default, all databases are queried.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The end of the time range that is specified to query the audit log. The end time must be later than the start time. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// >  The end time must be within 24 hours from the start time. Otherwise, the query fails.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The form of the audit log that the operation returns. Valid values:
        /// 
        /// *   **File**: triggers the generation of audit logs. If this parameter is set to File, only common parameters are returned.
        /// *   **Stream**: returns data streams.
        /// 
        /// Default value: **Stream**.
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public string Form { get; set; }

        /// <summary>
        /// The ID of the mongos node or shard node whose audit logs you want to query in the instance. If the instance is a sharded cluster instance, you must specify this parameter.
        /// 
        /// >  This parameter is valid only when **DBInstanceId** is set to the ID of a sharded cluster instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The order of time in which the log entries to return are sorted. Valid values:
        /// 
        /// *   asc: The log entries are sorted by time in ascending order.
        /// *   desc: The log entries are sorted by time in descending order.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The keywords that are used for queries. Separate multiple keywords with spaces. The maximum number of keywords is 10.
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The user of the database. If you do not specify this parameter, this operation returns records of all users.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}

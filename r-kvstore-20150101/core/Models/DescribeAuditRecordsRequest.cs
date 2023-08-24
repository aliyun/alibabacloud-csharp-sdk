// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAuditRecordsRequest : TeaModel {
        /// <summary>
        /// The username of the account. If you do not specify this parameter, this call applies to all accounts of the instance.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the database in the instance. If you do not specify this parameter, all databases are queried. Valid values: 0 to 255. 0 specifies the database 0.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > We recommend that you specify a time range of 10 minutes or less because audit logs contain a great number of entries. Do not specify a time range that is longer than one day.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The IP address of the client. If you do not specify this parameter, this call applies to all clients.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the node in the instance. You can set this parameter to query the data of a specified node.
        /// 
        /// > 
        /// 
        /// *   This parameter is available only for read/write splitting or cluster instances of ApsaraDB for Redis.
        /// 
        /// *   You can call the [DescribeLogicInstanceTopology](~~94665~~) operation to query node IDs.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The keyword based on which the audit logs are queried. You can specify a command as a keyword to query logs. By default, all commands are queried.
        /// 
        /// > You can specify only a single keyword in each call.
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

    }

}

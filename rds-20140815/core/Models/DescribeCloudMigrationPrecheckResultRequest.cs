// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCloudMigrationPrecheckResultRequest : TeaModel {
        /// <summary>
        /// The ID of the destination instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the IDs of instances.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **30** to **100**. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The private or public IP address that is used to connect to the self-managed PostgreSQL instance.
        /// 
        /// *   If the self-managed PostgreSQL instance resides on an Elastic Compute Service (ECS) instance, enter the private IP address of the ECS instance. For more information about how to obtain the private IP address of an ECS instance, see [View IP addresses](~~273914~~).
        /// *   If the self-managed PostgreSQL instance resides in an on-premises data center, enter the private IP address of the on-premises data center.
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// The port number that is used to connect to the self-managed PostgreSQL instance. You can run the netstat -a | grep PGSQL command to obtain the port number.
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// The ID of the task. You can obtain the ID of the task from the response that is returned after you call the [CreateCloudMigrationPrecheckTask](~~409831~~) operation to create the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The name of the task. You can obtain the name of the task from the response that is returned after you call the [CreateCloudMigrationPrecheckTask](~~409831~~) operation to create the task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

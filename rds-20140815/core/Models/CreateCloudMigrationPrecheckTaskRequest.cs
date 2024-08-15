// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateCloudMigrationPrecheckTaskRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The username of the account that is used to connect to the self-managed PostgreSQL instance. Enter the username of the account that you created in the [Create an account for cloud migration on a self-managed PostgreSQL instance](https://help.aliyun.com/document_detail/369500.html) topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// The environment in which the self-managed PostgreSQL instance runs.
        /// 
        /// *   **idcOnVpc**: The self-managed PostgreSQL instance resides in a data center. The data center can communicate with the VPC to which the ApsaraDB RDS for PostgreSQL instance belongs.
        /// *   **ecsOnVpc**: The self-managed PostgreSQL instance resides on an ECS instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// The private IP address that is used to connect to the self-managed PostgreSQL instance.
        /// 
        /// *   If the self-managed PostgreSQL instance resides on an ECS instance, enter the private IP address of the ECS instance. For more information about how to obtain the private IP address of an ECS instance, see [View IP addresses](https://help.aliyun.com/document_detail/273914.html).
        /// *   If the self-managed PostgreSQL instance resides in an on-premises data center, enter the private IP address of the on-premises data center.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// The password of the account that is used to connect to the self-managed PostgreSQL instance. Enter the password of the account that you created in the [Create an account for cloud migration on a self-managed PostgreSQL instance](https://help.aliyun.com/document_detail/369500.html) topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        /// <summary>
        /// The port that is used to connect to the self-managed PostgreSQL instance. You can run the `netstat -a | grep PGSQL` command to view the port.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// The name of the task. If you do not specify this parameter, ApsaraDB RDS automatically generates a name for the cloud migration task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

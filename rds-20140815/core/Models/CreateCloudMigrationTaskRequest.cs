// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateCloudMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination instance. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp102g323jd4****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to connect to the self-managed PostgreSQL instance. Enter the username of the account that you created in the <a href="https://help.aliyun.com/document_detail/369500.html">Create an account for cloud migration on a self-managed PostgreSQL instance</a> topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>migratetest</para>
        /// </summary>
        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// <para>The environment in which the self-managed PostgreSQL instance runs.</para>
        /// <list type="bullet">
        /// <item><description><b>idcOnVpc</b>: The self-managed PostgreSQL instance resides in a data center. The data center can communicate with the VPC to which the ApsaraDB RDS for PostgreSQL instance belongs.</description></item>
        /// <item><description><b>ecsOnVpc</b>: The self-managed PostgreSQL instance resides on an ECS instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecsOnVpc</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The private or public IP address that is used to connect to the self-managed PostgreSQL instance.</para>
        /// <list type="bullet">
        /// <item><description>If the self-managed PostgreSQL instance resides on an Elastic Compute Service (ECS) instance, enter the private IP address of the ECS instance. For more information about how to obtain the private IP address of an ECS instance, see <a href="https://help.aliyun.com/document_detail/273914.html">View IP addresses</a>.</description></item>
        /// <item><description>If the self-managed PostgreSQL instance resides in a data center, enter the private IP address of the data center.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to connect to the self-managed PostgreSQL instance. Enter the password of the account that you created in the <a href="https://help.aliyun.com/document_detail/369500.html">Create an account for cloud migration on a self-managed PostgreSQL instance</a> topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        /// <summary>
        /// <para>The port number that is used to connect to the self-managed PostgreSQL instance. You can run the <c>netstat -a | grep PGSQL</c> command to obtain the port number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// <para>The name of the task. If you do not specify this parameter, ApsaraDB RDS automatically generates a name for the cloud migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>362c6c7a-4d20-4eac-898c-1495ceab374c</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

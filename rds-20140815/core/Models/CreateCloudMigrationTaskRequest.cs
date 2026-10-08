// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateCloudMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target instance. You can invoke the DescribeDBInstances operation to query the instance ID.</para>
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
        /// <para>The username. The database account created in the <a href="https://help.aliyun.com/document_detail/369500.html">Create a migration account</a> step.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>migratetest</para>
        /// </summary>
        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// <para>The category of the source instance.</para>
        /// <list type="bullet">
        /// <item><description><b>aliyunRDS</b>: ApsaraDB RDS instance.</description></item>
        /// <item><description><b>other</b>: other.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunRDS</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The internal or public IP address of the self-managed PostgreSQL database.</para>
        /// <list type="bullet">
        /// <item><description>To migrate a self-managed PostgreSQL database on an ECS instance to the cloud, set this parameter to the private IP address of the ECS instance. For more information about how to obtain the IP address, see <a href="https://help.aliyun.com/document_detail/98677.html">View IP addresses</a>.</description></item>
        /// <item><description>To migrate a self-managed PostgreSQL database in an Internet Data Center (IDC) to the cloud, set this parameter to the internal IP address of the IDC.</description></item>
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
        /// <para>The password. The password of the database account created in the <a href="https://help.aliyun.com/document_detail/369500.html">Create a migration account</a> step.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        /// <summary>
        /// <para>The port of the self-managed PostgreSQL database. You can run the <c>netstat -a | grep PGSQL</c> command to view the port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// <para>The task name. You can specify a custom name. If you do not specify this parameter, the system automatically generates a name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>362c6c7a-4d20-4eac-898c-1495ceab374c</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

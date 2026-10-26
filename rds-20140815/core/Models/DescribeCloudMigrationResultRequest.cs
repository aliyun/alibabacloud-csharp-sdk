// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCloudMigrationResultRequest : TeaModel {
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

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The internal IP address of the self-managed PostgreSQL database.</para>
        /// <list type="bullet">
        /// <item><description>In the scenario of migrating a self-managed PostgreSQL database on an ECS instance to the cloud with one click, set this parameter to the private IP address of the ECS instance. For more information about how to obtain the IP address, see <a href="https://help.aliyun.com/document_detail/273914.html">View IP addresses</a>.</description></item>
        /// <item><description>In the scenario of migrating a self-managed PostgreSQL database in an on-premises data center to the cloud with one click, set this parameter to the internal IP address of the data center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// <para>The port of the self-managed PostgreSQL database. You can run the netstat -a | grep PGSQL command to view the port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// <para>The ID of the task. You can obtain the task ID from the response when you call the CreateCloudMigrationTask operation to create an ApsaraDB RDS for PostgreSQL cloud migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440437220</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The name of the task. You can obtain the task name from the response when you call the CreateCloudMigrationTask operation to create an ApsaraDB RDS for PostgreSQL cloud migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>362c6c7a-4d20-4eac-898c-1495ceab374c</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

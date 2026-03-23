// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateImportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1u*****ggm7j9j</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>Estimated data space, in GB</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("EstimatedSize")]
        [Validation(Required=false)]
        public int? EstimatedSize { get; set; }

        /// <summary>
        /// <para>The source MySQL host IP address. RDS will access this IP address to retrieve the backup.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.246.90</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The Password of the source MySQL Account, which must be Base64-encoded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OEF5JjVOM2pzZXFKRw==</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Source MySQL port</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The Region ID. You can invoke <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> to obtain it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The source cloud instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1fe296n52ub3chezpg</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// <para>Source cloud instance type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>Stream port used for backup transmission</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9999</para>
        /// </summary>
        [NameInMap("StreamPort")]
        [Validation(Required=false)]
        public int? StreamPort { get; set; }

        /// <summary>
        /// <para>Source MySQL account, which must have permissions to create backups and set up replication. Refer to the following SQL for granting permissions:  </para>
        /// <pre><c>-- MySQL 5.7  
        /// mysql&gt; CREATE USER \\&quot;myadmin\\&quot;@\\&quot;%\\&quot; IDENTIFIED BY \\&quot;s3cret\\&quot;;  
        /// mysql&gt; GRANT RELOAD, LOCK TABLES, PROCESS, REPLICATION CLIENT, REPLICATION SLAVE ON *.* TO  
        ///        \\&quot;myadmin\\&quot;@\\&quot;%\\&quot;;  
        /// mysql&gt; FLUSH PRIVILEGES;  
        /// -- MySQL 8.0  
        /// mysql&gt; CREATE USER \\&quot;myadmin\\&quot;@\\&quot;%\\&quot; IDENTIFIED BY \\&quot;Test123!\\&quot;;  
        /// mysql&gt; GRANT BACKUP_ADMIN, PROCESS, RELOAD, LOCK TABLES, REPLICATION CLIENT, REPLICATION SLAVE ON *.* TO \\&quot;myadmin\\&quot;@\\&quot;%\\&quot;;  
        /// mysql&gt; GRANT SELECT ON performance_schema.log_status TO \\&quot;myadmin\\&quot;@\\&quot;%\\&quot;;  
        /// mysql&gt; GRANT SELECT ON performance_schema.keyring_component_status TO myadmin@\\&quot;%\\&quot;;  
        /// mysql&gt; GRANT SELECT ON performance_schema.replication_group_members TO myadmin@\\&quot;%\\&quot;;  
        /// mysql&gt; FLUSH PRIVILEGES;  
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myadmin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>Installation path of xtrabackup on the source</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/bin/xtrabackup</para>
        /// </summary>
        [NameInMap("XtrabackupPath")]
        [Validation(Required=false)]
        public string XtrabackupPath { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateReplicationLinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DR instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1trqb4p1xd****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run before the system creates the DR instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run but does not create the instance. The system checks the request parameters, request syntax, limits, and available resources.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and the actual request. If the request passes the dry run, the instance is directly created.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The account of the database that is used for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdbuser</para>
        /// </summary>
        [NameInMap("ReplicatorAccount")]
        [Validation(Required=false)]
        public string ReplicatorAccount { get; set; }

        /// <summary>
        /// <para>The password of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ReplicatorPassword")]
        [Validation(Required=false)]
        public string ReplicatorPassword { get; set; }

        /// <summary>
        /// <para>The endpoint of the source ApsaraDB RDS for PostgreSQL instance or the IP address of the source ApsaraDB RDS for SQL Server instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-****.pg.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SourceAddress")]
        [Validation(Required=false)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>other</b>: other instances. <b>SQL Server instances are not supported.</b></description></item>
        /// <item><description><b>aliyunRDS</b>: an ApsaraDB RDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunRDS</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The name of the source instance. If you set <b>SourceCategory</b> to <b>aliyunRDS</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstance</para>
        /// </summary>
        [NameInMap("SourceInstanceName")]
        [Validation(Required=false)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance. If you set <b>SourceCategory</b> to <b>aliyunRDS</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceInstanceRegionId")]
        [Validation(Required=false)]
        public string SourceInstanceRegionId { get; set; }

        /// <summary>
        /// <para>The port of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public long? SourcePort { get; set; }

        /// <summary>
        /// <para>The IP address of the DR instance of the ApsaraDB RDS for SQL Server instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XXX.XX.XXX</para>
        /// </summary>
        [NameInMap("TargetAddress")]
        [Validation(Required=false)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// <para>The task ID of the successful dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>439946016</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The task name of the dry run. You can specify a custom task name. If you do not specify this parameter, ApsaraDB RDS automatically generates a task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

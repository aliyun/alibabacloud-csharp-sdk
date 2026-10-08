// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateReplicationLinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the disaster recovery instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2zeytekus0r******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for creating the synchronization link of the disaster recovery instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Executes a dry run without creating the instance. The system checks items such as request parameters, request format, business limits, and inventory.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request and creates the instance after the check is passed.</description></item>
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
        /// <para>The database account used for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdbuser</para>
        /// </summary>
        [NameInMap("ReplicatorAccount")]
        [Validation(Required=false)]
        public string ReplicatorAccount { get; set; }

        /// <summary>
        /// <para>The password of the synchronization account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ReplicatorPassword")]
        [Validation(Required=false)]
        public string ReplicatorPassword { get; set; }

        /// <summary>
        /// <para>The endpoint of the PostgreSQL source instance or the IP address of the SQL Server source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostgreSQL：pgm-****.pg.rds.aliyuncs.com
        /// SQL Server：10.XX.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceAddress")]
        [Validation(Required=false)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// <para>The category of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>other</b>: Other. (<b>Not supported for SQL Server.</b>)</description></item>
        /// <item><description><b>aliyunRDS</b>: ApsaraDB RDS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunRDS</para>
        /// </summary>
        [NameInMap("SourceCategory")]
        [Validation(Required=false)]
        public string SourceCategory { get; set; }

        /// <summary>
        /// <para>The name of the source instance. This parameter is required when <b>SourceCategory</b> is set to <b>aliyunRDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2zeaaz62s18******</para>
        /// </summary>
        [NameInMap("SourceInstanceName")]
        [Validation(Required=false)]
        public string SourceInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance. This parameter is required when <b>SourceCategory</b> is set to <b>aliyunRDS</b>.</para>
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
        /// <para>The IP address of the SQL Server disaster recovery instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XXX.XX.XXX</para>
        /// </summary>
        [NameInMap("TargetAddress")]
        [Validation(Required=false)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// <para>The ID of a successful dry run task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43994****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The name of the dry run task. You can specify a custom name. If you do not specify this parameter, the system automatically generates a name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zbtest</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

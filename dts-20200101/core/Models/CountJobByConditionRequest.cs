// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CountJobByConditionRequest : TeaModel {
        /// <summary>
        /// <para>The type of the destination database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("DestDbType")]
        [Validation(Required=false)]
        public string DestDbType { get; set; }

        /// <summary>
        /// <para>The ID of the DTS task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pk13r731m****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The type of the DTS task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration task</description></item>
        /// <item><description><b>SYNC</b>: data synchronization task</description></item>
        /// <item><description><b>SUBSCRIBE</b>: change tracking task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The content of the query condition, which corresponds to the value of the JobType parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>One of the query conditions. The ID of the region. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("SrcDbType")]
        [Validation(Required=false)]
        public string SrcDbType { get; set; }

        /// <summary>
        /// <para>The status of the DTS task.</para>
        /// <para>Valid values for a data migration task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is in precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>Migrating</b>: The task is in progress.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>MigrationFailed</b>: The task failed to migrate data.</description></item>
        /// <item><description><b>Finished</b>: The task is complete.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// <para>Valid values for a data synchronization task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is in precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>Initializing</b>: The task is performing initial synchronization.</description></item>
        /// <item><description><b>InitializeFailed</b>: Initial synchronization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: The task is in progress.</description></item>
        /// <item><description><b>Failed</b>: The task failed to synchronize data.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>Modifying</b>: The objects in the task are being modified.</description></item>
        /// <item><description><b>Finished</b>: The task is complete.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// <para>Valid values for a change tracking task:</para>
        /// <list type="bullet">
        /// <item><description><b>NotConfigured</b>: The task is not configured.</description></item>
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is in precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>PreCheckPass</b>: The task passed the precheck.</description></item>
        /// <item><description><b>Starting</b>: The task is being started.</description></item>
        /// <item><description><b>Normal</b>: The task is running as expected.</description></item>
        /// <item><description><b>Retrying</b>: The task is being retried.</description></item>
        /// <item><description><b>Abnormal</b>: The task is not running as expected.</description></item>
        /// <item><description><b>Upgrade</b>: The task is being upgraded.</description></item>
        /// <item><description><b>Locked</b>: The task is locked.</description></item>
        /// <item><description><b>Downgrade</b>: The task is being downgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The content of the query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the task</description></item>
        /// <item><description><b>rds</b>: the ID of the destination instance</description></item>
        /// <item><description><b>instance</b>: the ID of the Data Transmission Service (DTS) instance</description></item>
        /// <item><description><b>srcRds</b>: the ID of the source instance</description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of this parameter corresponds to the value of the <b>JobType</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>name/instance</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

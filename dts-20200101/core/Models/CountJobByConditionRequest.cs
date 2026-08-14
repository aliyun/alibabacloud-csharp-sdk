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
        /// <para>The parent task ID of a distributed synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pk13r731m****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MIGRATION</b>: data migration.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization.</description></item>
        /// <item><description><b>SUBSCRIBE</b>: change tracking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The query value that corresponds to JobType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The region ID used as a filter condition. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the region where the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This is a global parameter and does not need to be passed for this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>资源组ID，全局参数，当前API无需传入。</para>
        /// </summary>
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
        /// <para>The instance status of the DTS instance. Valid values:</para>
        /// <para>Data migration node statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a dry run.</description></item>
        /// <item><description><b>PrecheckFailed</b>: dry run failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: dry run passed.</description></item>
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>Migrating</b>: migrating.</description></item>
        /// <item><description><b>Suspending</b>: paused.</description></item>
        /// <item><description><b>MigrationFailed</b>: migration failed.</description></item>
        /// <item><description><b>Finished</b>: finished.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// <para>Data synchronization node statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a dry run.</description></item>
        /// <item><description><b>PrecheckFailed</b>: dry run failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: dry run passed.</description></item>
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>Initializing</b>: performing initial synchronization.</description></item>
        /// <item><description><b>InitializeFailed</b>: initial synchronization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: synchronizing.</description></item>
        /// <item><description><b>Failed</b>: synchronization failed.</description></item>
        /// <item><description><b>Suspending</b>: paused.</description></item>
        /// <item><description><b>Modifying</b>: modifying sub-objects.</description></item>
        /// <item><description><b>Finished</b>: finished.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// <para>Subscribe node statuses:</para>
        /// <list type="bullet">
        /// <item><description><b>NotConfigured</b>: not configured.</description></item>
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running a dry run.</description></item>
        /// <item><description><b>PrecheckFailed</b>: dry run failed.</description></item>
        /// <item><description><b>PreCheckPass</b>: dry run passed.</description></item>
        /// <item><description><b>Starting</b>: starting.</description></item>
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>Retrying</b>: retrying.</description></item>
        /// <item><description><b>Abnormal</b>: abnormal.</description></item>
        /// <item><description><b>Upgrade</b>: upgrading.</description></item>
        /// <item><description><b>Locked</b>: locked.</description></item>
        /// <item><description><b>Downgrade</b>: downgrading.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: queries by job name.  </description></item>
        /// <item><description><b>rds</b>: queries by destination instance ID.  </description></item>
        /// <item><description><b>instance</b>: queries by DTS instance ID.</description></item>
        /// <item><description><b>srcRds</b>: queries by source instance ID.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter corresponds to the <b>JobType</b> parameter.</para>
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

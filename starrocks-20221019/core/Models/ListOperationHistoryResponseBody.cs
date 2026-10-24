// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ListOperationHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOperationHistoryResponseBodyData> Data { get; set; }
        public class ListOperationHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value after the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FE enable = true</para>
            /// </summary>
            [NameInMap("AfterValue")]
            [Validation(Required=false)]
            public string AfterValue { get; set; }

            /// <summary>
            /// <para>The value before the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FE enable = false</para>
            /// </summary>
            [NameInMap("BeforeValue")]
            [Validation(Required=false)]
            public string BeforeValue { get; set; }

            /// <summary>
            /// <para>The start time of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179008000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The end time of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179008000</para>
            /// </summary>
            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-cd7a3a6f2186d5c9</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The operation details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Insufficient inventory. The operation failed and a refund has been issued</para>
            /// </summary>
            [NameInMap("OperationDetail")]
            [Validation(Required=false)]
            public string OperationDetail { get; set; }

            /// <summary>
            /// <para>The operation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>op-f49743caa809****</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The operation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMPLETED: Completed.</description></item>
            /// <item><description>TERMINATED: Terminated.</description></item>
            /// <item><description>HUMAN_PROCESSING: Pending manual processing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("OperationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>trial_to_official: Upgrades the trial edition to the standard edition.</description></item>
            /// <item><description>upgrade_version: Upgrades the version.</description></item>
            /// <item><description>update_configuration: Updates the configuration.</description></item>
            /// <item><description>update_public_network_status: Updates the public network status.</description></item>
            /// <item><description>create_cluster: Creates a cluster.</description></item>
            /// <item><description>delete_cluster: Deletes a cluster.</description></item>
            /// <item><description>disable_cluster: Stops a cluster.</description></item>
            /// <item><description>enable_cluster: Recovers a cluster.</description></item>
            /// <item><description>restart_cluster: Restarts a cluster.</description></item>
            /// <item><description>migrate_cluster: Migrates a cluster.</description></item>
            /// <item><description>renew_cluster: Renews a cluster.</description></item>
            /// <item><description>modify_charge_type: Changes the billing method.</description></item>
            /// <item><description>UPGRADE: Upgrades a cluster.</description></item>
            /// <item><description>DOWNGRADE: Downgrades a cluster.</description></item>
            /// <item><description>create_node_group: Creates a node group.</description></item>
            /// <item><description>delete_node_group: Deletes a node group.</description></item>
            /// <item><description>disable_node_group: Stops a node group.</description></item>
            /// <item><description>enable_node_group: Recovers a node group.</description></item>
            /// <item><description>sre_operation: Performs O&amp;M on a cluster.</description></item>
            /// <item><description>resource_change: Changes resources.</description></item>
            /// <item><description>disable_postpaid_resource: Disables pay-as-you-go resources.</description></item>
            /// <item><description>enable_postpaid_resource: Recovers pay-as-you-go resources.</description></item>
            /// <item><description>restart_node_group: Restarts a compute group.</description></item>
            /// <item><description>enable_ha_cluster: Enables high availability (HA) to keep the cluster active.</description></item>
            /// <item><description>restart_node: Restarts a node.</description></item>
            /// <item><description>backup: Backs up data.</description></item>
            /// <item><description>delete_backup: Deletes a data backup.</description></item>
            /// <item><description>cancel_backup_task: Cancels a data backup task.</description></item>
            /// <item><description>modify_timezone: Modifies the system time zone.</description></item>
            /// <item><description>restore: Recovers data.</description></item>
            /// <item><description>switch_az: Switches the primary and secondary zones.</description></item>
            /// <item><description>rollback_upgrade_version: Rolls back a version upgrade.</description></item>
            /// <item><description>scale_out_fe: Scales out FE nodes.</description></item>
            /// <item><description>scale_in_fe: Scales in FE nodes.</description></item>
            /// <item><description>upgrade_fe_cu: Upgrades the FE CU specifications.</description></item>
            /// <item><description>downgrade_fe_cu: Decrease the quota of FE CU specifications.</description></item>
            /// <item><description>increase_fe_disk_size: Increases the FE disk size.</description></item>
            /// <item><description>decrease_fe_disk_size: Decreases the FE disk size.</description></item>
            /// <item><description>increase_fe_disk_number: Increases the number of FE disks.</description></item>
            /// <item><description>decrease_fe_disk_number: Decreases the number of FE disks.</description></item>
            /// <item><description>upgrade_fe_disk_performance_level: Upgrades the FE disk performance level (PL).</description></item>
            /// <item><description>downgrade_fe_disk_performance_level: Decrease the quota of the FE disk performance level (PL).</description></item>
            /// <item><description>create_agent: Creates an agent.</description></item>
            /// <item><description>upgrade_agent_cu: Upgrades the agent CU specifications.</description></item>
            /// <item><description>scale_out_be: Scales out BE nodes.</description></item>
            /// <item><description>scale_in_be: Scales in BE nodes.</description></item>
            /// <item><description>upgrade_be_cu: Upgrades the BE CU specifications.</description></item>
            /// <item><description>downgrade_be_cu: Decrease the quota of BE CU specifications.</description></item>
            /// <item><description>increase_be_disk_size: Increases the BE disk size.</description></item>
            /// <item><description>decrease_be_disk_size: Decreases the BE disk size.</description></item>
            /// <item><description>increase_be_disk_number: Increases the number of BE disks.</description></item>
            /// <item><description>decrease_be_disk_number: Decreases the number of BE disks.</description></item>
            /// <item><description>upgrade_be_disk_performance_level: Upgrades the BE disk performance level (PL).</description></item>
            /// <item><description>downgrade_be_disk_performance_level: Decrease the quota of the BE disk performance level (PL).</description></item>
            /// <item><description>upgrade_be_spec_type: Upgrades the BE specification type.</description></item>
            /// <item><description>downgrade_be_spec_type: Decrease the quota of the BE specification type.</description></item>
            /// <item><description>scale_out_cn: Scales out CN nodes.</description></item>
            /// <item><description>scale_in_cn: Scales in CN nodes.</description></item>
            /// <item><description>upgrade_cn_cu: Upgrades the CN CU specifications.</description></item>
            /// <item><description>downgrade_cn_cu: Decrease the quota of CN CU specifications.</description></item>
            /// <item><description>increase_cn_disk_size: Increases the CN disk size.</description></item>
            /// <item><description>decrease_cn_disk_size: Decreases the CN disk size.</description></item>
            /// <item><description>increase_cn_disk_number: Increases the number of CN disks.</description></item>
            /// <item><description>decrease_cn_disk_number: Decreases the number of CN disks.</description></item>
            /// <item><description>upgrade_cn_disk_performance: Upgrades the CN disk performance level (PL).</description></item>
            /// <item><description>downgrade_cn_disk_performance: Decrease the quota of the CN disk performance level (PL).</description></item>
            /// <item><description>upgrade_cn_spec_type: Upgrades the CN specification type.</description></item>
            /// <item><description>downgrade_cn_spec_type: Decrease the quota of the CN specification type.</description></item>
            /// <item><description>elastic_scale_out_cn: Elastically scales out CN nodes.</description></item>
            /// <item><description>elastic_scale_in_cn: Elastically scales in CN nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>upgrade_version</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The operation progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>832</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

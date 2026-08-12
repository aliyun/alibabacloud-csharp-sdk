// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ListOperationHistoryRequest : TeaModel {
        /// <summary>
        /// <para>End time of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742179008000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Operation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op-f49743caa809****</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>Operation status:</para>
        /// <list type="bullet">
        /// <item><description><para>COMPLETED: completed</para>
        /// </description></item>
        /// <item><description><para>TERMINATED: terminated</para>
        /// </description></item>
        /// <item><description><para>HUMAN_PROCESSING: pending manual processing</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("OperationStatus")]
        [Validation(Required=false)]
        public string OperationStatus { get; set; }

        /// <summary>
        /// <para>Operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>trial_to_official: upgrade from Trial Edition to Standard Edition</para>
        /// </description></item>
        /// <item><description><para>upgrade_version: upgrade version</para>
        /// </description></item>
        /// <item><description><para>update_configuration: update configuration</para>
        /// </description></item>
        /// <item><description><para>update_public_network_status: update public network status</para>
        /// </description></item>
        /// <item><description><para>create_cluster: create cluster</para>
        /// </description></item>
        /// <item><description><para>delete_cluster: delete cluster</para>
        /// </description></item>
        /// <item><description><para>disable_cluster: stop cluster</para>
        /// </description></item>
        /// <item><description><para>enable_cluster: resume cluster</para>
        /// </description></item>
        /// <item><description><para>restart_cluster: restart cluster</para>
        /// </description></item>
        /// <item><description><para>migrate_cluster: migrate cluster</para>
        /// </description></item>
        /// <item><description><para>renew_cluster: renew cluster</para>
        /// </description></item>
        /// <item><description><para>modify_charge_type: change billing method</para>
        /// </description></item>
        /// <item><description><para>UPGRADE: upgrade cluster</para>
        /// </description></item>
        /// <item><description><para>DOWNGRADE: downgrade cluster</para>
        /// </description></item>
        /// <item><description><para>create_node_group: create node group</para>
        /// </description></item>
        /// <item><description><para>delete_node_group: delete node group</para>
        /// </description></item>
        /// <item><description><para>disable_node_group: stop node group</para>
        /// </description></item>
        /// <item><description><para>enable_node_group: resume node group</para>
        /// </description></item>
        /// <item><description><para>sre_operation: O\&amp;M cluster</para>
        /// </description></item>
        /// <item><description><para>resource_change: resource change</para>
        /// </description></item>
        /// <item><description><para>disable_postpaid_resource: disable pay-as-you-go resources</para>
        /// </description></item>
        /// <item><description><para>enable_postpaid_resource: enable pay-as-you-go resources</para>
        /// </description></item>
        /// <item><description><para>restart_node_group: restart compute group</para>
        /// </description></item>
        /// <item><description><para>enable_ha_cluster: enable high availability (HA) for cluster</para>
        /// </description></item>
        /// <item><description><para>restart_node: restart node</para>
        /// </description></item>
        /// <item><description><para>backup: data backup</para>
        /// </description></item>
        /// <item><description><para>delete_backup: delete data backup</para>
        /// </description></item>
        /// <item><description><para>cancel_backup_task: cancel data backup</para>
        /// </description></item>
        /// <item><description><para>modify_timezone: modify system time zone</para>
        /// </description></item>
        /// <item><description><para>restore: data restoration</para>
        /// </description></item>
        /// <item><description><para>switch_az: switch primary and secondary zones</para>
        /// </description></item>
        /// <item><description><para>rollback_upgrade_version: roll back version upgrade</para>
        /// </description></item>
        /// <item><description><para>scale_out_fe: scale out FE</para>
        /// </description></item>
        /// <item><description><para>scale_in_fe: scale in FE</para>
        /// </description></item>
        /// <item><description><para>upgrade_fe_cu: upgrade FE CU specification</para>
        /// </description></item>
        /// <item><description><para>downgrade_fe_cu: downgrade FE CU specification</para>
        /// </description></item>
        /// <item><description><para>increase_fe_disk_size: increase FE disk size</para>
        /// </description></item>
        /// <item><description><para>decrease_fe_disk_size: decrease FE disk size</para>
        /// </description></item>
        /// <item><description><para>increase_fe_disk_number: increase FE disk count</para>
        /// </description></item>
        /// <item><description><para>decrease_fe_disk_number: decrease FE disk count</para>
        /// </description></item>
        /// <item><description><para>upgrade_fe_disk_performance_level: upgrade FE disk performance level</para>
        /// </description></item>
        /// <item><description><para>downgrade_fe_disk_performance_level: downgrade FE disk performance level</para>
        /// </description></item>
        /// <item><description><para>create_agent: create Agent</para>
        /// </description></item>
        /// <item><description><para>upgrade_agent_cu: upgrade Agent CU specification</para>
        /// </description></item>
        /// <item><description><para>scale_out_be: scale out BE</para>
        /// </description></item>
        /// <item><description><para>scale_in_be: scale in BE</para>
        /// </description></item>
        /// <item><description><para>upgrade_be_cu: upgrade BE CU specification</para>
        /// </description></item>
        /// <item><description><para>downgrade_be_cu: downgrade BE CU specification</para>
        /// </description></item>
        /// <item><description><para>increase_be_disk_size: increase BE disk size</para>
        /// </description></item>
        /// <item><description><para>decrease_be_disk_size: decrease BE disk size</para>
        /// </description></item>
        /// <item><description><para>increase_be_disk_number: increase BE disk count</para>
        /// </description></item>
        /// <item><description><para>decrease_be_disk_number: decrease BE disk count</para>
        /// </description></item>
        /// <item><description><para>upgrade_be_disk_performance_level: upgrade BE disk performance level</para>
        /// </description></item>
        /// <item><description><para>downgrade_be_disk_performance_level: downgrade BE disk performance level</para>
        /// </description></item>
        /// <item><description><para>upgrade_be_spec_type: upgrade BE specification type</para>
        /// </description></item>
        /// <item><description><para>downgrade_be_spec_type: downgrade BE specification type</para>
        /// </description></item>
        /// <item><description><para>scale_out_cn: scale out CN</para>
        /// </description></item>
        /// <item><description><para>scale_in_cn: scale in CN</para>
        /// </description></item>
        /// <item><description><para>upgrade_cn_cu: upgrade CN CU specification</para>
        /// </description></item>
        /// <item><description><para>downgrade_cn_cu: downgrade CN CU specification</para>
        /// </description></item>
        /// <item><description><para>increase_cn_disk_size: increase CN disk size</para>
        /// </description></item>
        /// <item><description><para>decrease_cn_disk_size: decrease CN disk size</para>
        /// </description></item>
        /// <item><description><para>increase_cn_disk_number: increase CN disk count</para>
        /// </description></item>
        /// <item><description><para>decrease_cn_disk_number: decrease CN disk count</para>
        /// </description></item>
        /// <item><description><para>upgrade_cn_disk_performance: upgrade CN disk performance level</para>
        /// </description></item>
        /// <item><description><para>downgrade_cn_disk_performance: downgrade CN disk performance level</para>
        /// </description></item>
        /// <item><description><para>upgrade_cn_spec_type: upgrade CN specification type</para>
        /// </description></item>
        /// <item><description><para>downgrade_cn_spec_type: downgrade CN specification type</para>
        /// </description></item>
        /// <item><description><para>elastic_scale_out_cn: elastically scale out CN</para>
        /// </description></item>
        /// <item><description><para>elastic_scale_in_cn: elastically scale in CN</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>update_configuration</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>Page number of the current page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page for paged queries. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start time of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742179008000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

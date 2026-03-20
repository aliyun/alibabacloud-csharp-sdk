// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Instance : TeaModel {
        /// <summary>
        /// <para>The current hourly price of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.444</para>
        /// </summary>
        [NameInMap("CurrentAmount")]
        [Validation(Required=false)]
        public float? CurrentAmount { get; set; }

        [NameInMap("Detached")]
        [Validation(Required=false)]
        public bool? Detached { get; set; }

        /// <summary>
        /// <para>The IP address of the instance in the user-created VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("ExternalIP")]
        [Validation(Required=false)]
        public string ExternalIP { get; set; }

        /// <summary>
        /// <para>The port number of the instance in the user-created VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ExternalInstancePort")]
        [Validation(Required=false)]
        public int? ExternalInstancePort { get; set; }

        /// <summary>
        /// <para>The IP address of the host where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.0.XX.XX</para>
        /// </summary>
        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// <para>The name of the host where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>smart-scene-cls-854dbdc99d-****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The internal IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.17.0.17</para>
        /// </summary>
        [NameInMap("InnerIP")]
        [Validation(Required=false)]
        public string InnerIP { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo-5fc8946767-v****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network port of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// <para>The instance specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public bool? IsLatest { get; set; }

        [NameInMap("IsReplica")]
        [Validation(Required=false)]
        public bool? IsReplica { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is isolated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Isolated")]
        [Validation(Required=false)]
        public bool? Isolated { get; set; }

        /// <summary>
        /// <para>The last state of the instance.</para>
        /// </summary>
        [NameInMap("LastState")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> LastState { get; set; }

        /// <summary>
        /// <para>The namespace of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The original hourly price of the spot instance before a discount is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2</para>
        /// </summary>
        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public float? OriginalAmount { get; set; }

        /// <summary>
        /// <para>The number of processes that have started for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadyProcesses")]
        [Validation(Required=false)]
        public int? ReadyProcesses { get; set; }

        /// <summary>
        /// <para>The reason for which the instance is in the current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("ReplicaName")]
        [Validation(Required=false)]
        public string ReplicaName { get; set; }

        /// <summary>
        /// <para>The type of the resource group to which the instance belongs. Valid values: PublicResource and PrivateResource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The number of times for which the instance is restarted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        /// <summary>
        /// <para>The service role of the instance. Valid values: Queue, DataLoader, and Standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The time when the instance was started. This parameter is deprecated. StartTime is used instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T09:46:05Z</para>
        /// </summary>
        [NameInMap("StartAt")]
        [Validation(Required=false)]
        [Obsolete]
        public string StartAt { get; set; }

        /// <summary>
        /// <para>The time when the instance was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T09:46:05Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The current state of the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Terminating</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Unknown</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Pending</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IP address of the host in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("TenantHostIP")]
        [Validation(Required=false)]
        public string TenantHostIP { get; set; }

        /// <summary>
        /// <para>The IP address of the instance in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("TenantInstanceIP")]
        [Validation(Required=false)]
        public string TenantInstanceIP { get; set; }

        /// <summary>
        /// <para>The total number of processes that the instance contains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalProcesses")]
        [Validation(Required=false)]
        public int? TotalProcesses { get; set; }

        /// <summary>
        /// <para>The zone to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-a</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}

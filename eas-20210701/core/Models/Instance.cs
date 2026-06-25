// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Instance : TeaModel {
        /// <summary>
        /// <para>The creation time of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T09:46:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The current hourly price of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.444</para>
        /// </summary>
        [NameInMap("CurrentAmount")]
        [Validation(Required=false)]
        public float? CurrentAmount { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is removed from active service rotation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Detached")]
        [Validation(Required=false)]
        public bool? Detached { get; set; }

        /// <summary>
        /// <para>The IP address of the instance in your VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("ExternalIP")]
        [Validation(Required=false)]
        public string ExternalIP { get; set; }

        /// <summary>
        /// <para>The port number of the instance in your VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ExternalInstancePort")]
        [Validation(Required=false)]
        public int? ExternalInstancePort { get; set; }

        /// <summary>
        /// <para>The IP address of the instance\&quot;s host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.0.XX.XX</para>
        /// </summary>
        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        /// <summary>
        /// <para>The name of the instance\&quot;s host.</para>
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
        /// <para>The name of the instance.</para>
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
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is running the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
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
        /// <para>Indicates whether the instance accepts traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Isolated")]
        [Validation(Required=false)]
        public bool? Isolated { get; set; }

        /// <summary>
        /// <para>The status of the instance when it last exited.</para>
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
        /// <para>The original price of the spot instance before discounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2</para>
        /// </summary>
        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public float? OriginalAmount { get; set; }

        /// <summary>
        /// <para>The number of processes that have started in the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadyProcesses")]
        [Validation(Required=false)]
        public int? ReadyProcesses { get; set; }

        /// <summary>
        /// <para>The identifier for the current status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The name of the replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xwq-sglang-dist-7dff0</para>
        /// </summary>
        [NameInMap("ReplicaName")]
        [Validation(Required=false)]
        public string ReplicaName { get; set; }

        /// <summary>
        /// <para>The type of the resource group to which the instance belongs. Valid values include PublicResource and PrivateResource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The number of times the instance has been restarted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        /// <summary>
        /// <para>The server role of the instance. Valid values include Queue, DataLoader, and Standard.</para>
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
        /// <para>The start time of the instance. (Deprecated. Use StartTime instead.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T09:46:05Z</para>
        /// </summary>
        [NameInMap("StartAt")]
        [Validation(Required=false)]
        [Obsolete]
        public string StartAt { get; set; }

        /// <summary>
        /// <para>The start time of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T09:46:05Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IP address of the host in the dedicated network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("TenantHostIP")]
        [Validation(Required=false)]
        public string TenantHostIP { get; set; }

        /// <summary>
        /// <para>The IP address of the instance in the dedicated network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.xx.xx</para>
        /// </summary>
        [NameInMap("TenantInstanceIP")]
        [Validation(Required=false)]
        public string TenantInstanceIP { get; set; }

        /// <summary>
        /// <para>The total number of processes for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalProcesses")]
        [Validation(Required=false)]
        public int? TotalProcesses { get; set; }

        /// <summary>
        /// <para>The zone where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-a</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}

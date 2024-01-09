// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeServerResponseBody : TeaModel {
        [NameInMap("AgentPort")]
        [Validation(Required=false)]
        public int? AgentPort { get; set; }

        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        [NameInMap("Consistent")]
        [Validation(Required=false)]
        public bool? Consistent { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("CrashConsistentPointPolicy")]
        [Validation(Required=false)]
        public string CrashConsistentPointPolicy { get; set; }

        [NameInMap("Disks")]
        [Validation(Required=false)]
        public string Disks { get; set; }

        [NameInMap("Errno")]
        [Validation(Required=false)]
        public string Errno { get; set; }

        [NameInMap("FullSyncCurrentSize")]
        [Validation(Required=false)]
        public long? FullSyncCurrentSize { get; set; }

        [NameInMap("FullSyncProgress")]
        [Validation(Required=false)]
        public int? FullSyncProgress { get; set; }

        [NameInMap("FullSyncStartTime")]
        [Validation(Required=false)]
        public long? FullSyncStartTime { get; set; }

        [NameInMap("FullSyncTotalSize")]
        [Validation(Required=false)]
        public long? FullSyncTotalSize { get; set; }

        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("IncrementalSyncStartTime")]
        [Validation(Required=false)]
        public long? IncrementalSyncStartTime { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("LatestRecoveryPointTime")]
        [Validation(Required=false)]
        public string LatestRecoveryPointTime { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Operations")]
        [Validation(Required=false)]
        public string Operations { get; set; }

        [NameInMap("OriginalInstanceId")]
        [Validation(Required=false)]
        public string OriginalInstanceId { get; set; }

        [NameInMap("OsDetail")]
        [Validation(Required=false)]
        public string OsDetail { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("PrimarySiteId")]
        [Validation(Required=false)]
        public string PrimarySiteId { get; set; }

        [NameInMap("RecoveredInstanceId")]
        [Validation(Required=false)]
        public string RecoveredInstanceId { get; set; }

        [NameInMap("RecoveredIpAddress")]
        [Validation(Required=false)]
        public string RecoveredIpAddress { get; set; }

        [NameInMap("RecoveryCpu")]
        [Validation(Required=false)]
        public int? RecoveryCpu { get; set; }

        [NameInMap("RecoveryEssdPerformanceLevel")]
        [Validation(Required=false)]
        public string RecoveryEssdPerformanceLevel { get; set; }

        [NameInMap("RecoveryInstanceName")]
        [Validation(Required=false)]
        public string RecoveryInstanceName { get; set; }

        [NameInMap("RecoveryInstanceType")]
        [Validation(Required=false)]
        public string RecoveryInstanceType { get; set; }

        [NameInMap("RecoveryIpAddress")]
        [Validation(Required=false)]
        public string RecoveryIpAddress { get; set; }

        [NameInMap("RecoveryMemory")]
        [Validation(Required=false)]
        public long? RecoveryMemory { get; set; }

        [NameInMap("RecoveryNetwork")]
        [Validation(Required=false)]
        public string RecoveryNetwork { get; set; }

        [NameInMap("RecoveryPostScriptContent")]
        [Validation(Required=false)]
        public string RecoveryPostScriptContent { get; set; }

        [NameInMap("RecoveryPostScriptType")]
        [Validation(Required=false)]
        public string RecoveryPostScriptType { get; set; }

        [NameInMap("RecoveryReserveIp")]
        [Validation(Required=false)]
        public bool? RecoveryReserveIp { get; set; }

        [NameInMap("RecoveryUseDhcp")]
        [Validation(Required=false)]
        public bool? RecoveryUseDhcp { get; set; }

        [NameInMap("RecoveryUseEssd")]
        [Validation(Required=false)]
        public bool? RecoveryUseEssd { get; set; }

        [NameInMap("RecoveryUseSsd")]
        [Validation(Required=false)]
        public bool? RecoveryUseSsd { get; set; }

        [NameInMap("ReplicationInfrastructureId")]
        [Validation(Required=false)]
        public string ReplicationInfrastructureId { get; set; }

        [NameInMap("ReplicationInfrastructureType")]
        [Validation(Required=false)]
        public string ReplicationInfrastructureType { get; set; }

        [NameInMap("ReplicationNetwork")]
        [Validation(Required=false)]
        public string ReplicationNetwork { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("ReplicationUseDhcp")]
        [Validation(Required=false)]
        public bool? ReplicationUseDhcp { get; set; }

        [NameInMap("ReplicationUseEssd")]
        [Validation(Required=false)]
        public bool? ReplicationUseEssd { get; set; }

        [NameInMap("ReplicationUseOriginalInstance")]
        [Validation(Required=false)]
        public bool? ReplicationUseOriginalInstance { get; set; }

        [NameInMap("ReplicationUseSsd")]
        [Validation(Required=false)]
        public bool? ReplicationUseSsd { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rpo")]
        [Validation(Required=false)]
        public int? Rpo { get; set; }

        [NameInMap("SecondarySiteId")]
        [Validation(Required=false)]
        public string SecondarySiteId { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        [NameInMap("SourceGatewayVersion")]
        [Validation(Required=false)]
        public string SourceGatewayVersion { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TargetGatewayVersion")]
        [Validation(Required=false)]
        public string TargetGatewayVersion { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TestFailoverStatus")]
        [Validation(Required=false)]
        public string TestFailoverStatus { get; set; }

        [NameInMap("TestRecoveredInstanceId")]
        [Validation(Required=false)]
        public string TestRecoveredInstanceId { get; set; }

        [NameInMap("TestRecoveredInstanceName")]
        [Validation(Required=false)]
        public string TestRecoveredInstanceName { get; set; }

        [NameInMap("TestRecoveredIpAddress")]
        [Validation(Required=false)]
        public string TestRecoveredIpAddress { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDifyInstanceRequest : TeaModel {
        [NameInMap("AdbpgInstanceMode")]
        [Validation(Required=false)]
        public string AdbpgInstanceMode { get; set; }

        [NameInMap("BackupVSwitchId")]
        [Validation(Required=false)]
        public string BackupVSwitchId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataRegion")]
        [Validation(Required=false)]
        public string DataRegion { get; set; }

        [NameInMap("DatabaseOption")]
        [Validation(Required=false)]
        public string DatabaseOption { get; set; }

        [NameInMap("DbEngineType")]
        [Validation(Required=false)]
        public string DbEngineType { get; set; }

        [NameInMap("DbEngineVersion")]
        [Validation(Required=false)]
        public string DbEngineVersion { get; set; }

        [NameInMap("DbInstanceAccount")]
        [Validation(Required=false)]
        public string DbInstanceAccount { get; set; }

        [NameInMap("DbInstanceCategory")]
        [Validation(Required=false)]
        public string DbInstanceCategory { get; set; }

        [NameInMap("DbInstanceClass")]
        [Validation(Required=false)]
        public string DbInstanceClass { get; set; }

        [NameInMap("DbInstancePassword")]
        [Validation(Required=false)]
        public string DbInstancePassword { get; set; }

        [NameInMap("DbResourceId")]
        [Validation(Required=false)]
        public int? DbResourceId { get; set; }

        [NameInMap("DbStorageSize")]
        [Validation(Required=false)]
        public string DbStorageSize { get; set; }

        [NameInMap("DbStorageType")]
        [Validation(Required=false)]
        public string DbStorageType { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Community</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        [NameInMap("EnableExtraEndpoint")]
        [Validation(Required=false)]
        public bool? EnableExtraEndpoint { get; set; }

        [NameInMap("GpuNodeSpec")]
        [Validation(Required=false)]
        public string GpuNodeSpec { get; set; }

        [NameInMap("KvStoreAccount")]
        [Validation(Required=false)]
        public string KvStoreAccount { get; set; }

        [NameInMap("KvStoreEngineVersion")]
        [Validation(Required=false)]
        public string KvStoreEngineVersion { get; set; }

        [NameInMap("KvStoreInstanceClass")]
        [Validation(Required=false)]
        public string KvStoreInstanceClass { get; set; }

        [NameInMap("KvStoreNodeType")]
        [Validation(Required=false)]
        public string KvStoreNodeType { get; set; }

        [NameInMap("KvStoreOption")]
        [Validation(Required=false)]
        public string KvStoreOption { get; set; }

        [NameInMap("KvStorePassword")]
        [Validation(Required=false)]
        public string KvStorePassword { get; set; }

        [NameInMap("KvStoreResourceId")]
        [Validation(Required=false)]
        public int? KvStoreResourceId { get; set; }

        [NameInMap("KvStoreType")]
        [Validation(Required=false)]
        public string KvStoreType { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("ModelOption")]
        [Validation(Required=false)]
        public string ModelOption { get; set; }

        [NameInMap("NatGatewayOption")]
        [Validation(Required=false)]
        public string NatGatewayOption { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public int? OssResourceId { get; set; }

        [NameInMap("PayPeriod")]
        [Validation(Required=false)]
        public int? PayPeriod { get; set; }

        [NameInMap("PayPeriodType")]
        [Validation(Required=false)]
        public string PayPeriodType { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public string ResourceQuota { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public int? SegNodeNum { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VectordbAccount")]
        [Validation(Required=false)]
        public string VectordbAccount { get; set; }

        [NameInMap("VectordbCategory")]
        [Validation(Required=false)]
        public string VectordbCategory { get; set; }

        [NameInMap("VectordbEngineVersion")]
        [Validation(Required=false)]
        public string VectordbEngineVersion { get; set; }

        [NameInMap("VectordbInstanceSpec")]
        [Validation(Required=false)]
        public string VectordbInstanceSpec { get; set; }

        [NameInMap("VectordbOption")]
        [Validation(Required=false)]
        public string VectordbOption { get; set; }

        [NameInMap("VectordbPassword")]
        [Validation(Required=false)]
        public string VectordbPassword { get; set; }

        [NameInMap("VectordbResourceId")]
        [Validation(Required=false)]
        public int? VectordbResourceId { get; set; }

        [NameInMap("VectordbStorageSize")]
        [Validation(Required=false)]
        public string VectordbStorageSize { get; set; }

        [NameInMap("VectordbStorageType")]
        [Validation(Required=false)]
        public string VectordbStorageType { get; set; }

        [NameInMap("VectordbType")]
        [Validation(Required=false)]
        public string VectordbType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("WorkspaceDescription")]
        [Validation(Required=false)]
        public string WorkspaceDescription { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        [NameInMap("WorkspaceOption")]
        [Validation(Required=false)]
        public string WorkspaceOption { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

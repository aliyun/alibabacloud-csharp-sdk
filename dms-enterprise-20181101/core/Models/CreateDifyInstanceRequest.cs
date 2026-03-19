// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDifyInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("AdbpgInstanceMode")]
        [Validation(Required=false)]
        public string AdbpgInstanceMode { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-j6cq3nmsk8qcamo2rc6yc</para>
        /// </summary>
        [NameInMap("BackupVSwitchId")]
        [Validation(Required=false)]
        public string BackupVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DataRegion")]
        [Validation(Required=false)]
        public string DataRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateNewInstance</para>
        /// </summary>
        [NameInMap("DatabaseOption")]
        [Validation(Required=false)]
        public string DatabaseOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("DbEngineType")]
        [Validation(Required=false)]
        public string DbEngineType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14.0</para>
        /// </summary>
        [NameInMap("DbEngineVersion")]
        [Validation(Required=false)]
        public string DbEngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dify_user</para>
        /// </summary>
        [NameInMap("DbInstanceAccount")]
        [Validation(Required=false)]
        public string DbInstanceAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1c4g</para>
        /// </summary>
        [NameInMap("DbInstanceCategory")]
        [Validation(Required=false)]
        public string DbInstanceCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pg.n2.2c.1m</para>
        /// </summary>
        [NameInMap("DbInstanceClass")]
        [Validation(Required=false)]
        public string DbInstanceClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("DbInstancePassword")]
        [Validation(Required=false)]
        public string DbInstancePassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2764278</para>
        /// </summary>
        [NameInMap("DbResourceId")]
        [Validation(Required=false)]
        public int? DbResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DbStorageSize")]
        [Validation(Required=false)]
        public string DbStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>general_essd</para>
        /// </summary>
        [NameInMap("DbStorageType")]
        [Validation(Required=false)]
        public string DbStorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Dify Instance</para>
        /// </summary>
        [NameInMap("DifyInstanceName")]
        [Validation(Required=false)]
        public string DifyInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableExtraEndpoint")]
        [Validation(Required=false)]
        public bool? EnableExtraEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16C62G.1T4</para>
        /// </summary>
        [NameInMap("GpuNodeSpec")]
        [Validation(Required=false)]
        public string GpuNodeSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dify_user</para>
        /// </summary>
        [NameInMap("KvStoreAccount")]
        [Validation(Required=false)]
        public string KvStoreAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.0</para>
        /// </summary>
        [NameInMap("KvStoreEngineVersion")]
        [Validation(Required=false)]
        public string KvStoreEngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>redis.master.stand.default</para>
        /// </summary>
        [NameInMap("KvStoreInstanceClass")]
        [Validation(Required=false)]
        public string KvStoreInstanceClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MASTER_SLAVE</para>
        /// </summary>
        [NameInMap("KvStoreNodeType")]
        [Validation(Required=false)]
        public string KvStoreNodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateNewInstance</para>
        /// </summary>
        [NameInMap("KvStoreOption")]
        [Validation(Required=false)]
        public string KvStoreOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("KvStorePassword")]
        [Validation(Required=false)]
        public string KvStorePassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2829493</para>
        /// </summary>
        [NameInMap("KvStoreResourceId")]
        [Validation(Required=false)]
        public int? KvStoreResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REDIS</para>
        /// </summary>
        [NameInMap("KvStoreType")]
        [Validation(Required=false)]
        public string KvStoreType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.6.x</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen3-4B</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("NatGatewayOption")]
        [Validation(Required=false)]
        public string NatGatewayOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyIntranet")]
        [Validation(Required=false)]
        public bool? OnlyIntranet { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2764233</para>
        /// </summary>
        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public int? OssResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayPeriod")]
        [Validation(Required=false)]
        public int? PayPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PayPeriodType")]
        [Validation(Required=false)]
        public string PayPeriodType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CU</para>
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public string ResourceQuota { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-2ze6dig8uby0a3zt4a0h</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pl0</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public int? SegNodeNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{key:,value:}]</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDifyInstanceRequestTag> Tag { get; set; }
        public class CreateDifyInstanceRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1i05wremlxcy8z5e2im</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dify_user</para>
        /// </summary>
        [NameInMap("VectordbAccount")]
        [Validation(Required=false)]
        public string VectordbAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>adbpg</para>
        /// </summary>
        [NameInMap("VectordbCategory")]
        [Validation(Required=false)]
        public string VectordbCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.0</para>
        /// </summary>
        [NameInMap("VectordbEngineVersion")]
        [Validation(Required=false)]
        public string VectordbEngineVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C16G</para>
        /// </summary>
        [NameInMap("VectordbInstanceSpec")]
        [Validation(Required=false)]
        public string VectordbInstanceSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateNewInstance</para>
        /// </summary>
        [NameInMap("VectordbOption")]
        [Validation(Required=false)]
        public string VectordbOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("VectordbPassword")]
        [Validation(Required=false)]
        public string VectordbPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2798885</para>
        /// </summary>
        [NameInMap("VectordbResourceId")]
        [Validation(Required=false)]
        public int? VectordbResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("VectordbStorageSize")]
        [Validation(Required=false)]
        public string VectordbStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("VectordbStorageType")]
        [Validation(Required=false)]
        public string VectordbStorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>createnew</para>
        /// </summary>
        [NameInMap("VectordbType")]
        [Validation(Required=false)]
        public string VectordbType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-k1a8ha7m1atealnysybeu</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is my workspace</para>
        /// </summary>
        [NameInMap("WorkspaceDescription")]
        [Validation(Required=false)]
        public string WorkspaceDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8640136033018977</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dify_default</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UseExistingInstance</para>
        /// </summary>
        [NameInMap("WorkspaceOption")]
        [Validation(Required=false)]
        public string WorkspaceOption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

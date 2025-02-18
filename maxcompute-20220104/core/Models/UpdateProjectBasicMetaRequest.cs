// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateProjectBasicMetaRequest : TeaModel {
        /// <summary>
        /// <para>The project description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BI_Analysis</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The basic properties of the project.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public UpdateProjectBasicMetaRequestProperties Properties { get; set; }
        public class UpdateProjectBasicMetaRequestProperties : TeaModel {
            /// <summary>
            /// <para>Indicates whether a full table scan is allowed in the project. A full table scan occupies a large number of resources, which reduces data processing efficiency. By default, the full table scan feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowFullScan")]
            [Validation(Required=false)]
            public bool? AllowFullScan { get; set; }

            /// <summary>
            /// <para>Indicates whether the DECIMAL type of the MaxCompute V2.0 data type edition is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableDecimal2")]
            [Validation(Required=false)]
            public bool? EnableDecimal2 { get; set; }

            /// <summary>
            /// <para>Indicates whether the routing of the Tunnel resource group is enabled.</para>
            /// <list type="bullet">
            /// <item><description>true: The data transfer tasks that are submitted by the project by default use the Tunnel resource group that is bound to the project.</description></item>
            /// <item><description>false: The data transfer tasks that are submitted by the project by default use the Tunnel shared resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableTunnelQuotaRoute")]
            [Validation(Required=false)]
            public bool? EnableTunnelQuotaRoute { get; set; }

            /// <summary>
            /// <para>The storage encryption properties.</para>
            /// </summary>
            [NameInMap("encryption")]
            [Validation(Required=false)]
            public UpdateProjectBasicMetaRequestPropertiesEncryption Encryption { get; set; }
            public class UpdateProjectBasicMetaRequestPropertiesEncryption : TeaModel {
                /// <summary>
                /// <para>The data encryption algorithm that is supported by the key. Valid values: AES256, AESCTR, and RC4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AES256</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                /// <summary>
                /// <para>Indicates whether the data encryption feature needs to be enabled for the project. For more information about data encryption, see
                /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/security-and-compliance/storage-encryption">Storage Encryption</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage Encryption</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The type of key that is used for data encryption. You can select MaxCompute Default Key or Bring Your Own Key (BYOK) as the key type. If you select MaxCompute Default Key, the default key that is created by MaxCompute is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The retention period for backup data. Unit: days. During the retention period, you can restore data of the version in use to the backup data of any version. Valid values: [0,30]. Default value: 1. The value 0 indicates that the backup feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retentionDays")]
            [Validation(Required=false)]
            public long? RetentionDays { get; set; }

            /// <summary>
            /// <para>The maximum consumption threshold of a single SQL statement. Formula: Amount of scanned data (GB) × Complexity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("sqlMeteringMax")]
            [Validation(Required=false)]
            public string SqlMeteringMax { get; set; }

            /// <summary>
            /// <para>The table lifecycle properties.</para>
            /// </summary>
            [NameInMap("tableLifecycle")]
            [Validation(Required=false)]
            public UpdateProjectBasicMetaRequestPropertiesTableLifecycle TableLifecycle { get; set; }
            public class UpdateProjectBasicMetaRequestPropertiesTableLifecycle : TeaModel {
                /// <summary>
                /// <para>The lifecycle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><em>mandatory</em>: The lifecycle clause is required in a table creation statement.</description></item>
                /// <item><description><em>optional</em>: The lifecycle clause is optional in a table creation statement. If you do not configure a lifecycle for a table, the table does not expire.</description></item>
                /// <item><description><em>inherit</em>: If you do not configure a lifecycle for a table when you create the table, the value of the odps.table.lifecycle.value parameter is used as the table lifecycle by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>optional</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The table lifecycle. Unit: days. Valid values: 1 to 37231. Default value: 37231.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37231</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time zone that is used by your project. The time zone is the same as the time zone specified by <c>odps.sql.timezone</c> .</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/overview-of-dts">Data Transmission Service</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Data Transmission Service</a> resource group that is bound to the project.</para>
            /// <list type="bullet">
            /// <item><description>Default resource group: The Tunnel shared resource group is used. You cannot use the subscription-based Tunnel resource group for the project. The default resource group is automatically used by the Tunnel service of your project, regardless of the parameter setting.</description></item>
            /// <item><description>Subscription-based Tunnel resource group: You can use the subscription-based Tunnel resource group for the project.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("tunnelQuota")]
            [Validation(Required=false)]
            public string TunnelQuota { get; set; }

            /// <summary>
            /// <para>The data type edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><em>1</em>: MaxCompute V1.0 data type edition</description></item>
            /// <item><description><em>2</em>: MaxCompute V2.0 data type edition</description></item>
            /// <item><description><em>hive</em>: Hive-compatible data type edition
            /// For more information about the differences among the three data type editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/data-type-editions">Data Type Versions</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data Type Versions</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("typeSystem")]
            [Validation(Required=false)]
            public string TypeSystem { get; set; }

        }

    }

}

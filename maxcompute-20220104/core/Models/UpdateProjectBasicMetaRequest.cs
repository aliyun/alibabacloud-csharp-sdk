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
            /// <para>Specifies whether to allow full table scans in the project. Full table scans consume a large amount of resources. To improve processing efficiency, this feature is disabled by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowFullScan")]
            [Validation(Required=false)]
            public bool? AllowFullScan { get; set; }

            [NameInMap("enableDataMasking")]
            [Validation(Required=false)]
            public bool? EnableDataMasking { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Decimal data type of MaxCompute 2.0 for the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableDecimal2")]
            [Validation(Required=false)]
            public bool? EnableDecimal2 { get; set; }

            [NameInMap("enableDr")]
            [Validation(Required=false)]
            public bool? EnableDr { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable resource group routing for the data transfer service.</para>
            /// <list type="bullet">
            /// <item><description>true: The data transfer tasks submitted by this project use the bound data transfer service resource group by default.</description></item>
            /// <item><description>false: The data transfer tasks submitted by this project use the shared data transfer service resource group by default.</description></item>
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
                /// <para>The data encryption algorithm. The supported encryption algorithms include AES256, AESCTR, and RC4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AES256</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable data encryption for the project. For more information about data encryption, see
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
                /// <para>The type of key used for data encryption, including the default key (MaxCompute Default Key) and Bring Your Own Key (BYOK). The default key (MaxCompute Default Key) is a default key created internally by MaxCompute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The number of days to retain backup data. During this period, you can restore the current version to any backed-up data version.
            /// Valid values: [0, 30]. Default value: 1. A value of 0 indicates that the backup feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retentionDays")]
            [Validation(Required=false)]
            public long? RetentionDays { get; set; }

            /// <summary>
            /// <para>The maximum threshold for a single SQL statement consumption.
            /// Unit: scan volume (GB) × complexity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("sqlMeteringMax")]
            [Validation(Required=false)]
            public string SqlMeteringMax { get; set; }

            /// <summary>
            /// <para>The lifecycle properties of tables.</para>
            /// </summary>
            [NameInMap("tableLifecycle")]
            [Validation(Required=false)]
            public UpdateProjectBasicMetaRequestPropertiesTableLifecycle TableLifecycle { get; set; }
            public class UpdateProjectBasicMetaRequestPropertiesTableLifecycle : TeaModel {
                /// <summary>
                /// <para>The lifecycle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mandatory</b>: The Lifecycle clause is required. You must configure the lifecycle of a table.</description></item>
                /// <item><description><b>optional</b>: The Lifecycle clause is optional when you create a table. If the lifecycle of a table is not configured, the table is permanently valid.</description></item>
                /// <item><description><b>inherit</b>: If the lifecycle of a table is not configured when you create a table, the lifecycle of the table is set to the value of odps.table.lifecycle.value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>optional</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The lifecycle of a table. Unit: days. Valid values: 1 to 37231. Default value: 37231.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37231</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time zone of the project, which is the <c>odps.sql.timezone</c> property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/overview-of-dts">Data Transfer Service</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Data Transfer Service</a> resource group bound to the project.</para>
            /// <list type="bullet">
            /// <item><description><para>Default (shared data transfer service resource group): The project is not allowed to use subscription-based data transfer service resource groups. Regardless of the default data transfer service resource group setting, data transfer tasks submitted by this project automatically use the Default resource group.</para>
            /// </description></item>
            /// <item><description><para>Subscription-based data transfer service resource group: The project is allowed to use subscription-based data transfer service resource groups.</para>
            /// </description></item>
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
            /// <item><description><b>1</b>: Edition 1.0</description></item>
            /// <item><description><b>2</b>: Edition 2.0</description></item>
            /// <item><description><b>hive</b>: Hive-compatible type</description></item>
            /// </list>
            /// <para>For more information about the differences among the three data type editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/data-type-editions">Data Type Editions</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data Type Editions</a>.</para>
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

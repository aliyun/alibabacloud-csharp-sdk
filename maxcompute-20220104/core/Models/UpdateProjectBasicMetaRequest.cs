// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateProjectBasicMetaRequest : TeaModel {
        /// <summary>
        /// <para>The description of the project.</para>
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
            /// <para>Specifies whether to allow full table scans in the project. A full table scan consumes a large amount of resources. To improve processing efficiency, this feature is disabled by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowFullScan")]
            [Validation(Required=false)]
            public bool? AllowFullScan { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Decimal data type of MaxCompute V2.0 for the project.</para>
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
            /// <para>Specifies whether to enable resource group-based routing for Data Transmission Service.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Data transmission tasks submitted in the project use the attached Data Transmission Service resource group by default.</para>
            /// </description></item>
            /// <item><description><para>false: Data transmission tasks submitted in the project use the shared Data Transmission Service resource group by default.</para>
            /// </description></item>
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
                /// <para>The encryption algorithm. The key supports algorithms such as AES256, AESCTR, and RC4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AES256</para>
                /// </summary>
                [NameInMap("algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable data encryption for the project. For more information about data encryption, see
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The type of key used for data encryption. This can be the default MaxCompute key or a Bring-Your-Own-Key (BYOK). The default MaxCompute key is created within MaxCompute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The number of days to retain backup data. During this period, you can restore the current version to any backup version.
            /// The value must be an integer from 0 to 30. The default value is 1. A value of 0 disables the backup feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retentionDays")]
            [Validation(Required=false)]
            public long? RetentionDays { get; set; }

            /// <summary>
            /// <para>The maximum consumption threshold for a single SQL job.
            /// Unit: Scanned data (GB) × Complexity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("sqlMeteringMax")]
            [Validation(Required=false)]
            public string SqlMeteringMax { get; set; }

            /// <summary>
            /// <para>The lifecycle properties of the table.</para>
            /// </summary>
            [NameInMap("tableLifecycle")]
            [Validation(Required=false)]
            public UpdateProjectBasicMetaRequestPropertiesTableLifecycle TableLifecycle { get; set; }
            public class UpdateProjectBasicMetaRequestPropertiesTableLifecycle : TeaModel {
                /// <summary>
                /// <para>The lifecycle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>mandatory</b>: The Lifecycle clause is required. You must set a lifecycle for the table.</para>
                /// </description></item>
                /// <item><description><para><b>optional</b>: The Lifecycle clause is optional when you create a table. If you do not set a lifecycle for the table, the table never expires.</para>
                /// </description></item>
                /// <item><description><para><b>inherit</b>: If you do not set a lifecycle for the table when you create it, the lifecycle of the table is the value of odps.table.lifecycle.value.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>optional</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The lifecycle of the table in days. The value must be an integer from 1 to 37231. The default value is 37231.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37231</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time zone of the project. This is the <c>odps.sql.timezone</c> property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Data Transmission Service</a> resource group attached to the project.</para>
            /// <list type="bullet">
            /// <item><description><para>Default (shared Data Transmission Service resource group): The project is not allowed to use a subscription Data Transmission Service resource group. Regardless of the value of the default Data Transmission Service resource group, data transmission tasks submitted in the project automatically use the Default resource group.</para>
            /// </description></item>
            /// <item><description><para>Subscription Data Transmission Service resource group: The project is allowed to use a subscription Data Transmission Service resource group.</para>
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
            /// <item><description><para><b>1</b>: Edition 1.0</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Edition 2.0</para>
            /// </description></item>
            /// <item><description><para><b>hive</b>: Hive-compatible edition</para>
            /// </description></item>
            /// </list>
            /// <para>For more information about the differences between the data type editions, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data type editions</a>.</para>
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

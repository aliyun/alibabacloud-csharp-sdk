// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class GetLindormInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The 16-character AliUid of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164901546557****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The cause of the creation failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource is not enough</para>
            /// </summary>
            [NameInMap("CreateErrorCode")]
            [Validation(Required=false)]
            public string CreateErrorCode { get; set; }

            /// <summary>
            /// <para>The number of milliseconds between the instance creation time and 00:00:00 on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631772842000</para>
            /// </summary>
            [NameInMap("CreateMilliseconds")]
            [Validation(Required=false)]
            public long? CreateMilliseconds { get; set; }

            /// <summary>
            /// <para>The creation time of the instance. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-16 14:13:13</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the column store engine is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableColumn")]
            [Validation(Required=false)]
            public bool? EnableColumn { get; set; }

            /// <summary>
            /// <para>Indicates whether the compute engine is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCompute")]
            [Validation(Required=false)]
            public bool? EnableCompute { get; set; }

            /// <summary>
            /// <para>Indicates whether Lindorm Tunnel Service (LTS) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableLts")]
            [Validation(Required=false)]
            public bool? EnableLts { get; set; }

            /// <summary>
            /// <para>Indicates whether the message engine is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableMessage")]
            [Validation(Required=false)]
            public bool? EnableMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether LindormTable 3.0 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRow")]
            [Validation(Required=false)]
            public bool? EnableRow { get; set; }

            /// <summary>
            /// <para>Indicates whether the streaming engine is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The streaming engine is enabled.</description></item>
            /// <item><description><b>false</b>: The streaming engine is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStream")]
            [Validation(Required=false)]
            public bool? EnableStream { get; set; }

            /// <summary>
            /// <para>Indicates whether the vector engine is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVector")]
            [Validation(Required=false)]
            public bool? EnableVector { get; set; }

            /// <summary>
            /// <para>The engine types supported by the instance. The return value is the sum of the following engine type values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Search engine</description></item>
            /// <item><description><b>2</b>: LindormTSDB</description></item>
            /// <item><description><b>4</b>: LindormTable</description></item>
            /// <item><description><b>8</b>: File engine</description></item>
            /// </list>
            /// <remarks>
            /// <para>For example, if the value is 15 (15 = 8 + 4 + 2 + 1), the instance supports the search engine, LindormTSDB, LindormTable, and file engine. If the value is 6 (6 = 4 + 2), the instance supports LindormTSDB and LindormTable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the billing method of the instance is subscription.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The number of milliseconds between the time when the instance expires and 00:00:00 on January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650902400000</para>
            /// </summary>
            [NameInMap("ExpiredMilliseconds")]
            [Validation(Required=false)]
            public long? ExpiredMilliseconds { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-bp17pwu1541ia****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATING</b>: Creating.</description></item>
            /// <item><description><b>ACTIVATION</b>: Running.</description></item>
            /// <item><description><b>COLD_EXPANDING</b>: Performing storage expansion for storage-optimized cloud storage.</description></item>
            /// <item><description><b>MINOR_VERSION_TRANSING</b>: Upgrading the minor version.</description></item>
            /// <item><description><b>RESIZING</b>: Scaling out nodes.</description></item>
            /// <item><description><b>SHRINKING</b>: Scaling in nodes.</description></item>
            /// <item><description><b>CLASS_CHANGING</b>: Upgrading or downgrading specifications.</description></item>
            /// <item><description><b>SSL_SWITCHING</b>: Modifying SSL configurations.</description></item>
            /// <item><description><b>CDC_OPENING</b>: Enabling the data subscription feature.</description></item>
            /// <item><description><b>TRANSFER</b>: Migrating data.</description></item>
            /// <item><description><b>DATABASE_TRANSFER</b>: Migrating data to the database.</description></item>
            /// <item><description><b>GUARD_CREATING</b>: Creating a disaster recovery instance.</description></item>
            /// <item><description><b>BACKUP_RECOVERING</b>: Restoring from a backup.</description></item>
            /// <item><description><b>DATABASE_IMPORTING</b>: Importing data.</description></item>
            /// <item><description><b>NET_MODIFYING</b>: Modifying network configurations.</description></item>
            /// <item><description><b>NET_SWITCHING</b>: Switching between the internal network and the Internet.</description></item>
            /// <item><description><b>NET_CREATING</b>: Creating a network connection.</description></item>
            /// <item><description><b>NET_DELETING</b>: Performing a delete operation on the network connection.</description></item>
            /// <item><description><b>DELETING</b>: Performing a delete operation.</description></item>
            /// <item><description><b>RESTARTING</b>: Restarting.</description></item>
            /// <item><description><b>LOCKED</b>: Locked because the instance has expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The storage capacity of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>960</para>
            /// </summary>
            [NameInMap("InstanceStorage")]
            [Validation(Required=false)]
            public string InstanceStorage { get; set; }

            /// <summary>
            /// <para>The network type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: Subscription</description></item>
            /// <item><description><b>POSTPAY</b>: Pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzledqeat****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lindorm</b>: Lindorm instance</description></item>
            /// <item><description><b>serverless_lindorm</b>: Lindorm Serverless instance</description></item>
            /// <item><description><b>lindorm_standalone</b>: Lindorm single-node instance</description></item>
            /// <item><description><b>lts</b>: Lindorm Tunnel Service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetLindormInstanceListResponseBodyInstanceListTags> Tags { get; set; }
            public class GetLindormInstanceListResponseBodyInstanceListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.2.18</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1n3i15v90el48nx****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CA1FAFD-E8DC-51C2-AA7E-CA6E2D049BA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

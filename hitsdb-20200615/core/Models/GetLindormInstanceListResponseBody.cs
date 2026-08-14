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
            /// <para>The 16-digit ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164901546557****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The reason why the instance failed to be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource is not enough</para>
            /// </summary>
            [NameInMap("CreateErrorCode")]
            [Validation(Required=false)]
            public string CreateErrorCode { get; set; }

            /// <summary>
            /// <para>The timestamp of when the instance was created. The value is the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631772842000</para>
            /// </summary>
            [NameInMap("CreateMilliseconds")]
            [Validation(Required=false)]
            public long? CreateMilliseconds { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
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
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
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
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCompute")]
            [Validation(Required=false)]
            public bool? EnableCompute { get; set; }

            /// <summary>
            /// <para>Indicates whether the LTS engine is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableLts")]
            [Validation(Required=false)]
            public bool? EnableLts { get; set; }

            /// <summary>
            /// <para>Indicates whether the messaging engine is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableMessage")]
            [Validation(Required=false)]
            public bool? EnableMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether the LindormTable 3.0 engine is enabled. Valid values:</para>
            /// <para>true: Enabled.
            /// false: Not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRow")]
            [Validation(Required=false)]
            public bool? EnableRow { get; set; }

            /// <summary>
            /// <para>Indicates whether the stream engine is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The stream engine is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The stream engine is not enabled.</para>
            /// </description></item>
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
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVector")]
            [Validation(Required=false)]
            public bool? EnableVector { get; set; }

            /// <summary>
            /// <para>The types of engines supported by the instance. The value of this parameter is the sum of the values of the supported engines.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: search engine.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: LindormTSDB.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: LindormTable.</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: file engine.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For example, a value of 15 (8 + 4 + 2 + 1) indicates that the instance supports the file engine, LindormTable, LindormTSDB, and the search engine. A value of 6 (4 + 2) indicates that the instance supports LindormTSDB and LindormTable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only for subscription instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The timestamp of when the instance expires. The value is the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650902400000</para>
            /// </summary>
            [NameInMap("ExpiredMilliseconds")]
            [Validation(Required=false)]
            public long? ExpiredMilliseconds { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ld-bp17pwu1541ia****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVATION</b>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><b>COLD_EXPANDING</b>: The capacity of the storage-optimized instance is being expanded.</para>
            /// </description></item>
            /// <item><description><para><b>MINOR_VERSION_TRANSING</b>: The minor version of the instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>RESIZING</b>: The instance is scaling up.</para>
            /// </description></item>
            /// <item><description><para><b>SHRINKING</b>: The instance is scaling down.</para>
            /// </description></item>
            /// <item><description><para><b>CLASS_CHANGING</b>: The instance class is being changed.</para>
            /// </description></item>
            /// <item><description><para><b>SSL_SWITCHING</b>: The SSL certificate is being changed.</para>
            /// </description></item>
            /// <item><description><para><b>CDC_OPENING</b>: The data subscription feature is being enabled.</para>
            /// </description></item>
            /// <item><description><para><b>TRANSFER</b>: Data migration is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>DATABASE_TRANSFER</b>: Data is being migrated to the database.</para>
            /// </description></item>
            /// <item><description><para><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>BACKUP_RECOVERING</b>: A backup is being restored.</para>
            /// </description></item>
            /// <item><description><para><b>DATABASE_IMPORTING</b>: Data is being imported.</para>
            /// </description></item>
            /// <item><description><para><b>NET_MODIFYING</b>: The network settings are being modified.</para>
            /// </description></item>
            /// <item><description><para><b>NET_SWITCHING</b>: The network type is being switched.</para>
            /// </description></item>
            /// <item><description><para><b>NET_CREATING</b>: A network connection is being created.</para>
            /// </description></item>
            /// <item><description><para><b>NET_DELETING</b>: A network connection is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: The instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>RESTARTING</b>: The instance is being restarted.</para>
            /// </description></item>
            /// <item><description><para><b>LOCKED</b>: The instance has expired and is locked.</para>
            /// </description></item>
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
            /// <item><description><para><b>PREPAY</b>: subscription.</para>
            /// </description></item>
            /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzledqeat****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>lindorm</b>: a Lindorm instance.</para>
            /// </description></item>
            /// <item><description><para><b>serverless_lindorm</b>: a Lindorm Serverless instance.</para>
            /// </description></item>
            /// <item><description><para><b>lindorm_standalone</b>: a Lindorm standalone instance.</para>
            /// </description></item>
            /// <item><description><para><b>lts</b>: the Lindorm Tunnel Service type.</para>
            /// </description></item>
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
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.2.18</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) in which the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1n3i15v90el48nx****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CA1FAFD-E8DC-51C2-AA7E-CA6E2D049BA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

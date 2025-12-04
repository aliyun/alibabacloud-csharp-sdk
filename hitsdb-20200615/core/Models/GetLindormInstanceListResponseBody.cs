// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class GetLindormInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The 16-digit AliUid of the Alibaba Cloud account that owns the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>164901546557****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("CreateErrorCode")]
            [Validation(Required=false)]
            public string CreateErrorCode { get; set; }

            /// <summary>
            /// <para>The time when the instance is created. This value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631772842000</para>
            /// </summary>
            [NameInMap("CreateMilliseconds")]
            [Validation(Required=false)]
            public long? CreateMilliseconds { get; set; }

            /// <summary>
            /// <para>The time when the instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-16 14:13:13</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the column storage engine is enabled, returning:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. - <b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableColumn")]
            [Validation(Required=false)]
            public bool? EnableColumn { get; set; }

            /// <summary>
            /// <para>Indicates whether LDPS is activated for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: LDPS is activated for the instance.</description></item>
            /// <item><description><b>false</b>: LDPS is not activated for the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableCompute")]
            [Validation(Required=false)]
            public bool? EnableCompute { get; set; }

            /// <summary>
            /// <para>Indicates whether the LTS engine is enabled, returning:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. - <b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableLts")]
            [Validation(Required=false)]
            public bool? EnableLts { get; set; }

            /// <summary>
            /// <para>Indicates whether the message engine is enabled, returning:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. - <b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableMessage")]
            [Validation(Required=false)]
            public bool? EnableMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether the table 3.0 storage engine is enabled, returning:</para>
            /// <para>true: Enabled. - false: Not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRow")]
            [Validation(Required=false)]
            public bool? EnableRow { get; set; }

            /// <summary>
            /// <para>Indicates whether the Lindorm streaming engine is activated for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The Lindorm streaming engine is activated for the instance.</description></item>
            /// <item><description><b>false</b>: The Lindorm streaming engine is not activated for the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStream")]
            [Validation(Required=false)]
            public bool? EnableStream { get; set; }

            /// <summary>
            /// <para>Whether the vector engine is enabled, returns:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. - <b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableVector")]
            [Validation(Required=false)]
            public bool? EnableVector { get; set; }

            /// <summary>
            /// <para>The engine supported by the instance. The engines are indicated by different numbers:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: LindormSearch.</description></item>
            /// <item><description><b>2</b>: LindormTSDB.</description></item>
            /// <item><description><b>4</b>: LindormTable.</description></item>
            /// <item><description><b>8</b>: LindormDFS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The value of this parameter is the sum of all numbers that indicate the engines supported by the instance. For example, if the value of this parameter is 15, which is the sum of 1, 2, 4, and 8, the instance supports all four engines. If the value of this parameter is 6, which is the sum of 2 and 4, the instance supports LindormTSDB and LindormTable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the billing method of the instance is subscription.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26 00:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. This value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650902400000</para>
            /// </summary>
            [NameInMap("ExpiredMilliseconds")]
            [Validation(Required=false)]
            public long? ExpiredMilliseconds { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// <para>The ID of the instance</para>
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
            /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
            /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
            /// <item><description><b>COLD_EXPANDING</b>: The Capacity storage of the instance is being scaled up.</description></item>
            /// <item><description><b>MINOR_VERSION_TRANSING</b>: The minor version of the instance is being updated.</description></item>
            /// <item><description><b>RESIZING</b>: The nodes in the instance are being scaled up.</description></item>
            /// <item><description><b>SHRINKING</b>: The nodes in the instance are being scaled down.</description></item>
            /// <item><description><b>CLASS_CHANGING</b>: The specification of the instance is being changed.</description></item>
            /// <item><description><b>SSL_SWITCHING: SSL</b>: The SSL configurations of the instance are being changed.</description></item>
            /// <item><description><b>CDC_OPENING</b>: Data subscription is being enabled for the instance.</description></item>
            /// <item><description><b>TRANSFER</b>: The data of the instance is being transferred.</description></item>
            /// <item><description><b>DATABASE_TRANSFER</b>: The data of the instance is being transferred to databases.</description></item>
            /// <item><description><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</description></item>
            /// <item><description><b>BACKUP_RECOVERING</b>: The data of the instance is being restored from a backup.</description></item>
            /// <item><description><b>DATABASE_IMPORTING</b>: Data is being imported to the instance.</description></item>
            /// <item><description><b>NET_MODIFYING</b>: The network configurations of the instance are being changed.</description></item>
            /// <item><description><b>NET_SWITCHING</b>: The network of the instance is being switched between a virtual private cloud (VPC) and the Internet.</description></item>
            /// <item><description><b>NET_CREATING</b>: The connection to the instance is being created.</description></item>
            /// <item><description><b>NET_DELETING</b>: The connection to the instance is being deleted.</description></item>
            /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
            /// <item><description><b>RESTARTING</b>: The instance is restarting.</description></item>
            /// <item><description><b>LOCKED</b>: The instance is locked because it expires.</description></item>
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
            /// <item><description><b>PREPAY</b>: subscription.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzledqeat****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The series of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lindorm</b>: The instance is a Lindorm instance.</description></item>
            /// <item><description><b>serverless_lindorm</b>: The instance is a Lindorm Serverless instance.</description></item>
            /// <item><description><b>lindorm_standalone</b>: The instance is a single-node Lindorm instance.</description></item>
            /// <item><description><b>lts</b>: The instance is an LTS instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The list of tags associated with the specified instances.</para>
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
            /// <para>The ID of the VPC in which the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1n3i15v90el48nx****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances that are returned on each page.</para>
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
        /// <para>The total number of returned instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

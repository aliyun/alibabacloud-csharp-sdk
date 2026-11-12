// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterPriceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster edition. Valid values: Normal (Cluster Edition), Basic (Single Node Edition), ArchiveNormal (Archive Database Cluster Edition), SENormal (Standard Edition), and NormalMultimaster (Multi-master Cluster).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The cluster ID. Required for non-BUY scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node specifications. Required for the BUY scenario. Example format: polar.mysql.x4.large.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x4.large</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The list of node IDs to delete. Used when ModifyType is set to DELETE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pi-***************&quot;]</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public List<string> DBNodeIds { get; set; }

        /// <summary>
        /// <para>The number of nodes. Valid for the BUY scenario. This number includes read/write nodes. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// <para>The list of nodes for heterogeneous specification changes. Used in specification change scenarios to specify the target specifications for each node.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPriceRequestDBNodes> DBNodes { get; set; }
        public class DescribeDBClusterPriceRequestDBNodes : TeaModel {
            /// <summary>
            /// <para>The target node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.large</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-**************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

        }

        /// <summary>
        /// <para>The database engine type. Required for the BUY scenario. Valid values: MySQL, PostgreSQL, and Oracle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The database engine version. Required for the BUY scenario. Valid values for MySQL: 5.6, 5.7, and 8.0. Valid values for PostgreSQL: 11 and 14. Valid values for Oracle: 11 and 14.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the hot standby cluster. Valid values: ON and OFF. Valid for the BUY and specification change scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>The modification type. Valid values: ADD (add nodes), DELETE (remove nodes), UPGRADE (upgrade), DOWNGRADE (downgrade), HOT_STANDBY (hot standby change), STORAGE (storage space change), and STORAGE_TYPE (storage type change).</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The order type. Valid values: BUY (new purchase), CONVERT (billing method change), RENEW (renewal), UPGRADE (upgrade or add nodes), and DOWNGRADE (downgrade or remove nodes).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The billing method. Required for the BUY and CONVERT scenarios. Valid values: Prepaid (subscription) and Postpaid (pay-as-you-go).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription period. Valid values: Month and Year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS. Used for the Standard Edition (SENormal) scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public string ProvisionedIops { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Serverless type. Valid value: AgileServerless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The storage billing method. Valid values: Prepaid (subscription) and Postpaid (pay-as-you-go).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StorageChargeType")]
        [Validation(Required=false)]
        public string StorageChargeType { get; set; }

        /// <summary>
        /// <para>The storage space. Unit: GB. Used for prepaid storage or storage specification change scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public string StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values: PSL5 (premium performance), PSL4 (standard performance), ESSDPL0, ESSDPL1, ESSDPL2, ESSDPL3, and ESSDAUTOPL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PSL5</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The purchase duration. Used in combination with Period. Valid for the BUY, CONVERT, and RENEW scenarios when the billing method is Prepaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The zone ID. Recommended for the BUY scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

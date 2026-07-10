// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterPriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: Cluster Edition.</description></item>
        /// <item><description>Basic: Single Node Edition.</description></item>
        /// <item><description>ArchiveNormal: Archive Database.</description></item>
        /// <item><description>SENormal: Standard Edition.</description></item>
        /// <item><description>NormalMultimaster: Multi-master Cluster.</description></item>
        /// </list>
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
        /// <para>pi-**************</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public List<string> DBNodeIds { get; set; }

        /// <summary>
        /// <para>The number of nodes. Valid for the BUY scenario. This value includes the read/write node. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeNum")]
        [Validation(Required=false)]
        public int? DBNodeNum { get; set; }

        /// <summary>
        /// <para>The list of heterogeneous specification change nodes. Used for specification change scenarios to specify the target specifications for each node.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public string DBNodesShrink { get; set; }

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
        /// <para>Specifies whether to enable the hot standby cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ON: Enable.</description></item>
        /// <item><description>OFF: Disable.</description></item>
        /// </list>
        /// <para>Valid for the BUY and specification change scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>The specification change direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ADD: add nodes.</description></item>
        /// <item><description>DELETE: remove nodes.</description></item>
        /// <item><description>UPGRADE: upgrade specifications.</description></item>
        /// <item><description>DOWNGRADE: downgrade specifications.</description></item>
        /// <item><description>HOT_STANDBY: hot standby change.</description></item>
        /// <item><description>STORAGE: storage space change.</description></item>
        /// <item><description>STORAGE_TYPE: storage type change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: new purchase.</description></item>
        /// <item><description>CONVERT: billing method conversion.</description></item>
        /// <item><description>RENEW: renewal.</description></item>
        /// <item><description>UPGRADE: upgrade specifications or add nodes.</description></item>
        /// <item><description>DOWNGRADE: downgrade specifications or remove nodes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The billing method. Required for the BUY and CONVERT scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription.</description></item>
        /// <item><description>Postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: monthly.</description></item>
        /// <item><description>Year: yearly.</description></item>
        /// </list>
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
        /// <para>The serverless type. Valid values: AgileServerless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgileServerless</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The storage billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription.</description></item>
        /// <item><description>Postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("StorageChargeType")]
        [Validation(Required=false)]
        public string StorageChargeType { get; set; }

        /// <summary>
        /// <para>The storage space, in GB. Used for prepaid storage or storage specification change scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public string StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PSL5: high performance.</description></item>
        /// <item><description>PSL4: standard.</description></item>
        /// <item><description>ESSDPL0</description></item>
        /// <item><description>ESSDPL1</description></item>
        /// <item><description>ESSDPL2</description></item>
        /// <item><description>ESSDPL3</description></item>
        /// <item><description>ESSDAUTOPL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PSL5</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Used together with Period. Valid for the BUY, CONVERT, and RENEW scenarios when the billing method is Prepaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The zone ID. We recommend that you specify this parameter for the BUY scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

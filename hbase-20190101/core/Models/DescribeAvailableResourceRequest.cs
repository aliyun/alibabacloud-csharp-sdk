// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The specifications of the core node. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/194870.html">Instance node specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.large</para>
        /// </summary>
        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        /// <summary>
        /// <para>The disk type of the core node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd_pl1</b>: ESSD</description></item>
        /// <item><description><b>local_hdd_pro</b>: local HDD</description></item>
        /// <item><description><b>local_ssd_pro</b>: local SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The service type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition standard instance.</description></item>
        /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Performance-enhanced Edition standard instance.</description></item>
        /// <item><description><b>singlehbase</b>: ApsaraDB for HBase single-node standard instance.</description></item>
        /// <item><description><b>bds</b>: Data Synchronization (BDS) service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version number of the service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0</b>: The Data Synchronization (BDS) service supports version 1.0.</description></item>
        /// <item><description><b>1.1</b>: ApsaraDB for HBase Standard Edition standard instances and ApsaraDB for HBase single-node standard instances support version 1.1.</description></item>
        /// <item><description><b>2.0</b>: ApsaraDB for HBase Standard Edition standard instances, ApsaraDB for HBase Performance-enhanced Edition standard instances, and ApsaraDB for HBase single-node standard instances support version 2.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify the version number based on the service type of the ApsaraDB for HBase instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone. You can call the <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> operation to query available zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

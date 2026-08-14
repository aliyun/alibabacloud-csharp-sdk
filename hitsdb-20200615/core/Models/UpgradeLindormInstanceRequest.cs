// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpgradeLindormInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The new storage capacity of the instance. Unit: GB. Valid values: <b>480</b> to <b>1017600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("ClusterStorage")]
        [Validation(Required=false)]
        public int? ClusterStorage { get; set; }

        /// <summary>
        /// <para>The new cold storage capacity of the instance. Unit: GB. Valid values: <b>800</b> to <b>1000000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The new storage capacity of a single core node in a multi-zone instance. Unit: GB. Valid values: 400 to 64000. <b>This parameter is optional.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400GB</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The new number of file engine nodes. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// <para>The new specification of the file engine nodes. Valid value:</para>
        /// <para><b>lindorm.c.xlarge</b>: 4 CPU cores, 8 GB of memory (standard specification).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/426069.html">GetLindormInstanceList</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1o3y0yme2i2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new number of wide table engine nodes. Valid values: <b>0</b> to <b>90</b>.</para>
        /// <remarks>
        /// <para>If you specify this parameter, the LindormSpec parameter is also required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// <para>The new specification of the wide table engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.c.xlarge</b>: 4 CPU cores, 8 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 CPU cores, 32 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 CPU cores, 64 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// <para>The new number of log nodes for a multi-zone instance. Valid values: 4 to 400. <b>This parameter is optional.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The new disk capacity of a single log node for a multi-zone instance. Unit: GB. Valid values: 400 to 64000. <b>This parameter is optional.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400GB</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The new specification of the log nodes for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.sn1.large</b>: 4 CPU cores, 8 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.sn1.2xlarge</b>: 8 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// <para><b>This parameter is optional.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The new number of LTS nodes. Valid values: <b>0</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LtsCoreNum")]
        [Validation(Required=false)]
        public int? LtsCoreNum { get; set; }

        /// <summary>
        /// <para>The new specification of the LTS nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 CPU cores, 32 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("LtsCoreSpec")]
        [Validation(Required=false)]
        public string LtsCoreSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to obtain the latest region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The new number of search engine nodes. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// <para>The new specification of the search engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 CPU cores, 32 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 CPU cores, 64 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarg</b>e: 32 CPU cores, 128 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// <para>The new number of stream engine nodes. Valid values: <b>0</b> to <b>90</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// <para>The new specification of the stream engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 CPU cores, 32 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 CPU cores, 64 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// <para>The new number of time series engine nodes. Valid values: <b>0</b> to <b>24</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// <para>The new specification of the time series engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 CPU cores, 16 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 CPU cores, 32 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 CPU cores, 64 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 CPU cores, 128 GB of memory (dedicated specification).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// <para>The type of the upgrade. For details about the supported types, see the description of the UpgradeType parameter in the &quot;Additional information about request parameters&quot; section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upgrade-cold-storage</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// <para>The ID of the availability zone. You can call the <a href="https://help.aliyun.com/document_detail/426067.html">GetLindormInstance</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

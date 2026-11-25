// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpgradeLindormInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The storage capacity of the instance after the specification change. Unit: GB. Valid values: <b>480</b> to <b>1017600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("ClusterStorage")]
        [Validation(Required=false)]
        public int? ClusterStorage { get; set; }

        /// <summary>
        /// <para>The cold storage capacity of the instance after the specification change. Unit: GB. Valid values: <b>800</b> to <b>1000000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The storage capacity per core node of the instance after the specification change for a multi-zone instance. Valid values: 400 to 64000. Unit: GB. <b>Specify this parameter if the target instance is a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The number of file engine nodes of the instance after the specification change. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// <para>The file engine node specifications of the instance after the specification change. Valid values:</para>
        /// <para><b>indorm.c.xlarge</b>: 4 cores and 8 GB of memory (standard specification).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/426069.html">GetLindormInstanceList</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1o3y0yme2i2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of LindormTable nodes of the instance after the specification change. Valid values: <b>0</b> to <b>90</b>.</para>
        /// <remarks>
        /// <para>This parameter must be specified together with the LindormSpec parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// <para>The LindormTable engine node specifications of the instance after the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: 4 cores and 8 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores and 16 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores and 32 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores and 64 GB of memory (dedicated specification).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// <para>The number of log nodes of the instance after the specification change for a multi-zone instance. Valid values: 4 to 400. <b>Specify this parameter if the target instance is a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The disk capacity per log node of the instance after the specification change for a multi-zone instance. Valid values: 400 to 64000. Unit: GB. <b>Specify this parameter if the target instance is a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The log node specifications of the instance after the specification change for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.sn1.large</b>: 4 cores and 8 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.sn1.2xlarge</b>: 8 cores and 16 GB of memory (dedicated specification).</description></item>
        /// </list>
        /// <para><b>Specify this parameter if the target instance is a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The number of LTS nodes of the instance after the specification change. Valid values: <b>0</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LtsCoreNum")]
        [Validation(Required=false)]
        public int? LtsCoreNum { get; set; }

        /// <summary>
        /// <para>The LTS node specifications of the instance after the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores and 16 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores and 32 GB of memory (dedicated specification).</description></item>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The number of search index engine nodes of the instance after the specification change. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// <para>The search index engine node specifications of the instance after the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores and 16 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores and 32 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores and 64 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.8xlarg</b>e: 32 cores and 128 GB of memory (dedicated specification).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// <para>The number of stream engine nodes of the instance after the specification change. Valid values: <b>0</b> to <b>90</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// <para>The stream engine node specifications of the instance after the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores and 16 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores and 32 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores and 64 GB of memory (dedicated specification).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// <para>The number of LindormTSDB nodes of the instance after the specification change. Valid values: <b>0</b> to <b>24</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// <para>The LindormTSDB engine node specifications of the instance after the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores and 16 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores and 32 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores and 64 GB of memory (dedicated specification).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores and 128 GB of memory (dedicated specification).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// <para>The type of specification change for the instance. For supported types, see the UpgradeType parameter description in the request parameters supplement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upgrade-cold-storage</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/426067.html">GetLindormInstance</a> operation to query the zone ID.</para>
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

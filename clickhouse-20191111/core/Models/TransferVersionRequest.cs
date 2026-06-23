// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class TransferVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1tm8zf130ew****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The time windows during which writes are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-08T00:00:00+08:00,2025-02-12T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("DisableWriteWindows")]
        [Validation(Required=false)]
        public string DisableWriteWindows { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (Default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region. Call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

        /// <summary>
        /// <para>The source account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceAccount")]
        [Validation(Required=false)]
        public string SourceAccount { get; set; }

        /// <summary>
        /// <para>The name of the self-managed ClickHouse cluster.
        /// To obtain the name, execute <c>SELECT * FROM system.clusters</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SourceClusterName")]
        [Validation(Required=false)]
        public string SourceClusterName { get; set; }

        /// <summary>
        /// <para>The password of the source account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Aa</para>
        /// </summary>
        [NameInMap("SourcePassword")]
        [Validation(Required=false)]
        public string SourcePassword { get; set; }

        /// <summary>
        /// <para>The addresses and TCP ports of the shards in the self-managed ClickHouse cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.4:9000,192.168.0.5:9000,192.168.0.6:9000</para>
        /// </summary>
        [NameInMap("SourceShards")]
        [Validation(Required=false)]
        public string SourceShards { get; set; }

        /// <summary>
        /// <para>The destination account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("TargetAccount")]
        [Validation(Required=false)]
        public string TargetAccount { get; set; }

        /// <summary>
        /// <para>The ID of the destination cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp14b39djx7zg****</para>
        /// </summary>
        [NameInMap("TargetDbClusterId")]
        [Validation(Required=false)]
        public string TargetDbClusterId { get; set; }

        /// <summary>
        /// <para>The password of the destination account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456Ff</para>
        /// </summary>
        [NameInMap("TargetPassword")]
        [Validation(Required=false)]
        public string TargetPassword { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dedicated cluster. You can view the dedicated cluster ID on the Dedicated Clusters page in the ApsaraDB for MyBase console.</para>
        /// <remarks>
        /// <para>Separate multiple IDs with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-5f2v98840ioq****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the host in the dedicated cluster. You can call the <a href="https://help.aliyun.com/document_detail/200944.html">DescribeDedicatedHosts</a> operation to query the host ID.</para>
        /// <remarks>
        /// <para>Separate multiple IDs with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ch-t4n664a9mal4c****</para>
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Set the value to <b>Redis</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. Set the value to <b>5.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>The instance must be created by using a dedicated cluster. For more information, see <a href="https://help.aliyun.com/document_detail/141455.html">What is ApsaraDB for MyBase?</a></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Internet</description></item>
        /// <item><description><b>1</b>: classic network</description></item>
        /// <item><description><b>2</b>: Virtual Private Cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceNetType")]
        [Validation(Required=false)]
        public string InstanceNetType { get; set; }

        /// <summary>
        /// <para>The state of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The instance is being created.</description></item>
        /// <item><description><b>1</b>: The instance is running.</description></item>
        /// <item><description><b>3</b>: The instance is being deleted.</description></item>
        /// <item><description><b>5</b>: The configurations of the instance are being changed.</description></item>
        /// <item><description><b>6</b>: The instance is being migrated.</description></item>
        /// <item><description><b>7</b>: The instance is being restored from a backup.</description></item>
        /// <item><description><b>8</b>: A master-replica switchover is in progress.</description></item>
        /// <item><description><b>9</b>: Expired data of the instance is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public int? InstanceStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

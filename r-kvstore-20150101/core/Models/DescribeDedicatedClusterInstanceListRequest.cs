// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The dedicated cluster ID. You can obtain the ID on the dedicated cluster information page in the ApsaraDB for MyBase console.</para>
        /// <remarks>
        /// <para>To specify multiple IDs, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-5f2v98840ioq****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The host ID in the dedicated cluster. You can call <a href="https://help.aliyun.com/document_detail/200944.html">DescribeDedicatedHosts</a> to query the host ID.</para>
        /// <remarks>
        /// <para>To specify multiple IDs, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ch-t4n664a9mal4c****</para>
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>Redis</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version. Set the value to <b>5.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>The instance must be created in a dedicated cluster. For more information, see <a href="https://help.aliyun.com/document_detail/141455.html">ApsaraDB for MyBase</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the instance endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Internet.</description></item>
        /// <item><description><b>1</b>: Classic network.</description></item>
        /// <item><description><b>2</b>: Virtual Private Cloud (VPC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceNetType")]
        [Validation(Required=false)]
        public string InstanceNetType { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Creating.</description></item>
        /// <item><description><b>1</b>: Running.</description></item>
        /// <item><description><b>3</b>: Deleting.</description></item>
        /// <item><description><b>5</b>: Changing specifications.</description></item>
        /// <item><description><b>6</b>: Migrating.</description></item>
        /// <item><description><b>7</b>: Restoring from backup.</description></item>
        /// <item><description><b>8</b>: Switching.</description></item>
        /// <item><description><b>9</b>: Deleting expired data.</description></item>
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
        /// <para>The page number. The value must be greater than <b>0</b> and less than or equal to the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> to query region IDs.</para>
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
        /// <para>The zone ID. You can call <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> to query zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

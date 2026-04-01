// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether instances can be deployed on the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Instances cannot be deployed on the host.</description></item>
        /// <item><description><b>1</b>: Instances can be deployed on the host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID. You can call the DescribeDedicatedHostGroups operation to query the dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9xxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the host in the dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch-t4nn100ddxxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The status of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: creating</description></item>
        /// <item><description><b>1</b>: running</description></item>
        /// <item><description><b>2</b>: faulty</description></item>
        /// <item><description><b>3</b>: being replaced</description></item>
        /// <item><description><b>4</b>: deprecated</description></item>
        /// <item><description><b>5</b>: deleting</description></item>
        /// <item><description><b>6</b>: restarting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        /// <summary>
        /// <para>The storage type of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dhg_cloud_ssd</b>: enhanced SSD (ESSD)</description></item>
        /// <item><description><b>dhg_local_ssd</b>: local SSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dhg_cloud_ssd</para>
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102565235</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGlobalAccelerationInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth type of the Alibaba Cloud Global Accelerator (GA) instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Sharing</b>: Queries shared-bandwidth instances.</para>
        /// </description></item>
        /// <item><description><para><b>Exclusive</b> (default): Queries dedicated-bandwidth instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-234sljmxaz****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include reservation data that has not taken effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Does not include reservation data that has not taken effect.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Includes reservation data that has not taken effect.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The public IP address of the Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.xx.xx.78</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging queries. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Alibaba Cloud Global Accelerator (GA) instance resides. You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The instance ID of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-sxjblddejj9x****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// <para>The backend service region. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>china-mainland</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>north-america</b>: North America.</para>
        /// </description></item>
        /// <item><description><para><b>asia-pacific</b>: Asia Pacific.</para>
        /// </description></item>
        /// <item><description><para><b>europe</b>: Europe.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>china-mainland</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// <para>The instance status of the Alibaba Cloud Global Accelerator (GA) instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Available</b>: active.</para>
        /// </description></item>
        /// <item><description><para><b>Inuse</b>: Allocated.</para>
        /// </description></item>
        /// <item><description><para><b>Associating</b>: Being attached.</para>
        /// </description></item>
        /// <item><description><para><b>Unassociating</b>: Being disassociated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

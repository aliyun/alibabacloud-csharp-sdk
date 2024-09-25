// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGlobalAccelerationInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth type of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Sharing</b></description></item>
        /// <item><description><b>Exclusive</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-234sljmxaz****</para>
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about pending orders. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The public IP address of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.xx.xx.78</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the GA instance.</para>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the backend service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-sxjblddejj9x****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// <para>The region of the backend service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>china-mainland</b></description></item>
        /// <item><description><b>north-america</b></description></item>
        /// <item><description><b>asia-pacific</b></description></item>
        /// <item><description><b>europe</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>china-mainland</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// <para>The status of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Available</b></description></item>
        /// <item><description><b>Inuse</b></description></item>
        /// <item><description><b>Associating</b></description></item>
        /// <item><description><b>Unassociating</b></description></item>
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

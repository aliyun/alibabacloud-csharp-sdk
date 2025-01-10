// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Destination CIDR Block</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable pagination query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>Filter 32 detailed CIDR blocks. Default value: true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreDetailedRouteEntry")]
        [Validation(Required=false)]
        public bool? IgnoreDetailedRouteEntry { get; set; }

        /// <summary>
        /// <para>Network Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-209300qha01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Next Hop Instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-209300qha01</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>Next Hop Instance Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>VCC</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyuzlx2iihcy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Route type</para>
        /// 
        /// <b>Example:</b>
        /// <para>VCC</para>
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// <para>The status of the enterprise-level snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

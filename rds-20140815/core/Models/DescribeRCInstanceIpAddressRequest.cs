// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The region ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// <para>The DDoS mitigation status of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: queries assets for which traffic scrubbing is performed.</description></item>
        /// <item><description><b>blackhole</b>: queries assets for which blackhole filtering is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("DdosStatus")]
        [Validation(Required=false)]
        public string DdosStatus { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Custom instance to which the asset to query is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-y6dn4pyuub1r89******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.105.XXX.XXX</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the RDS Custom instance to which the asset to query is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-y6dn4pyuub1r89******</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The type of the asset that is assigned a public IP address. Set the value to <b>ecs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of instances on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the RDS Custom instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Set the value to <b>ecs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

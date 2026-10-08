// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: 1, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The region ID of the assets that are assigned public IP addresses to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// <para>The DDoS mitigation status of the assets that are assigned public IP addresses to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>defense</b>: Cleaning. Assets that are assigned public IP addresses for which Anti-DDoS Origin scrubs traffic are queried.</description></item>
        /// <item><description><b>blackhole</b>: Black Hole Activated. Assets that are assigned public IP addresses that are in the blackhole filtering status are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>defense</para>
        /// </summary>
        [NameInMap("DdosStatus")]
        [Validation(Required=false)]
        public string DdosStatus { get; set; }

        /// <summary>
        /// <para>The instance ID of the Custom instance to which the assets that are assigned public IP addresses belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-y6dn4pyuub1r89******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the assets that are assigned public IP addresses to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.105.XXX.XXX</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the Custom instance to which the assets that are assigned public IP addresses belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-y6dn4pyuub1r89******</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type of the assets that are assigned public IP addresses to query. Set the value to <b>ecs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Settings for paged query. The number of instances to return on each page for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Custom instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <b>ecs</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

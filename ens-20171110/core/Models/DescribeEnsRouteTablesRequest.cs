// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteTablesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VSwitch</b> (default): vSwitch route table</description></item>
        /// <item><description><b>Gateway</b>: gateway route table</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("AssociateType")]
        [Validation(Required=false)]
        public string AssociateType { get; set; }

        /// <summary>
        /// <para>The ID of the ENS node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The IDs of edge nodes. You can specify 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5p1cifr72di****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the route table that you want to query.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>tftest-nat04</para>
        /// </summary>
        [NameInMap("RouteTableName")]
        [Validation(Required=false)]
        public string RouteTableName { get; set; }

        /// <summary>
        /// <para>The type of the NAT.</para>
        /// <list type="bullet">
        /// <item><description>Empty: symmetric NAT.</description></item>
        /// <item><description>FullCone: full cone NAT.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullCone</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

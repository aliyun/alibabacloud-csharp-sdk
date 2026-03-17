// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3D21D0B-5258-5412-AD1C-3929D297286B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the queried routes.</para>
        /// </summary>
        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayRoutesResponseBodyRoutes> Routes { get; set; }
        public class ViewSmartAccessGatewayRoutesResponseBodyRoutes : TeaModel {
            /// <summary>
            /// <para>The CIDR blocks that overlap with each other.</para>
            /// </summary>
            [NameInMap("ConflictCidrs")]
            [Validation(Required=false)]
            public List<string> ConflictCidrs { get; set; }

            /// <summary>
            /// <para>The route cost.</para>
            /// <para>The first <b>0</b> represents the administrative distance (AD).</para>
            /// <para>The second <b>0</b> represents the router metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[0/0]</para>
            /// </summary>
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.1.1.0/24</para>
            /// </summary>
            [NameInMap("Dst")]
            [Validation(Required=false)]
            public string Dst { get; set; }

            /// <summary>
            /// <para>The port number. A value of -1 indicates that the next hop points to a VPN tunnel.</para>
            /// <para>Valid values: <b>-1</b> to <b>4294967295</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Idx")]
            [Validation(Required=false)]
            public int? Idx { get; set; }

            /// <summary>
            /// <para>The next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.XX.XX.1</para>
            /// </summary>
            [NameInMap("Nexthop")]
            [Validation(Required=false)]
            public string Nexthop { get; set; }

            /// <summary>
            /// <para>The port role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAN</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The route type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>static</b></description></item>
            /// <item><description><b>bgp</b></description></item>
            /// <item><description><b>ospf</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}

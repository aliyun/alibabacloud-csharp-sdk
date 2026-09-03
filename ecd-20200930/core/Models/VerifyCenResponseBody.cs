// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenResponseBody : TeaModel {
        /// <summary>
        /// <para>The recommended IPv4 CIDR blocks. Three CIDR blocks are randomly recommended. This parameter is returned when <c>Status</c> is <c>Conflict</c>.</para>
        /// </summary>
        [NameInMap("CidrBlocks")]
        [Validation(Required=false)]
        public List<string> CidrBlocks { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AF9D857-AE96-53D6-B317-5DD665EC4EC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route information contained in the CEN instance.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<VerifyCenResponseBodyRouteEntries> RouteEntries { get; set; }
        public class VerifyCenResponseBodyRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The instance ID of the network instance associated with the routing entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf62bu0xs5j8md54p****</para>
            /// </summary>
            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The route check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The result of the CIDR block conflict check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

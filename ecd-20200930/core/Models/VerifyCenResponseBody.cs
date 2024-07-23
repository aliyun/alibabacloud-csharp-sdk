// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenResponseBody : TeaModel {
        /// <summary>
        /// <para>The recommended IPv4 CIDR blocks. Three CIDR blocks are randomly recommended. This parameter is returned when the <c>Status</c> value is <c>Conflict</c>.</para>
        /// </summary>
        [NameInMap("CidrBlocks")]
        [Validation(Required=false)]
        public List<string> CidrBlocks { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AF9D857-AE96-53D6-B317-5DD665EC4EC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routes provided by the CEN instance.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<VerifyCenResponseBodyRouteEntries> RouteEntries { get; set; }
        public class VerifyCenResponseBodyRouteEntries : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.111.3****</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the instance corresponding to the route.</para>
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
            /// <para>The verification result of the route.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Conflict: A CIDR block conflict exists.</description></item>
            /// <item><description>Access: The verification is passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Access</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The check result of CIDR block conflict.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InvalidCen.CenUidInvalid: The Alibaba Cloud account is invalid or the Alibaba Cloud account does not have the permission to access Elastic Desktop Service.</description></item>
        /// <item><description>VerifyCode.InvalidTokenCode: The verification code is invalid.</description></item>
        /// <item><description>VerifyCode.ReachTokenRetryTime: The maximum number of times for entering a verification code reaches the limit.</description></item>
        /// <item><description>Conflict: A CIDR block conflict exists. If the verification result of at least one route is Conflict, Conflict is returned for this parameter.</description></item>
        /// <item><description>Access: The verification is passed. If the verification result for all routes is Access, Access is returned for this parameter.</description></item>
        /// <item><description>InvalidCen.ParameterCenInstanceId: The Alibaba Cloud account does not own the CEN instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Access</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

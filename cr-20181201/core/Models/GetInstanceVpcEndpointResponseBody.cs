// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// <para>Indicates whether the VPC endpoint is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The VPCs that are added to the access control list.</para>
        /// </summary>
        [NameInMap("LinkedVpcs")]
        [Validation(Required=false)]
        public List<GetInstanceVpcEndpointResponseBodyLinkedVpcs> LinkedVpcs { get; set; }
        public class GetInstanceVpcEndpointResponseBodyLinkedVpcs : TeaModel {
            /// <summary>
            /// <para>Indicates whether the VPC is the default VPC over which the Container Registry instance is accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DefaultAccess")]
            [Validation(Required=false)]
            public bool? DefaultAccess { get; set; }

            /// <summary>
            /// <para>IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.11</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRIVATE_ZONE_CONFLICT_AT_{private_zone_id}</para>
            /// </summary>
            [NameInMap("Issue")]
            [Validation(Required=false)]
            public string Issue { get; set; }

            /// <summary>
            /// <para>The status of the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>CREATING</c></description></item>
            /// <item><description><c>RUNNING</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6aamu2nomfr1thd****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf62m5vmxl2e72dk7****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The name of the modules that can be accessed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Registry</c>: image repositories.</description></item>
        /// <item><description><c>Chart</c>: Helm charts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Registry</para>
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAE9349D-A587-4F9A-B574-9DA0EF2638D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

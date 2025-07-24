// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class PublishVpcRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to perform a dry run of this request. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends a check request without publishing the route. The checks include whether the AccessKey is valid, the authorization status of the RAM user, and if all required parameters are filled out. If the check fails, the corresponding error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. After passing the check, it returns a 2xx HTTP status code and directly queries the resource status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. You can obtain the region ID by calling the DescribeRegions interface.</para>
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
        /// <para>List of route entries to be published, supporting up to 50 routes at most.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<PublishVpcRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class PublishVpcRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block for the route entry.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.165.123/32</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the route table for the route entry.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze3jgygk9bmsj23s****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the target instance for route publication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-dhw2xsds5****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the target for route publication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECR</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}

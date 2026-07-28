// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class PublishVpcRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without publishing route entries. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the check succeeds, a 2xx HTTP status code is returned and the resource status is queried.</para>
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
        /// <para>The region ID of the instance. You can call the DescribeRegions operation to query the region ID.</para>
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
        /// <para>The list of route entries to publish. You can specify up to 50 routes.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<PublishVpcRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class PublishVpcRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.165.123/32</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The route table ID of the route entry.</para>
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
        /// <para>The publish route entry target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-dhw2xsds5****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the route publish target.</para>
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

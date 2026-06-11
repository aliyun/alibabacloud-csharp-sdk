// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoint connections.</para>
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<ListVpcEndpointConnectionsResponseBodyConnections> Connections { get; set; }
        public class ListVpcEndpointConnectionsResponseBodyConnections : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the endpoint connection. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3072</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The state of the endpoint connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: The endpoint connection is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Connecting</b>: The endpoint connection is being established.</para>
            /// </description></item>
            /// <item><description><para><b>Connected</b>: The endpoint is connected to the endpoint service.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnecting</b>: The endpoint is being disconnected from the endpoint service.</para>
            /// </description></item>
            /// <item><description><para><b>Disconnected</b>: The endpoint is disconnected from the endpoint service.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The endpoint connection is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>ServiceDeleted</b>: The corresponding endpoint service is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-hp33b2e43fays7s8****</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25346073170691****</para>
            /// </summary>
            [NameInMap("EndpointOwnerId")]
            [Validation(Required=false)]
            public long? EndpointOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("EndpointRegionId")]
            [Validation(Required=false)]
            public string EndpointRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp356stwkxg3fn2xe****</para>
            /// </summary>
            [NameInMap("EndpointVpcId")]
            [Validation(Required=false)]
            public string EndpointVpcId { get; set; }

            /// <summary>
            /// <para>The time when the connection was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-28T10:34:46Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmw353z35v***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the endpoint and the endpoint service belong to the same Alibaba Cloud account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResourceOwner")]
            [Validation(Required=false)]
            public bool? ResourceOwner { get; set; }

            /// <summary>
            /// <para>The endpoint service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-hp3vpx8yqxblby3i****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The region ID of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("ServiceRegionId")]
            [Validation(Required=false)]
            public string ServiceRegionId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description><para>Scalability: automatic scaling. In this mode, the bandwidth configured for the endpoint connection does not take effect.</para>
            /// </description></item>
            /// <item><description><para>BandwidthLimit: the bandwidth limit of the endpoint connection. The bandwidth limit is the value of Bandwidth.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BandwidthLimit</para>
            /// </summary>
            [NameInMap("TrafficControlMode")]
            [Validation(Required=false)]
            public string TrafficControlMode { get; set; }

            /// <summary>
            /// <para>The zone information.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListVpcEndpointConnectionsResponseBodyConnectionsZones> Zones { get; set; }
            public class ListVpcEndpointConnectionsResponseBodyConnectionsZones : TeaModel {
                /// <summary>
                /// <para>The endpoint ENI ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hp32lk0pyv6o94hs****</para>
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>The ID of the endpoint ENI that is replaced in the smooth migration scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hp32lk0pyv6o94hs****</para>
                /// </summary>
                [NameInMap("ReplacedEniId")]
                [Validation(Required=false)]
                public string ReplacedEniId { get; set; }

                /// <summary>
                /// <para>The ID of the service resource that is replaced in the smooth migration scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-hp32z1wp5peaoox2q****</para>
                /// </summary>
                [NameInMap("ReplacedResourceId")]
                [Validation(Required=false)]
                public string ReplacedResourceId { get; set; }

                /// <summary>
                /// <para>The service resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-hp32z1wp5peaoox2q****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The vSwitch to which the endpoint belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-hp3uf6045ljdhd5zr****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The domain name of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ep-hp34jaz8ykl0exwt****-cn-huhehaote.epsrv-hp3vpx8yqxblby3i****.cn-huhehaote-b.privatelink.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ZoneDomain")]
                [Validation(Required=false)]
                public string ZoneDomain { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The state of the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b>: The zone is being created.</description></item>
                /// <item><description><b>Wait</b>: The zone is waiting to be connected.</description></item>
                /// <item><description><b>Connected</b>: The zone is connected.</description></item>
                /// <item><description><b>Deleting</b>: The zone is being deleted.</description></item>
                /// <item><description><b>Disconnecting</b>: The zone is being disconnected.</description></item>
                /// <item><description><b>Disconnected</b>: The zone is disconnected.</description></item>
                /// <item><description><b>Connecting</b>: The zone is being connected.</description></item>
                /// <item><description><b>Migrating</b>: The zone is being migrated.</description></item>
                /// <item><description><b>Migrated</b>: The zone is migrated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Connected</para>
                /// </summary>
                [NameInMap("ZoneStatus")]
                [Validation(Required=false)]
                public string ZoneStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is to be sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned in the endpoint connection list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

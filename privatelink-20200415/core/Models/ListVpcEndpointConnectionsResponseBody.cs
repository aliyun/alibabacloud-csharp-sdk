// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint connections.</para>
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public List<ListVpcEndpointConnectionsResponseBodyConnections> Connections { get; set; }
        public class ListVpcEndpointConnectionsResponseBodyConnections : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the endpoint connection. Valid values: <b>1024 to 10240</b>. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The state of the endpoint connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: The connection is being modified.</description></item>
            /// <item><description><b>Connecting</b>: The connection is being established.</description></item>
            /// <item><description><b>Connected</b>: The connection is established.</description></item>
            /// <item><description><b>Disconnecting</b>: The endpoint is being disconnected from the endpoint service.</description></item>
            /// <item><description><b>Disconnected</b>: The endpoint is disconnected from the endpoint service.</description></item>
            /// <item><description><b>Deleting</b>: The connection is being deleted.</description></item>
            /// <item><description><b>ServiceDeleted</b>: The corresponding endpoint service has been deleted.</description></item>
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
            /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp356stwkxg3fn2xe****</para>
            /// </summary>
            [NameInMap("EndpointVpcId")]
            [Validation(Required=false)]
            public string EndpointVpcId { get; set; }

            /// <summary>
            /// <para>The time when the endpoint connection was modified.</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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

            [NameInMap("TrafficControlMode")]
            [Validation(Required=false)]
            public string TrafficControlMode { get; set; }

            /// <summary>
            /// <para>The zones.</para>
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
                /// <para>The ID of the replaced endpoint ENI in smooth migration scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hp32lk0pyv6o94hs****</para>
                /// </summary>
                [NameInMap("ReplacedEniId")]
                [Validation(Required=false)]
                public string ReplacedEniId { get; set; }

                /// <summary>
                /// <para>The ID of the replaced service resource in smooth migration scenarios.</para>
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
                /// <para>The ID of the vSwitch to which the endpoint belongs.</para>
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
                /// <item><description><b>Wait</b>: The zone is to be connected.</description></item>
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
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next requests are performed.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

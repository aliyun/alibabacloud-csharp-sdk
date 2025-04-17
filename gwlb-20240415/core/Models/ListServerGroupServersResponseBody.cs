// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListServerGroupServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next page exists.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The backend servers.</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public List<ListServerGroupServersResponseBodyServers> Servers { get; set; }
        public class ListServerGroupServersResponseBodyServers : TeaModel {
            /// <summary>
            /// <para>The backend server port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>6081</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6081</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-atstuj3rtoptyui****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The backend server ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// <para>The IP address of the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xxx.xxx</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <para>The type of the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ecs</b>: Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>Eni</b>: elastic network interface (ENI)</description></item>
            /// <item><description><b>Eci</b>: elastic container instance</description></item>
            /// <item><description><b>Ip</b>: IP address</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>Indicates the status of the backend server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Adding</b>: The backend server is being added.</description></item>
            /// <item><description><b>Available</b>: The backend server is available.</description></item>
            /// <item><description><b>Draining</b>: The backend server is in connection draining.</description></item>
            /// <item><description><b>Removing</b>: The backend server is being removed.</description></item>
            /// <item><description><b>Replacing</b>: The backend server is being replaced.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

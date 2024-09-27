// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTerminalSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the sessions.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public DescribeTerminalSessionsResponseBodySessions Sessions { get; set; }
        public class DescribeTerminalSessionsResponseBodySessions : TeaModel {
            [NameInMap("Session")]
            [Validation(Required=false)]
            public List<DescribeTerminalSessionsResponseBodySessionsSession> Session { get; set; }
            public class DescribeTerminalSessionsResponseBodySessionsSession : TeaModel {
                /// <summary>
                /// <para>The IP address of the client used to establish connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

                /// <summary>
                /// <para>The information of the connections.</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public DescribeTerminalSessionsResponseBodySessionsSessionConnections Connections { get; set; }
                public class DescribeTerminalSessionsResponseBodySessionsSessionConnections : TeaModel {
                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public List<DescribeTerminalSessionsResponseBodySessionsSessionConnectionsConnection> Connection { get; set; }
                    public class DescribeTerminalSessionsResponseBodySessionsSessionConnectionsConnection : TeaModel {
                        /// <summary>
                        /// <para>The reason why the connection was closed. This parameter is returned only when the <c>Status</c> value is <c>Disconnected</c>, <c>Terminated</c>, or <c>Failed</c>. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>InstanceNotExists: The specified instance did not exist or was released.</description></item>
                        /// <item><description>InstanceNotRunning: The specified instance was not running.</description></item>
                        /// <item><description>DeliveryTimeout: The connection timed out.</description></item>
                        /// <item><description>AgentNeedUpgrade: Cloud Assistant Agent required an upgrade.</description></item>
                        /// <item><description>AgentNotOnline: Cloud Assistant Agent was not connected to the Cloud Assistant server.</description></item>
                        /// <item><description>MessageFormatInvalid: The message format was invalid.</description></item>
                        /// <item><description>AgentSocketClosed: The connection was closed as expected.</description></item>
                        /// <item><description>ClientClosed: Session Manager Client closed the connection.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AgentNeedUpgrade</para>
                        /// </summary>
                        [NameInMap("ClosedReason")]
                        [Validation(Required=false)]
                        public string ClosedReason { get; set; }

                        /// <summary>
                        /// <para>The time when the connection was closed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-01-19T09:16:46Z</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp1i7gg30r52z2em****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The time when the connection started to be established.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-01-19T09:16:40Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The state of the session. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Connecting: The connection is being established.</description></item>
                        /// <item><description>Connected: The connection is established.</description></item>
                        /// <item><description>Disconnected: The connection is disconnected.</description></item>
                        /// <item><description>Terminating: The session is being terminated.</description></item>
                        /// <item><description>Terminated: The session is terminated.</description></item>
                        /// <item><description>Failed: The connection failed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Connecting</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-19T09:15:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The principal type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Account: an Alibaba Cloud account</description></item>
                /// <item><description>RAMUser: a RAM user</description></item>
                /// <item><description>AssumedRoleUser: a RAM role</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RAMUser</para>
                /// </summary>
                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                /// <summary>
                /// <para>The port number of the instance, which is used for data forwarding. If no port number was specified for data forwarding when the session was created, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public int? PortNumber { get; set; }

                /// <summary>
                /// <para>The ID of the principal. Valid values based on the <c>IdentityType</c> value:</para>
                /// <list type="bullet">
                /// <item><description>If the requester uses an Alibaba Cloud account to call the operation, the ID of the Alibaba Cloud account is returned.</description></item>
                /// <item><description>If the requester uses a Resource Access Management (RAM) user to call the operation, the ID of the RAM user is returned.</description></item>
                /// <item><description>If the requester uses a RAM role to call the operation, the ID of the principal that actually calls the operation is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>123456xxxx</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-hz023od0x9****</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The address of the service that was accessed in a virtual private cloud (VPC) from the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.246</para>
                /// </summary>
                [NameInMap("TargetServer")]
                [Validation(Required=false)]
                public string TargetServer { get; set; }

                /// <summary>
                /// <para>The username used to establish connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTerminalSessionsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the sessions.
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
                /// The IP address of the client used to establish connections.
                /// </summary>
                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

                /// <summary>
                /// The information of the connections.
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
                        /// The reason why the connection was closed. This parameter is returned only when the `Status` value is `Disconnected`, `Terminated`, or `Failed`. Valid values:
                        /// 
                        /// *   InstanceNotExists: The specified instance did not exist or was released.
                        /// *   InstanceNotRunning: The specified instance was not running.
                        /// *   DeliveryTimeout: The connection timed out.
                        /// *   AgentNeedUpgrade: Cloud Assistant Agent required an upgrade.
                        /// *   AgentNotOnline: Cloud Assistant Agent was not connected to the Cloud Assistant server.
                        /// *   MessageFormatInvalid: The message format was invalid.
                        /// *   AgentSocketClosed: The connection was closed as expected.
                        /// *   ClientClosed: Session Manager Client closed the connection.
                        /// </summary>
                        [NameInMap("ClosedReason")]
                        [Validation(Required=false)]
                        public string ClosedReason { get; set; }

                        /// <summary>
                        /// The time when the connection was closed.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The instance ID.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The time when the connection started to be established.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// The state of the session. Valid values:
                        /// 
                        /// *   Connecting: The connection is being established.
                        /// *   Connected: The connection is established.
                        /// *   Disconnected: The connection is disconnected.
                        /// *   Terminating: The session is being terminated.
                        /// *   Terminated: The session is terminated.
                        /// *   Failed: The connection failed.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The time when the session was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The principal type. Valid values:
                /// 
                /// *   Account: an Alibaba Cloud account
                /// *   RAMUser: a RAM user
                /// *   AssumedRoleUser: a RAM role
                /// </summary>
                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                /// <summary>
                /// The port number of the instance, which is used for data forwarding. If no port number was specified for data forwarding when the session was created, this parameter is empty.
                /// </summary>
                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public int? PortNumber { get; set; }

                /// <summary>
                /// The ID of the principal. Valid values based on the `IdentityType` value:
                /// 
                /// *   If the requester uses an Alibaba Cloud account to call the operation, the ID of the Alibaba Cloud account is returned.
                /// *   If the requester uses a Resource Access Management (RAM) user to call the operation, the ID of the RAM user is returned.
                /// *   If the requester uses a RAM role to call the operation, the ID of the principal that actually calls the operation is returned.
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// The session ID.
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// The address of the service that was accessed in a virtual private cloud (VPC) from the instance.
                /// </summary>
                [NameInMap("TargetServer")]
                [Validation(Required=false)]
                public string TargetServer { get; set; }

                /// <summary>
                /// The username used to establish connections.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

    }

}

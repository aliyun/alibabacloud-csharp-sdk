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

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public DescribeTerminalSessionsResponseBodySessions Sessions { get; set; }
        public class DescribeTerminalSessionsResponseBodySessions : TeaModel {
            [NameInMap("Session")]
            [Validation(Required=false)]
            public List<DescribeTerminalSessionsResponseBodySessionsSession> Session { get; set; }
            public class DescribeTerminalSessionsResponseBodySessionsSession : TeaModel {
                [NameInMap("ClientIP")]
                [Validation(Required=false)]
                public string ClientIP { get; set; }

                [NameInMap("Connections")]
                [Validation(Required=false)]
                public DescribeTerminalSessionsResponseBodySessionsSessionConnections Connections { get; set; }
                public class DescribeTerminalSessionsResponseBodySessionsSessionConnections : TeaModel {
                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public List<DescribeTerminalSessionsResponseBodySessionsSessionConnectionsConnection> Connection { get; set; }
                    public class DescribeTerminalSessionsResponseBodySessionsSessionConnectionsConnection : TeaModel {
                        [NameInMap("ClosedReason")]
                        [Validation(Required=false)]
                        public string ClosedReason { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("FailedDetail")]
                        [Validation(Required=false)]
                        public string FailedDetail { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public int? PortNumber { get; set; }

                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("TargetServer")]
                [Validation(Required=false)]
                public string TargetServer { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

    }

}

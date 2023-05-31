// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskResponseBody : TeaModel {
        /// <summary>
        /// The results of security check tasks.
        /// </summary>
        [NameInMap("PushTaskRsp")]
        [Validation(Required=false)]
        public ModifyPushAllTaskResponseBodyPushTaskRsp PushTaskRsp { get; set; }
        public class ModifyPushAllTaskResponseBodyPushTaskRsp : TeaModel {
            /// <summary>
            /// An array consisting of the servers on which security check tasks failed.
            /// </summary>
            [NameInMap("PushTaskResultList")]
            [Validation(Required=false)]
            public List<ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList> PushTaskResultList { get; set; }
            public class ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList : TeaModel {
                /// <summary>
                /// The ID of the server group to which the server belongs.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// The ID of the server.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the server.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The IP address of the server.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The message that describes the security check failure.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the Security Center agent is online. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// 
                /// >  If the Security Center agent of the server is offline, Security Center does not protect the server.
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                /// <summary>
                /// The operating system version of the server.
                /// </summary>
                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// The region in which the server resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// Indicates whether the security check task is successful. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// The UUID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

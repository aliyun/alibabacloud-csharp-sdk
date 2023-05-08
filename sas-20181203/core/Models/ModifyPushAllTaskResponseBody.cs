// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the server group to which the server belongs.
        /// </summary>
        [NameInMap("PushTaskRsp")]
        [Validation(Required=false)]
        public ModifyPushAllTaskResponseBodyPushTaskRsp PushTaskRsp { get; set; }
        public class ModifyPushAllTaskResponseBodyPushTaskRsp : TeaModel {
            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("PushTaskResultList")]
            [Validation(Required=false)]
            public List<ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList> PushTaskResultList { get; set; }
            public class ModifyPushAllTaskResponseBodyPushTaskRspPushTaskResultList : TeaModel {
                /// <summary>
                /// The region in which the server resides.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the server.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// ModifyPushAllTask
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Performs security check tasks on servers with a few clicks.
                /// </summary>
                [NameInMap("Online")]
                [Validation(Required=false)]
                public bool? Online { get; set; }

                [NameInMap("OsVersion")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// 1.2.XX.XX
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The ID of the request, which is used to locate and troubleshoot issues.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// Indicates whether the Security Center agent is online. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// 
                /// >  If the Security Center agent of the server is offline, Security Center does not protect the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        /// <summary>
        /// HEALTH_CHECK,OVAL_ENTITY
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
